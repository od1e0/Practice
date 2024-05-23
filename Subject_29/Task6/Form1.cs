using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task6
{
    public partial class Form1 : Form
    {
        private const int clockRadius = 100;
        private const int secondsHandLength = 80;

        private Timer timer;
        private PictureBox pictureBox;

        public Form1()
        {
            InitializeComponent();
            InitializeClock();
            InitializePictureBox();
        }

        private void InitializeClock()
        {
            this.BackColor = Color.White;

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void InitializePictureBox()
        {
            pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Paint += PictureBox_Paint;
            this.Controls.Add(pictureBox);
        }

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(Pens.Black, pictureBox.Width / 2 - clockRadius, pictureBox.Height / 2 - clockRadius, clockRadius * 2, clockRadius * 2);

            double angle = (DateTime.Now.Second / 60.0) * 2 * Math.PI;
            int x = (int)(pictureBox.Width / 2 + secondsHandLength * Math.Sin(angle));
            int y = (int)(pictureBox.Height / 2 - secondsHandLength * Math.Cos(angle));

            e.Graphics.DrawLine(Pens.Red, pictureBox.Width / 2, pictureBox.Height / 2, x, y);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            pictureBox.Invalidate();
        }
    }
}
