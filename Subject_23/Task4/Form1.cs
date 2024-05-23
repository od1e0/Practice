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

            Control newControl = CreateControl(controlType);
            if (newControl != null)
            {
                ConfigureControl(newControl, xCoord, yCoord);
                Controls.Add(newControl);
                SetControlRemoval(newControl);
            }
        }

        private Control CreateControl(string controlType)
        {
            switch (controlType)
            {
                case "К":
                    return CreateButton();
                case "П":
                    return CreateTextBox();
                case "М":
                    return CreateLabel();
                default:
                    MessageBox.Show("Введите корректный тип элемента (К, П, М)");
                    return null;
            }
        }
        private Control CreateButton()
        {
            Button button = new Button();
            button.Text = "Новая кнопка";
            button.BackColor = Color.LightBlue;
            return button;
        }

        private Control CreateTextBox()
        {
            TextBox textBox = new TextBox();
            textBox.Text = "Новое поле";
            return textBox;
        }

        private Control CreateLabel()
        {
            Label label = new Label();
            label.Text = "Новая метка";
            label.ForeColor = Color.Red;
            return label;
        }

        private void ConfigureControl(Control control, int xCoord, int yCoord)
        {
            control.Location = new Point(xCoord, yCoord);
            control.Size = new Size(100, 30);
        }

        private void SetControlRemoval(Control control)
        {
            control.MouseEnter += (s, ev) => Controls.Remove(control);
        }
    }
}
