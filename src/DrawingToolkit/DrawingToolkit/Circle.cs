using System;
using System.Drawing;

namespace DrawingToolkit
{
    public class Circle : DrawingObject
    {
        public Circle(int x1, int y1, int x2, int y2, Color color)
            : base(x1, y1, x2, y2, color) { }

        public override void Draw(Graphics g)
        {
            var width = Math.Abs(X2 - X1);
            var height = Math.Abs(Y2 - Y1);
            var size = Math.Max(width, height);
            var x = Math.Min(X1, X2);
            var y = Math.Min(Y1, Y2);

            using var pen = new Pen(Color);
            g.DrawEllipse(pen, x, y, size, size);
        }
    }
}