using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string controlType = controlTypeTextBox.Text.ToUpper();
            int xCoord = int.Parse(xCoordTextBox.Text);
            int yCoord = int.Parse(yCoordTextBox.Text);

            Control newControl = null;
            switch (controlType)
            {
                case "К":
                    newControl = new Button();
                    newControl.Text = "Новая кнопка";
                    newControl.BackColor = Color.LightBlue;
                    break;
                case "П":
                    newControl = new TextBox();
                    newControl.Text = "Новое поле";
                    break;
                case "М":
                    newControl = new Label();
                    ((Label)newControl).Text = "Новая метка";
                    ((Label)newControl).ForeColor = Color.Red;
                    break;
                default:
                    MessageBox.Show("Введите корректный тип элемента (К, П, М)");
                    return;
            }

            newControl.Location = new Point(xCoord, yCoord);
            newControl.Size = new Size(100, 30);

            Controls.Add(newControl);

            newControl.MouseEnter += (s, ev) => Controls.Remove(newControl);
        }
    }
}
