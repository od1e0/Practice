namespace Task4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox2 = new GroupBox();
            comboBox3 = new ComboBox();
            label6 = new Label();
            comboBox2 = new ComboBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            groupBox3 = new GroupBox();
            radioButton8 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            label7 = new Label();
            comboBox4 = new ComboBox();
            label8 = new Label();
            textBox4 = new TextBox();
            label9 = new Label();
            comboBox5 = new ComboBox();
            textBox5 = new TextBox();
            groupBox4 = new GroupBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            label10 = new Label();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            groupBox5 = new GroupBox();
            label11 = new Label();
            label12 = new Label();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            groupBox6 = new GroupBox();
            radioButton7 = new RadioButton();
            radioButton9 = new RadioButton();
            radioButton10 = new RadioButton();
            radioButton11 = new RadioButton();
            label13 = new Label();
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(25, 12);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Фамилия";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(104, 11);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(173, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(104, 55);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(173, 27);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(59, 58);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 2;
            label2.Text = "Имя";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(104, 101);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(173, 27);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(25, 102);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 4;
            label3.Text = "Отчество";
            label3.Click += label3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(447, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 104);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Пол";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(30, 65);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(92, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Женский";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(30, 35);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(93, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Мужской";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox3);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label4);
            groupBox2.ForeColor = SystemColors.HotTrack;
            groupBox2.Location = new Point(25, 190);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(763, 129);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Дата рождения";
            // 
            // comboBox3
            // 
            comboBox3.AutoCompleteCustomSource.AddRange(new string[] { "1900", "1901", "1902", "1903", "1904", "1905", "1906", "1907", "1908", "1909", "1910", "1911", "1912", "1913", "1914", "1915", "1916", "1917", "1918", "1919", "1920", "1921", "1922", "1923", "1924", "1925", "1926", "1927", "1928", "1929", "1930", "1931", "1932", "1933", "1934", "1935", "1936", "1937", "1938", "1939", "1940", "1941", "1942", "1943", "1944", "1945", "1946", "1947", "1948", "1949", "1950", "1951", "1952", "1953", "1954", "1955", "1956", "1957", "1958", "1959", "1960", "1961", "1962", "1963", "1964", "1965", "1966", "1967", "1968", "1969", "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024" });
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(555, 73);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(173, 28);
            comboBox3.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(555, 39);
            label6.Name = "label6";
            label6.Size = new Size(33, 20);
            label6.TabIndex = 12;
            label6.Text = "Год";
            // 
            // comboBox2
            // 
            comboBox2.AutoCompleteCustomSource.AddRange(new string[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" });
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(239, 73);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(237, 28);
            comboBox2.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(239, 39);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 10;
            label5.Text = "Месяц";
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteCustomSource.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(21, 73);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(120, 28);
            comboBox1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(16, 39);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 8;
            label4.Text = "День";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButton8);
            groupBox3.Controls.Add(radioButton5);
            groupBox3.Controls.Add(radioButton6);
            groupBox3.Controls.Add(radioButton3);
            groupBox3.Controls.Add(radioButton4);
            groupBox3.ForeColor = SystemColors.HotTrack;
            groupBox3.Location = new Point(25, 469);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(763, 129);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Опыт работы";
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Location = new Point(537, 43);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(131, 24);
            radioButton8.TabIndex = 6;
            radioButton8.TabStop = true;
            radioButton8.Text = "10 лет и более";
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(296, 86);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(118, 24);
            radioButton5.TabIndex = 5;
            radioButton5.TabStop = true;
            radioButton5.Text = "От 5 до 9 лет";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(296, 43);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(153, 24);
            radioButton6.TabIndex = 4;
            radioButton6.TabStop = true;
            radioButton6.Text = "От 1 года до 5 лет";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(21, 86);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(135, 24);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "Меньше 1 года";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(21, 43);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(167, 24);
            radioButton4.TabIndex = 2;
            radioButton4.TabStop = true;
            radioButton4.Text = "Прежде не работал";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.HotTrack;
            label7.Location = new Point(25, 350);
            label7.Name = "label7";
            label7.Size = new Size(145, 20);
            label7.TabIndex = 14;
            label7.Text = "Место проживания";
            // 
            // comboBox4
            // 
            comboBox4.AutoCompleteCustomSource.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Брест", "Витебск", "Гомель", "Гродно", "Минск", "Могилев" });
            comboBox4.Location = new Point(321, 331);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(432, 28);
            comboBox4.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.HotTrack;
            label8.Location = new Point(25, 391);
            label8.Name = "label8";
            label8.Size = new Size(192, 20);
            label8.TabIndex = 15;
            label8.Text = "Адрес электронной почты";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(321, 388);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(432, 27);
            textBox4.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.HotTrack;
            label9.Location = new Point(25, 433);
            label9.Name = "label9";
            label9.Size = new Size(156, 20);
            label9.TabIndex = 17;
            label9.Text = "Мобильный телефон";
            // 
            // comboBox5
            // 
            comboBox5.AutoCompleteCustomSource.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "МТС", "Life", "A1" });
            comboBox5.Location = new Point(187, 430);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(106, 28);
            comboBox5.TabIndex = 18;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(459, 436);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(294, 27);
            textBox5.TabIndex = 19;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(checkBox6);
            groupBox4.Controls.Add(checkBox5);
            groupBox4.Controls.Add(checkBox4);
            groupBox4.Controls.Add(checkBox3);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(checkBox2);
            groupBox4.Controls.Add(checkBox1);
            groupBox4.Location = new Point(25, 622);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(250, 167);
            groupBox4.TabIndex = 20;
            groupBox4.TabStop = false;
            groupBox4.Text = "Другие сведения";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(11, 28);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(189, 24);
            checkBox1.TabIndex = 21;
            checkBox1.Text = "Наличие личного авто";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(10, 57);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(236, 24);
            checkBox2.TabIndex = 22;
            checkBox2.Text = "Водительское удостоверение";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.ControlText;
            label10.Location = new Point(6, 98);
            label10.Name = "label10";
            label10.Size = new Size(119, 20);
            label10.TabIndex = 13;
            label10.Text = "Категория прав";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(6, 131);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(41, 24);
            checkBox3.TabIndex = 23;
            checkBox3.Text = "А";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(59, 131);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(40, 24);
            checkBox4.TabIndex = 24;
            checkBox4.Text = "B";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(115, 131);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(40, 24);
            checkBox5.TabIndex = 25;
            checkBox5.Text = "C";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(177, 131);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(42, 24);
            checkBox6.TabIndex = 26;
            checkBox6.Text = "D";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(numericUpDown2);
            groupBox5.Controls.Add(numericUpDown1);
            groupBox5.Controls.Add(label12);
            groupBox5.Controls.Add(label11);
            groupBox5.ForeColor = SystemColors.HotTrack;
            groupBox5.Location = new Point(295, 631);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(493, 91);
            groupBox5.TabIndex = 21;
            groupBox5.TabStop = false;
            groupBox5.Text = "Объем заработанной платы";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.ControlText;
            label11.Location = new Point(26, 48);
            label11.Name = "label11";
            label11.Size = new Size(26, 20);
            label11.TabIndex = 13;
            label11.Text = "От";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = SystemColors.ControlText;
            label12.Location = new Point(267, 52);
            label12.Name = "label12";
            label12.Size = new Size(28, 20);
            label12.TabIndex = 14;
            label12.Text = "До";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(58, 46);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 15;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(308, 47);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(150, 27);
            numericUpDown2.TabIndex = 16;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(radioButton10);
            groupBox6.Controls.Add(radioButton11);
            groupBox6.Controls.Add(radioButton7);
            groupBox6.Controls.Add(radioButton9);
            groupBox6.ForeColor = SystemColors.HotTrack;
            groupBox6.Location = new Point(295, 734);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(493, 91);
            groupBox6.TabIndex = 22;
            groupBox6.TabStop = false;
            groupBox6.Text = "Предпочитаемый график работы";
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.ForeColor = SystemColors.ControlText;
            radioButton7.Location = new Point(9, 59);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(138, 24);
            radioButton7.TabIndex = 8;
            radioButton7.TabStop = true;
            radioButton7.Text = "Работа на дому";
            radioButton7.UseVisualStyleBackColor = true;
            radioButton7.CheckedChanged += radioButton7_CheckedChanged;
            // 
            // radioButton9
            // 
            radioButton9.AutoSize = true;
            radioButton9.ForeColor = SystemColors.ControlText;
            radioButton9.Location = new Point(9, 31);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(155, 24);
            radioButton9.TabIndex = 7;
            radioButton9.TabStop = true;
            radioButton9.Text = "Полная занятость";
            radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            radioButton10.AutoSize = true;
            radioButton10.ForeColor = SystemColors.ControlText;
            radioButton10.Location = new Point(263, 59);
            radioButton10.Name = "radioButton10";
            radioButton10.Size = new Size(163, 24);
            radioButton10.TabIndex = 10;
            radioButton10.TabStop = true;
            radioButton10.Text = "Посменная работа";
            radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            radioButton11.AutoSize = true;
            radioButton11.ForeColor = SystemColors.ControlText;
            radioButton11.Location = new Point(263, 31);
            radioButton11.Name = "radioButton11";
            radioButton11.Size = new Size(175, 24);
            radioButton11.TabIndex = 9;
            radioButton11.TabStop = true;
            radioButton11.Text = "Частичная занятость";
            radioButton11.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = SystemColors.ControlText;
            label13.Location = new Point(25, 833);
            label13.Name = "label13";
            label13.Size = new Size(124, 20);
            label13.TabIndex = 27;
            label13.Text = "Краткое резюме";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(25, 856);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(757, 164);
            listBox1.TabIndex = 28;
            // 
            // button1
            // 
            button1.Location = new Point(361, 1026);
            button1.Name = "button1";
            button1.Size = new Size(157, 29);
            button1.TabIndex = 29;
            button1.Text = "Сохранить данные";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(528, 1026);
            button2.Name = "button2";
            button2.Size = new Size(147, 29);
            button2.TabIndex = 30;
            button2.Text = "Очистить форму";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(684, 1026);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 31;
            button3.Text = "Отмена";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 1066);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(label13);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(textBox5);
            Controls.Add(comboBox5);
            Controls.Add(label9);
            Controls.Add(textBox4);
            Controls.Add(label8);
            Controls.Add(comboBox4);
            Controls.Add(label7);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBox2;
        private Label label4;
        private ComboBox comboBox3;
        private Label label6;
        private ComboBox comboBox2;
        private Label label5;
        private ComboBox comboBox1;
        private GroupBox groupBox3;
        private Label label7;
        private RadioButton radioButton8;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private ComboBox comboBox4;
        private Label label8;
        private TextBox textBox4;
        private Label label9;
        private ComboBox comboBox5;
        private TextBox textBox5;
        private GroupBox groupBox4;
        private Label label10;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private GroupBox groupBox5;
        private Label label12;
        private Label label11;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private GroupBox groupBox6;
        private RadioButton radioButton7;
        private RadioButton radioButton9;
        private RadioButton radioButton10;
        private RadioButton radioButton11;
        private Label label13;
        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
