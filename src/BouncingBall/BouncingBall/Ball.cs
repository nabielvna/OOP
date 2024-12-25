namespace BouncingBall
{
    public class Ball
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Radius { get; }
        public float SpeedX { get; set; }
        public float SpeedY { get; set; }
        private readonly Color _color;

        public Ball(float x, float y, float radius, float speed, float angleInDegree, Color color)
        {
            X = x;
            Y = y;
            Radius = radius;
            _color = color;
            SpeedX = (float)(speed * Math.Cos(Math.PI * angleInDegree / 180));
            SpeedY = (float)(-speed * Math.Sin(Math.PI * angleInDegree / 180));
        }

        public void Draw(Graphics g)
        {
            using var brush = new SolidBrush(_color);
            g.FillEllipse(brush, X - Radius, Y - Radius, Radius * 2, Radius * 2);
        }

        public void CollideWithWalls(BallArea area)
        {
            if (X - Radius < area.MinX || X + Radius > area.MaxX)
            {
                SpeedX = -SpeedX;
            }

            if (Y - Radius < area.MinY || Y + Radius > area.MaxY)
            {
                SpeedY = -SpeedY;
            }
        }

        public void CollideWithBall(Ball other)
        {
            var dx = other.X - X;
            var dy = other.Y - Y;
            var distance = Math.Sqrt(dx * dx + dy * dy);

            if (distance < Radius + other.Radius)
            {
                SpeedX = -SpeedX;
                SpeedY = -SpeedY;

                other.SpeedX = -other.SpeedX;
                other.SpeedY = -other.SpeedY;
            }
        }
    }
}