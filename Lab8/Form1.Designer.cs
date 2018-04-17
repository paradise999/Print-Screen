namespace Lab8
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.screenshot = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(68, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(729, 469);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // screenshot
            // 
            this.screenshot.Location = new System.Drawing.Point(887, 556);
            this.screenshot.Name = "screenshot";
            this.screenshot.Size = new System.Drawing.Size(155, 23);
            this.screenshot.TabIndex = 1;
            this.screenshot.Text = "Сделать снимок";
            this.screenshot.UseVisualStyleBackColor = true;
            this.screenshot.Click += new System.EventHandler(this.screenshot_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(887, 450);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(155, 23);
            this.save.TabIndex = 2;
            this.save.Text = "Сохранить снимок";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 605);
            this.Controls.Add(this.save);
            this.Controls.Add(this.screenshot);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Скриншот";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button screenshot;
        private System.Windows.Forms.Button save;
    }
}

