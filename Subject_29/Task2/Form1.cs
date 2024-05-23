using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        Bitmap banner;
        Rectangle rectangle;

        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Form1_Paint);

            try
            {
                banner = new Bitmap("baner.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки файла баннера\n " + ex.ToString(), "Баннер");
                this.Close();
                return;
            }

            rectangle = new Rectangle(100, 100, banner.Width, banner.Height);

            timer1.Interval = 50;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rectangle.X -= 1;

            if (Math.Abs(rectangle.X) > rectangle.Width)
                rectangle.X += rectangle.Width;

            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; 
            g.DrawImage(banner, rectangle);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Y >= rectangle.Y && e.Y <= rectangle.Y + rectangle.Height)
            {
                timer1.Enabled = false;
            }
            else
            {
                timer1.Enabled = true;
            }
        }
    }
}
