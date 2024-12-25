using System.Drawing;

namespace DrawingToolkit
{
    public abstract class DrawingObject
    {
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }
        public Color Color { get; set; }

        protected DrawingObject(int x1, int y1, int x2, int y2, Color color)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
            Color = color;
        }

        public abstract void Draw(Graphics g);
    }
}