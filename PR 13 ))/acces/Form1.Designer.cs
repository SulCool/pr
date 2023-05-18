namespace acces
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
            this.idi = new System.Windows.Forms.Label();
            this.neme = new System.Windows.Forms.Label();
            this.nini = new System.Windows.Forms.Label();
            this.INSERT = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.dta1 = new System.Windows.Forms.DataGridView();
            this.IDDD = new System.Windows.Forms.TextBox();
            this.nnm = new System.Windows.Forms.TextBox();
            this.newnnm = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dta1)).BeginInit();
            this.SuspendLayout();
            // 
            // idi
            // 
            this.idi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idi.AutoSize = true;
            this.idi.Location = new System.Drawing.Point(50, 38);
            this.idi.Name = "idi";
            this.idi.Size = new System.Drawing.Size(18, 13);
            this.idi.TabIndex = 0;
            this.idi.Text = "ID";
            // 
            // neme
            // 
            this.neme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.neme.AutoSize = true;
            this.neme.Location = new System.Drawing.Point(50, 61);
            this.neme.Name = "neme";
            this.neme.Size = new System.Drawing.Size(35, 13);
            this.neme.TabIndex = 0;
            this.neme.Text = "Name";
            // 
            // nini
            // 
            this.nini.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nini.AutoSize = true;
            this.nini.Location = new System.Drawing.Point(50, 85);
            this.nini.Name = "nini";
            this.nini.Size = new System.Drawing.Size(55, 13);
            this.nini.TabIndex = 0;
            this.nini.Text = "Newname";
            // 
            // INSERT
            // 
            this.INSERT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.INSERT.Location = new System.Drawing.Point(327, 51);
            this.INSERT.Name = "INSERT";
            this.INSERT.Size = new System.Drawing.Size(75, 23);
            this.INSERT.TabIndex = 2;
            this.INSERT.Text = "INSERT";
            this.INSERT.UseVisualStyleBackColor = true;
            this.INSERT.Click += new System.EventHandler(this.INSERT_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(441, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // del
            // 
            this.del.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.del.Location = new System.Drawing.Point(552, 51);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(75, 23);
            this.del.TabIndex = 2;
            this.del.Text = "DELETE";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // dta1
            // 
            this.dta1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dta1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dta1.Location = new System.Drawing.Point(12, 121);
            this.dta1.Name = "dta1";
            this.dta1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dta1.Size = new System.Drawing.Size(783, 317);
            this.dta1.TabIndex = 3;
            this.dta1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dta1_CellEnter);
            // 
            // IDDD
            // 
            this.IDDD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IDDD.Location = new System.Drawing.Point(111, 35);
            this.IDDD.Name = "IDDD";
            this.IDDD.Size = new System.Drawing.Size(154, 20);
            this.IDDD.TabIndex = 4;
            // 
            // nnm
            // 
            this.nnm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nnm.Location = new System.Drawing.Point(111, 58);
            this.nnm.Name = "nnm";
            this.nnm.Size = new System.Drawing.Size(154, 20);
            this.nnm.TabIndex = 5;
            // 
            // newnnm
            // 
            this.newnnm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newnnm.Location = new System.Drawing.Point(111, 82);
            this.newnnm.Name = "newnnm";
            this.newnnm.Size = new System.Drawing.Size(154, 20);
            this.newnnm.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newnnm);
            this.Controls.Add(this.nnm);
            this.Controls.Add(this.IDDD);
            this.Controls.Add(this.dta1);
            this.Controls.Add(this.del);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.INSERT);
            this.Controls.Add(this.nini);
            this.Controls.Add(this.neme);
            this.Controls.Add(this.idi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dta1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idi;
        private System.Windows.Forms.Label neme;
        private System.Windows.Forms.Label nini;
        private System.Windows.Forms.Button INSERT;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.DataGridView dta1;
        private System.Windows.Forms.TextBox IDDD;
        private System.Windows.Forms.TextBox nnm;
        private System.Windows.Forms.TextBox newnnm;
    }
}

