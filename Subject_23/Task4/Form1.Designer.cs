namespace Task4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.addButton = new System.Windows.Forms.Button();
            this.controlTypeTextBox = new System.Windows.Forms.TextBox();
            this.xCoordTextBox = new System.Windows.Forms.TextBox();
            this.yCoordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(34, 192);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(152, 32);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Добавить элемент";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // controlTypeTextBox
            // 
            this.controlTypeTextBox.Location = new System.Drawing.Point(34, 41);
            this.controlTypeTextBox.Name = "controlTypeTextBox";
            this.controlTypeTextBox.Size = new System.Drawing.Size(152, 22);
            this.controlTypeTextBox.TabIndex = 1;
            this.controlTypeTextBox.Text = "Введите тип (К, П, М)";
            // 
            // xCoordTextBox
            // 
            this.xCoordTextBox.Location = new System.Drawing.Point(34, 93);
            this.xCoordTextBox.Name = "xCoordTextBox";
            this.xCoordTextBox.Size = new System.Drawing.Size(152, 22);
            this.xCoordTextBox.TabIndex = 2;
            this.xCoordTextBox.Text = "X координата";
            // 
            // yCoordTextBox
            // 
            this.yCoordTextBox.Location = new System.Drawing.Point(34, 148);
            this.yCoordTextBox.Name = "yCoordTextBox";
            this.yCoordTextBox.Size = new System.Drawing.Size(152, 22);
            this.yCoordTextBox.TabIndex = 3;
            this.yCoordTextBox.Text = "Y координата";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.yCoordTextBox);
            this.Controls.Add(this.xCoordTextBox);
            this.Controls.Add(this.controlTypeTextBox);
            this.Controls.Add(this.addButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox controlTypeTextBox;
        private System.Windows.Forms.TextBox xCoordTextBox;
        private System.Windows.Forms.TextBox yCoordTextBox;
    }
}

