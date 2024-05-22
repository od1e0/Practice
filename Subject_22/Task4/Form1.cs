using System;
using System.Windows.Forms;

namespace Task4
{
    public partial class Form1 : Form
    {
        private TreeView treeView1;

        public Form1()
        {
            InitializeComponent();
            InitializeTreeView();
        }

        private void InitializeTreeView()
        {
            treeView1 = new TreeView();
            treeView1.Size = new System.Drawing.Size(300, 400);
            treeView1.Location = new System.Drawing.Point(700, 10);

            this.Controls.Add(treeView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();

            AddNodeToTreeView("Фамилия: ", textBox1.Text);
            AddNodeToTreeView("Имя: ", textBox2.Text);
            AddNodeToTreeView("Отчество: ", textBox3.Text);

            AddGenderNode();
            AddBirthdayNode();
            AddNodeToTreeView("Адрес проживания: ", comboBox4.SelectedItem?.ToString());
            AddNodeToTreeView("Email: ", textBox4.Text);
            AddNodeToTreeView("Номер телефона: ", textBox5.Text);

            AddWorkExperienceNodes();
            AddCheckboxNodes();

            int minSalary = (int)numericUpDown1.Value;
            int maxSalary = (int)numericUpDown2.Value;
            AddNodeToTreeView("Объем заработной платы от: ", minSalary.ToString());
            AddNodeToTreeView("Объем заработной платы до: ", maxSalary.ToString());

            AddEmploymentTypeNode();
        }

        private void AddNodeToTreeView(string label, string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                treeView1.Nodes.Add(label + value);
            }
        }

        private void AddGenderNode()
        {
            if (radioButton1.Checked)
                treeView1.Nodes.Add("Пол: женский");
            if (radioButton2.Checked)
                treeView1.Nodes.Add("Пол: мужской");
        }

        private void AddBirthdayNode()
        {
            if (comboBox1.SelectedItem != null && comboBox2.SelectedItem != null && comboBox3.SelectedItem != null)
            {
                string day = comboBox1.SelectedItem.ToString();
                string month = comboBox2.SelectedItem.ToString();
                string year = comboBox3.SelectedItem.ToString();
                treeView1.Nodes.Add($"День рождения: {day} {month} {year}");
            }
        }

        private void AddWorkExperienceNodes()
        {
            if (radioButton3.Checked)
                treeView1.Nodes.Add("Прежде не работал");
            if (radioButton4.Checked)
                treeView1.Nodes.Add("Меньше 1 года");
            if (radioButton5.Checked)
                treeView1.Nodes.Add("От 1 года до 5 лет");
            if (radioButton6.Checked)
                treeView1.Nodes.Add("От 5 до 9 лет");
            if (radioButton7.Checked)
                treeView1.Nodes.Add("10 лет и более");
        }

        private void AddCheckboxNodes()
        {
            if (checkBox1.Checked)
                treeView1.Nodes.Add("Наличие личного авто");
            if (checkBox2.Checked)
                treeView1.Nodes.Add("Водительское удостоверение");
            if (checkBox3.Checked)
                treeView1.Nodes.Add("Категория A");
            if (checkBox4.Checked)
                treeView1.Nodes.Add("Категория B");
            if (checkBox5.Checked)
                treeView1.Nodes.Add("Категория C");
            if (checkBox6.Checked)
                treeView1.Nodes.Add("Категория D");
        }

        private void AddEmploymentTypeNode()
        {
            if (radioButton8.Checked)
                treeView1.Nodes.Add("Полная занятость");
            if (radioButton9.Checked)
                treeView1.Nodes.Add("Частичная занятость");
            if (radioButton10.Checked)
                treeView1.Nodes.Add("Работа на дому");
            if (radioButton11.Checked)
                treeView1.Nodes.Add("Посменная работа");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearAllFields();
            treeView1.Nodes.Clear();
        }

        private void ClearAllFields()
        {
            textBox1.Clear();
            textBox2.Clear();

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;

            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;

            numericUpDown1.Value = numericUpDown1.Minimum;
            numericUpDown2.Value = numericUpDown2.Minimum;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
