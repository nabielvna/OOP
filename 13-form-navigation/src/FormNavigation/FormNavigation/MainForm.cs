﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormNavigation
{
    public class MainForm : Form
    {
        private Button startGameButton;
        private Button highScoreButton;
        private Button exitButton;

        public MainForm()
        {
            InitializeForm();
            InitializeControls();
        }

        private void InitializeForm()
        {
            this.Text = "Main Menu";
            this.Size = new Size(400, 300);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void InitializeControls()
        {
            // Tombol Start Game
            startGameButton = new Button
            {
                Text = "Start Game",
                Location = new Point(150, 50),
                Size = new Size(100, 30)
            };
            startGameButton.Click += StartGameButton_Click;
            this.Controls.Add(startGameButton);

            // Tombol High Score
            highScoreButton = new Button
            {
                Text = "High Score",
                Location = new Point(150, 100),
                Size = new Size(100, 30)
            };
            highScoreButton.Click += HighScoreButton_Click;
            this.Controls.Add(highScoreButton);

            // Tombol Exit
            exitButton = new Button
            {
                Text = "Exit",
                Location = new Point(150, 150),
                Size = new Size(100, 30)
            };
            exitButton.Click += ExitButton_Click;
            this.Controls.Add(exitButton);
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm();
            gameForm.FormClosed += (s, args) => this.Show(); // Menampilkan kembali MainForm saat GameForm ditutup
            gameForm.Show();
            this.Hide();
        }
        private void HighScoreButton_Click(object sender, EventArgs e)
        {
            HighScoreForm highScoreForm = new HighScoreForm();
            highScoreForm.ShowDialog();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}