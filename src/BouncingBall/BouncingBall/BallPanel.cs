using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BouncingBall
{
    public class BallPanel : Panel
    {
        private readonly BallArea _area;
        private readonly List<Ball> _balls = new();
        private readonly Random _random = new();

        public BallPanel(int width, int height)
        {
            DoubleBuffered = true;
            Size = new Size(width, height);
            BackColor = Color.Black;

            _area = new BallArea(0, 0, width, height, Color.Black, Color.White);

            MouseClick += (s, e) =>
            {
                var radius = 20;
                var speed = 5;
                var angle = _random.Next(360);
                var newBall = new Ball(e.X, e.Y, radius, speed, angle,
                    Color.FromArgb(_random.Next(256), _random.Next(256), _random.Next(256)));
                _balls.Add(newBall);
            };

            Task.Run(() => StartAnimation());
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            _area.Draw(e.Graphics);

            foreach (var ball in _balls)
            {
                ball.Draw(e.Graphics);
            }
        }

        private async Task StartAnimation()
        {
            while (true)
            {
                foreach (var ball in _balls)
                {
                    ball.CollideWithWalls(_area);
                    ball.X += ball.SpeedX;
                    ball.Y += ball.SpeedY;
                }

                for (int i = 0; i < _balls.Count; i++)
                {
                    for (int j = i + 1; j < _balls.Count; j++)
                    {
                        _balls[i].CollideWithBall(_balls[j]);
                    }
                }

                Invalidate();
                await Task.Delay(30);
            }
        }
    }
}
