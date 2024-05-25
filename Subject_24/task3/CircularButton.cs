using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task3
{
    public partial class CircularButton : Control
    {

        private bool isMouseOver = false;
        private bool isMouseDown = false;
        public CircularButton()
        {
            InitializeComponent();
            this.Size = new Size(100, 100);
            this.BackColor = Color.Green;
        }

        public CircularButton(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            this.Size = new Size(100, 100);
            this.BackColor = Color.Green;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Brush brush = new SolidBrush(this.BackColor);
            g.FillEllipse(brush, 0, 0, this.Width, this.Height);

            if (this.Text != string.Empty)
            {
                StringFormat sf = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };
                g.DrawString(this.Text, this.Font, Brushes.White, this.ClientRectangle, sf);
            }
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            isMouseOver = true;
            this.BackColor = Color.LightGreen;
            this.Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            isMouseOver = false;
            this.BackColor = Color.Green;
            this.Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            isMouseDown = true;
            this.BackColor = Color.DarkGreen;
            this.Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            isMouseDown = false;
            this.BackColor = isMouseOver ? Color.LightGreen : Color.Green;
            this.Invalidate();
        }

    }
}
