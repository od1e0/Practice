using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task7
{
    public partial class Form1 : Form
    {
        private const int circleRadius = 20;
        private const int amplitude = 100;
        private const int frequency = 2;
        private const int offsetX = 100;
        private const int offsetY = 150;

        private Timer timer;
        private double time = 0;

        public Form1()
        {
            InitializeComponent();
            InitializeTimer();
            this.Paint += Form1_Paint;
        }
        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            time += 0.1;

            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int x = 0; x < ClientSize.Width; x++)
            {
                int y = (int)(amplitude * Math.Sin(frequency * (x + offsetX) * Math.PI / ClientSize.Width) + offsetY);
                e.Graphics.FillRectangle(Brushes.Black, x, y, 1, 1);
            }

            int circleX = (int)((ClientSize.Width / 2 + amplitude * Math.Cos(frequency * time)) % ClientSize.Width);
            int circleY = (int)(amplitude * Math.Sin(frequency * time) + offsetY);
            e.Graphics.FillEllipse(Brushes.Red, circleX - circleRadius, circleY - circleRadius, 2 * circleRadius, 2 * circleRadius);
        }
    }
}
