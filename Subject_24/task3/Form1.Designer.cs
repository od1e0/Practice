namespace task3
{
	partial class Form1
	{
        private task3.CircularButton circularButton1;
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
			this.circularButton1 = new task3.CircularButton();
			this.SuspendLayout();
			// 
			// circularButton1
			// 
			this.circularButton1.Location = new System.Drawing.Point(50, 50);
			this.circularButton1.Name = "circularButton1";
			this.circularButton1.Size = new System.Drawing.Size(100, 100);
			this.circularButton1.TabIndex = 0;
			this.circularButton1.Text = "Click Me";
			this.circularButton1.Click += new System.EventHandler(this.CircularButton1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.circularButton1);
            this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
		}

		#endregion
	}
}

