using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task5
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private int rocketY;
        private bool isLaunching;
        public Form1()
        {
            InitializeComponent();

            rocketY = pictureBoxRocket.Location.Y;
            isLaunching = false;

            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;

            buttonLaunch.Click += ButtonLaunch_Click;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (isLaunching)
            {
                rocketY -= 5;
                pictureBoxRocket.Location = new Point(pictureBoxRocket.Location.X, rocketY);

                if (rocketY <= 10)
                {
                    isLaunching = false;
                    timer.Stop();
                }
            }
        }

        private void ButtonLaunch_Click(object sender, EventArgs e)
        {
            if (!isLaunching)
            {
                isLaunching = true;
                timer.Start();
            }
        }
    }
}
