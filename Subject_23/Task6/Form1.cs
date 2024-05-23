using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task6
{
    public partial class Form1 : Form
    {

        int[] Mas = new int[12];

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            Random rand = new Random();

            for (int i = 0; i < 12; i++)
            {
                Mas[i] = rand.Next(-50, 50);
                listBox1.Items.Add($"Mas[{i}] = {Mas[i]}");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int sumOfEvens = 0;

            for (int i = 0; i < 12; i++)
            {
                if (Mas[i] % 2 == 0)
                    sumOfEvens += Mas[i];
            }

            listBox2.Items.Clear();
            listBox2.Items.Add($"Сумма четных элементов: {sumOfEvens}");
        }
    }
}
