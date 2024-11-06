namespace WinFormConexionBD
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.NewJobBtn = new System.Windows.Forms.Button();
            this.SelectJobBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.UpdateEmployeeBtn = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SelectEmployeeBtn = new System.Windows.Forms.Button();
            this.NewEmployeeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewJobBtn
            // 
            this.NewJobBtn.Location = new System.Drawing.Point(25, 27);
            this.NewJobBtn.Name = "NewJobBtn";
            this.NewJobBtn.Size = new System.Drawing.Size(193, 23);
            this.NewJobBtn.TabIndex = 4;
            this.NewJobBtn.Text = "New Job";
            this.NewJobBtn.UseVisualStyleBackColor = true;
            this.NewJobBtn.Click += new System.EventHandler(this.NewJobBtn_Click);
            // 
            // SelectJobBtn
            // 
            this.SelectJobBtn.Location = new System.Drawing.Point(25, 56);
            this.SelectJobBtn.Name = "SelectJobBtn";
            this.SelectJobBtn.Size = new System.Drawing.Size(193, 23);
            this.SelectJobBtn.TabIndex = 5;
            this.SelectJobBtn.Text = "Select jobs";
            this.SelectJobBtn.UseVisualStyleBackColor = true;
            this.SelectJobBtn.Click += new System.EventHandler(this.SelectBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 96);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(25, 138);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(193, 23);
            this.UpdateBtn.TabIndex = 7;
            this.UpdateBtn.Text = "Update job";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // UpdateEmployeeBtn
            // 
            this.UpdateEmployeeBtn.Location = new System.Drawing.Point(282, 138);
            this.UpdateEmployeeBtn.Name = "UpdateEmployeeBtn";
            this.UpdateEmployeeBtn.Size = new System.Drawing.Size(193, 23);
            this.UpdateEmployeeBtn.TabIndex = 11;
            this.UpdateEmployeeBtn.Text = "Update employee";
            this.UpdateEmployeeBtn.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(282, 96);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(193, 24);
            this.comboBox2.TabIndex = 10;
            // 
            // SelectEmployeeBtn
            // 
            this.SelectEmployeeBtn.Location = new System.Drawing.Point(282, 56);
            this.SelectEmployeeBtn.Name = "SelectEmployeeBtn";
            this.SelectEmployeeBtn.Size = new System.Drawing.Size(193, 23);
            this.SelectEmployeeBtn.TabIndex = 9;
            this.SelectEmployeeBtn.Text = "Select employees";
            this.SelectEmployeeBtn.UseVisualStyleBackColor = true;
            // 
            // NewEmployeeBtn
            // 
            this.NewEmployeeBtn.Location = new System.Drawing.Point(282, 27);
            this.NewEmployeeBtn.Name = "NewEmployeeBtn";
            this.NewEmployeeBtn.Size = new System.Drawing.Size(193, 23);
            this.NewEmployeeBtn.TabIndex = 8;
            this.NewEmployeeBtn.Text = "New Employee";
            this.NewEmployeeBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 189);
            this.Controls.Add(this.UpdateEmployeeBtn);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.SelectEmployeeBtn);
            this.Controls.Add(this.NewEmployeeBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.SelectJobBtn);
            this.Controls.Add(this.NewJobBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button NewJobBtn;
        private System.Windows.Forms.Button SelectJobBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button UpdateEmployeeBtn;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button SelectEmployeeBtn;
        private System.Windows.Forms.Button NewEmployeeBtn;
    }
}

