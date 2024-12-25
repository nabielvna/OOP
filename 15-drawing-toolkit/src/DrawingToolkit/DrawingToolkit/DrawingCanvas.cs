using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DrawingToolkit
{
    public class DrawingCanvas : Panel
    {
        private List<DrawingObject> shapes = new();
        private ShapeType currentShapeType = ShapeType.Line;
        private DrawingObject currentShape;
        private bool isDrawing = false;

        public DrawingCanvas()
        {
            this.DoubleBuffered = true;
            this.BackColor = Color.White;

            this.MouseDown += OnMouseDown;
            this.MouseMove += OnMouseMove;
            this.MouseUp += OnMouseUp;
        }

        public void SetCurrentShapeType(ShapeType shapeType)
        {
            currentShapeType = shapeType;
        }

        public void Clear()
        {
            shapes.Clear();
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            foreach (var shape in shapes)
            {
                shape.Draw(e.Graphics);
            }
            if (currentShape != null)
            {
                currentShape.Draw(e.Graphics);
            }
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            switch (currentShapeType)
            {
                case ShapeType.Line:
                    currentShape = new Line(e.X, e.Y, e.X, e.Y, Color.Black);
                    break;
                case ShapeType.Circle:
                    currentShape = new Circle(e.X, e.Y, e.X, e.Y, Color.Black);
                    break;
                case ShapeType.Rectangle:
                    currentShape = new Rectangle(e.X, e.Y, e.X, e.Y, Color.Black);
                    break;
            }
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing && currentShape != null)
            {
                currentShape.X2 = e.X;
                currentShape.Y2 = e.Y;
                Invalidate();
            }
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing && currentShape != null)
            {
                shapes.Add(currentShape);
                currentShape = null;
                isDrawing = false;
                Invalidate();
            }
        }
    }
}