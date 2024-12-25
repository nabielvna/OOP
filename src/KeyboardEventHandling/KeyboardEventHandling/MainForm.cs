﻿using System;
using System.Drawing;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace KeyboardEventHandling
{
    public class MainForm : Form
    {
        private Box _box;
        private int _moveSpeed = 10;
        private bool _goLeft, _goRight, _goUp, _goDown, _changeColor;
        private Size _screenSize;

        public MainForm()
        {
            _screenSize = new Size(400, 400);

            // Mengatur properti dasar form
            this.Text = "Keyboard Event Handling";
            this.Size = _screenSize;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Inisialisasi Box dan menambahkannya ke form
            _box = new Box(175, 175, Color.Blue, new Size(50, 50), _moveSpeed);
            this.Controls.Add(_box.GetPictureBox());

            // Menangani event KeyDown dan KeyUp untuk menangkap input keyboard
            this.KeyDown += new KeyEventHandler(OnKeyDown);
            this.KeyUp += new KeyEventHandler(OnKeyUp);

            // Timer untuk mengontrol gerakan objek
            Timer timer = new Timer();
            timer.Interval = 20;
            timer.Tick += new EventHandler(UpdatePosition);
            timer.Start();
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            // Menentukan tombol mana yang ditekan dan mengubah nilai boolean sesuai tombol
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A) _goLeft = true;
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D) _goRight = true;
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W) _goUp = true;
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S) _goDown = true;
            if (e.KeyCode == Keys.Space) _changeColor = true;
        }

        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            // Mengatur kembali nilai boolean saat tombol dilepaskan
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A) _goLeft = false;
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D) _goRight = false;
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W) _goUp = false;
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S) _goDown = false;
            if (e.KeyCode == Keys.Space) _changeColor = false;
        }

        private void UpdatePosition(object sender, EventArgs e)
        {
            // Menggerakkan objek sesuai tombol yang ditekan
            if (_goLeft) _box.MoveLeft();
            if (_goRight) _box.MoveRight(_screenSize.Width);
            if (_goUp) _box.MoveUp();
            if (_goDown) _box.MoveDown(_screenSize.Height);
            if (_changeColor) _box.ChangeColor();
        }
    }
}