namespace WinFormConexionBD
{
    partial class NewJobForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelJobTitle = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.MinSalatyTextBox = new System.Windows.Forms.TextBox();
            this.MaxSalaryTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelJobTitle
            // 
            this.LabelJobTitle.AutoSize = true;
            this.LabelJobTitle.Location = new System.Drawing.Point(13, 13);
            this.LabelJobTitle.Name = "LabelJobTitle";
            this.LabelJobTitle.Size = new System.Drawing.Size(36, 16);
            this.LabelJobTitle.TabIndex = 0;
            this.LabelJobTitle.Text = "Title:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Minimum salary:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Maximum salary:";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(19, 209);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(100, 23);
            this.AddBtn.TabIndex = 6;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(19, 248);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(100, 23);
            this.CancelBtn.TabIndex = 7;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // MinSalatyTextBox
            // 
            this.MinSalatyTextBox.Location = new System.Drawing.Point(19, 97);
            this.MinSalatyTextBox.Name = "MinSalatyTextBox";
            this.MinSalatyTextBox.Size = new System.Drawing.Size(100, 22);
            this.MinSalatyTextBox.TabIndex = 8;
            // 
            // MaxSalaryTextBox
            // 
            this.MaxSalaryTextBox.Location = new System.Drawing.Point(19, 164);
            this.MaxSalaryTextBox.Name = "MaxSalaryTextBox";
            this.MaxSalaryTextBox.Size = new System.Drawing.Size(100, 22);
            this.MaxSalaryTextBox.TabIndex = 9;
            // 
            // NewJobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(148, 330);
            this.Controls.Add(this.MaxSalaryTextBox);
            this.Controls.Add(this.MinSalatyTextBox);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LabelJobTitle);
            this.Name = "NewJobForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelJobTitle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.TextBox MinSalatyTextBox;
        private System.Windows.Forms.TextBox MaxSalaryTextBox;
    }
}