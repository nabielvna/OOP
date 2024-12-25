namespace BouncingBall
{
    public class BallArea
    {
        public int MinX { get; }
        public int MinY { get; }
        public int MaxX { get; }
        public int MaxY { get; }
        private readonly Color _fillColor;
        private readonly Color _borderColor;

        public BallArea(int x, int y, int width, int height, Color fillColor, Color borderColor)
        {
            MinX = x;
            MinY = y;
            MaxX = x + width;
            MaxY = y + height;
            _fillColor = fillColor;
            _borderColor = borderColor;
        }

        public void Draw(Graphics g)
        {
            using var fillBrush = new SolidBrush(_fillColor);
            g.FillRectangle(fillBrush, MinX, MinY, MaxX - MinX, MaxY - MinY);
            using var pen = new Pen(_borderColor);
            g.DrawRectangle(pen, MinX, MinY, MaxX - MinX, MaxY - MinY);
        }
    }
}