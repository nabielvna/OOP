using System.Drawing;

namespace DrawingToolkit
{
    public class Line : DrawingObject
    {
        public Line(int x1, int y1, int x2, int y2, Color color)
            : base(x1, y1, x2, y2, color) { }

        public override void Draw(Graphics g)
        {
            using var pen = new Pen(Color);
            g.DrawLine(pen, X1, Y1, X2, Y2);
        }
    }
}