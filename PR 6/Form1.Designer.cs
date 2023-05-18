namespace PR_6
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
            this.ToolStripButtonLoadPicture = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ToolStripButtonLoadPicture
            // 
            this.ToolStripButtonLoadPicture.Location = new System.Drawing.Point(40, 406);
            this.ToolStripButtonLoadPicture.Name = "ToolStripButtonLoadPicture";
            this.ToolStripButtonLoadPicture.Size = new System.Drawing.Size(56, 27);
            this.ToolStripButtonLoadPicture.TabIndex = 0;
            this.ToolStripButtonLoadPicture.Text = "Load";
            this.ToolStripButtonLoadPicture.UseVisualStyleBackColor = true;
            this.ToolStripButtonLoadPicture.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(102, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 27);
            this.button2.TabIndex = 3;
            this.button2.Text = "Mix";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(175, 406);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(88, 27);
            this.button6.TabIndex = 7;
            this.button6.Text = "CorrectSize";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 445);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ToolStripButtonLoadPicture);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ToolStripButtonLoadPicture;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
    }
}

