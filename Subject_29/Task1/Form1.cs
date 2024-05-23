using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private int angle = 0;
        public Form1()
        {
            InitializeComponent();
            InitializeTimer();
        }
        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 1000; 
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            angle += 6;
            angle %= 360; 

            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int centerX = ClientSize.Width / 2;
            int centerY = ClientSize.Height / 2;

            int endX = (int)(centerX + Math.Sin(angle * Math.PI / 180) * 50);
            int endY = (int)(centerY - Math.Cos(angle * Math.PI / 180) * 50);

            e.Graphics.DrawLine(Pens.Red, centerX, centerY, endX, endY);
        }
    }
}
