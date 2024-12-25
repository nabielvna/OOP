using System;
using System.Windows.Forms;

namespace BouncingBall
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var form = new Form
            {
                Text = "Bouncing Balls Simulation",
                ClientSize = new Size(800, 600)
            };

            var ballPanel = new BallPanel(800, 600);
            form.Controls.Add(ballPanel);

            Application.Run(form);
        }
    }
}
