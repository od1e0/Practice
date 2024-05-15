using System.Xml;

namespace Task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("StudentData");
            doc.AppendChild(root);

            AddElement(doc, root, "Фамилия", textBox1.Text);
            AddElement(doc, root, "Имя", textBox2.Text);

            doc.Save("StudentData.xml");
        }
        private void AddElement(XmlDocument doc, XmlElement root, string name, string text)
        {
            XmlElement element = doc.CreateElement(name);
            element.InnerText = text;
            root.AppendChild(element);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
