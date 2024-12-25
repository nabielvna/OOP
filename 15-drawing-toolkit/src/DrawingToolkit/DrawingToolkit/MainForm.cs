using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrawingToolkit
{
    public class MainForm : Form
    {
        private Button clearButton, lineButton, circleButton, rectangleButton;
        private FlowLayoutPanel toolbarPanel;
        private DrawingCanvas canvas;

        public MainForm()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.Text = "Drawing Toolkit";
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Initialize toolbar dengan ukuran yang lebih besar
            toolbarPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Top,
                Height = 70, // Tinggi panel ditambah
                BackColor = Color.LightBlue,
                AutoSize = false,
                FlowDirection = FlowDirection.LeftToRight,
                Padding = new Padding(10), // Padding panel ditambah
            };

            // Fungsi untuk membuat tombol dengan ukuran yang lebih besar
            Button CreateButton(string text)
            {
                return new Button
                {
                    Text = text,
                    Width = 170,  // Lebar tombol ditambah
                    Height = 40,  // Tinggi tombol ditambah
                    Margin = new Padding(5), // Jarak antar tombol
                    Font = new Font("Arial", 12, FontStyle.Bold), // Font lebih besar
                    BackColor = Color.White, // Warna latar tombol
                    FlatStyle = FlatStyle.Flat, // Gaya tombol yang lebih modern
                    Cursor = Cursors.Hand // Kursor berubah saat di atas tombol
                };
            }

            // Buat tombol dengan ukuran baru
            clearButton = CreateButton("Clear");
            lineButton = CreateButton("Line");
            circleButton = CreateButton("Circle");
            rectangleButton = CreateButton("Rectangle");

            // Tambahkan event handler untuk efek hover
            void AddHoverEffect(Button button)
            {
                button.MouseEnter += (s, e) => button.BackColor = Color.LightGray;
                button.MouseLeave += (s, e) => button.BackColor = Color.White;
            }

            // Terapkan efek hover ke semua tombol
            AddHoverEffect(clearButton);
            AddHoverEffect(lineButton);
            AddHoverEffect(circleButton);
            AddHoverEffect(rectangleButton);

            // Add buttons to toolbar
            toolbarPanel.Controls.Add(clearButton);
            toolbarPanel.Controls.Add(lineButton);
            toolbarPanel.Controls.Add(circleButton);
            toolbarPanel.Controls.Add(rectangleButton);

            // Initialize canvas
            canvas = new DrawingCanvas
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };

            // Add controls to form
            this.Controls.Add(toolbarPanel);
            this.Controls.Add(canvas);

            // Wire up event handlers
            clearButton.Click += (s, e) => canvas.Clear();
            lineButton.Click += (s, e) => canvas.SetCurrentShapeType(ShapeType.Line);
            circleButton.Click += (s, e) => canvas.SetCurrentShapeType(ShapeType.Circle);
            rectangleButton.Click += (s, e) => canvas.SetCurrentShapeType(ShapeType.Rectangle);
        }
    }
}