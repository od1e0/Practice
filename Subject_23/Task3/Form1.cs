using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Form1_Paint);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Настройка кистей и перьев
            Pen blackPen = new Pen(Color.Black, 2);
            Brush brownBrush = new SolidBrush(Color.Brown);
            Brush whiteBrush = new SolidBrush(Color.White);
            Brush blackBrush = new SolidBrush(Color.Black);

            g.FillEllipse(brownBrush, 100, 50, 200, 150);
            g.DrawEllipse(blackPen, 100, 50, 200, 150);

            g.FillEllipse(whiteBrush, 140, 100, 30, 30);
            g.FillEllipse(whiteBrush, 230, 100, 30, 30);
            g.FillEllipse(blackBrush, 150, 110, 10, 10);
            g.FillEllipse(blackBrush, 240, 110, 10, 10);

            g.FillEllipse(blackBrush, 185, 155, 30, 20);

            g.FillEllipse(brownBrush, 70, 50, 60, 100);
            g.FillEllipse(brownBrush, 270, 50, 60, 100);
            g.DrawEllipse(blackPen, 70, 50, 60, 100);
            g.DrawEllipse(blackPen, 270, 50, 60, 100);

            g.FillEllipse(brownBrush, 70, 200, 260, 150);
            g.DrawEllipse(blackPen, 70, 200, 260, 150);

            g.FillEllipse(brownBrush, 90, 330, 40, 70);
            g.FillEllipse(brownBrush, 270, 330, 40, 70);
            g.DrawEllipse(blackPen, 90, 330, 40, 70);
            g.DrawEllipse(blackPen, 270, 330, 40, 70);

            g.DrawLine(blackPen, 324, 250, 400, 200);

            g.DrawArc(blackPen, 150, 165, 100, 50, 0, -180);
        }
    }
}
