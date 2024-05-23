using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Task7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] R = new int[9, 9];

            Random rand = new Random();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    R[i, j] = rand.Next(-100, 100);
                }
            }

            dataGridView1.RowCount = 9;
            dataGridView1.ColumnCount = 9;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = R[i, j].ToString();
                }
            }

            int[] minElements = new int[9];
            for (int i = 0; i < 9; i++)
            {
                int min = int.MaxValue;
                for (int j = 0; j < 9; j++)
                {
                    if (R[i, j] < min)
                    {
                        min = R[i, j];
                    }
                }
                minElements[i] = min;
                R[i, 0] = min;
            }

            dataGridView2.RowCount = 9;
            dataGridView2.ColumnCount = 9;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    dataGridView2.Rows[i].Cells[j].Value = R[i, j].ToString();
                }
            }

            textBox1.Text = string.Join(", ", minElements);
        }
    }
}
