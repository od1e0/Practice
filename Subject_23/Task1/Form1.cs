namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;

            if (index != -1)
            {
                string str = (string)listBox1.Items[index];

                string result = SwapFirstAndLastLetters(str);

                label1.Text = "Результат: " + result;
            }
            else
            {
                label1.Text = "Ошибка: Не выбрана строка!";
            }
        }

        private string SwapFirstAndLastLetters(string input)
        {
            string[] words = input.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 1)
                {
                    char firstChar = words[i][0]; 
                    char lastChar = words[i][words[i].Length - 1]; 

                    words[i] = lastChar + words[i].Substring(1, words[i].Length - 2) + firstChar;
                }
            }

            string result = string.Join(" ", words);

            return result;
        }

    }
}
