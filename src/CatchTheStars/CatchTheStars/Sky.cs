// Program.cs
using System;
using System.Media;
using System.Windows.Forms;

namespace CatchTheStars;
public class Sky : Form
{
    private Basket _basket;
    private Star _star;
    private Label _scoreLabel;
    private int _score;
    private bool _goLeft, _goRight;
    private System.Windows.Forms.Timer _gameTimer;
    private SoundPlayer _collisionSound;

    public Sky()
    {
        InitializeForm();
        InitializeGame();
        InitializeControls();
    }

    private void InitializeForm()
    {
        Text = "Catch the Falling Stars";
        Size = new Size(800, 600);
        StartPosition = FormStartPosition.CenterScreen;
        _score = 0;
        _collisionSound = new SoundPlayer(Resource.coin);
    }

    private void InitializeGame()
    {
        _scoreLabel = new Label
        {
            Text = "Score: 0",
            Location = new Point(10, 10),
            Font = new Font("Arial", 16),
            ForeColor = Color.Black
        };
        Controls.Add(_scoreLabel);

        _basket = new Basket(ClientSize, 15);
        Controls.Add(_basket.GetPictureBox());

        _star = new Star(5, ClientSize);
        Controls.Add(_star.GetPictureBox());

        _gameTimer = new System.Windows.Forms.Timer
        {
            Interval = 20
        };
        _gameTimer.Tick += new EventHandler(GameLoop);
        _gameTimer.Start();
    }

    private void InitializeControls()
    {
        KeyDown += new KeyEventHandler(OnKeyDown);
        KeyUp += new KeyEventHandler(OnKeyUp);
    }

    private void OnKeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Left) _goLeft = true;
        if (e.KeyCode == Keys.Right) _goRight = true;
    }

    private void OnKeyUp(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Left) _goLeft = false;
        if (e.KeyCode == Keys.Right) _goRight = false;
    }

    private void GameLoop(object sender, EventArgs e)
    {
        _star.Fall();

        if (_goLeft) _basket.MoveLeft();
        if (_goRight) _basket.MoveRight(ClientSize.Width);

        if (_basket.IsCollidedWith(_star))
        {
            _collisionSound.Play();
            UpdateScore();
            GenerateStar();
        }
        else if (_star.IsOutOfSky(ClientSize))
        {
            GenerateStar();
        }
    }

    private void UpdateScore()
    {
        _score++;
        _scoreLabel.Text = "Score: " + _score;
    }

    private void GenerateStar()
    {
        if (_star != null)
        {
            Controls.Remove(_star.GetPictureBox());
        }
        _star = new Star(5, ClientSize);
        Controls.Add(_star.GetPictureBox());
    }
}