using System;
using System.Windows.Forms;

namespace SpriteAnimation
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new LevelForm());
        }
    }
}