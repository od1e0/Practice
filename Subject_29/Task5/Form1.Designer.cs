namespace Task5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonLaunch = new System.Windows.Forms.Button();
            this.pictureBoxRocket = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRocket)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLaunch
            // 
            this.buttonLaunch.Location = new System.Drawing.Point(318, 369);
            this.buttonLaunch.Name = "buttonLaunch";
            this.buttonLaunch.Size = new System.Drawing.Size(138, 69);
            this.buttonLaunch.TabIndex = 0;
            this.buttonLaunch.Text = "button1";
            this.buttonLaunch.UseVisualStyleBackColor = true;
            // 
            // pictureBoxRocket
            // 
            this.pictureBoxRocket.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRocket.Image")));
            this.pictureBoxRocket.Location = new System.Drawing.Point(488, 277);
            this.pictureBoxRocket.Name = "pictureBoxRocket";
            this.pictureBoxRocket.Size = new System.Drawing.Size(147, 161);
            this.pictureBoxRocket.TabIndex = 1;
            this.pictureBoxRocket.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxRocket);
            this.Controls.Add(this.buttonLaunch);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRocket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLaunch;
        private System.Windows.Forms.PictureBox pictureBoxRocket;
    }
}

