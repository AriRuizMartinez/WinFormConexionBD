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
            this.comboBoxEmployees = new System.Windows.Forms.ComboBox();
            this.SelectEmployeeBtn = new System.Windows.Forms.Button();
            this.NewEmployeeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewJobBtn
            // 
            this.NewJobBtn.Location = new System.Drawing.Point(25, 27);
            this.NewJobBtn.Name = "NewJobBtn";
            this.NewJobBtn.Size = new System.Drawing.Size(193, 32);
            this.NewJobBtn.TabIndex = 4;
            this.NewJobBtn.Text = "New Job";
            this.NewJobBtn.UseVisualStyleBackColor = true;
            this.NewJobBtn.Click += new System.EventHandler(this.NewJobBtn_Click);
            // 
            // SelectJobBtn
            // 
            this.SelectJobBtn.Location = new System.Drawing.Point(25, 77);
            this.SelectJobBtn.Name = "SelectJobBtn";
            this.SelectJobBtn.Size = new System.Drawing.Size(193, 33);
            this.SelectJobBtn.TabIndex = 5;
            this.SelectJobBtn.Text = "Select jobs";
            this.SelectJobBtn.UseVisualStyleBackColor = true;
            this.SelectJobBtn.Click += new System.EventHandler(this.SelectBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 127);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 24);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(25, 166);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(193, 35);
            this.UpdateBtn.TabIndex = 7;
            this.UpdateBtn.Text = "Update job";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // UpdateEmployeeBtn
            // 
            this.UpdateEmployeeBtn.Location = new System.Drawing.Point(282, 166);
            this.UpdateEmployeeBtn.Name = "UpdateEmployeeBtn";
            this.UpdateEmployeeBtn.Size = new System.Drawing.Size(193, 35);
            this.UpdateEmployeeBtn.TabIndex = 11;
            this.UpdateEmployeeBtn.Text = "Update employee";
            this.UpdateEmployeeBtn.UseVisualStyleBackColor = true;
            this.UpdateEmployeeBtn.Click += new System.EventHandler(this.UpdateEmployeeBtn_Click);
            // 
            // comboBoxEmployees
            // 
            this.comboBoxEmployees.FormattingEnabled = true;
            this.comboBoxEmployees.Location = new System.Drawing.Point(282, 127);
            this.comboBoxEmployees.Name = "comboBoxEmployees";
            this.comboBoxEmployees.Size = new System.Drawing.Size(193, 24);
            this.comboBoxEmployees.TabIndex = 10;
            this.comboBoxEmployees.TextChanged += new System.EventHandler(this.comboBoxEmployees_TextChanged);
            // 
            // SelectEmployeeBtn
            // 
            this.SelectEmployeeBtn.Location = new System.Drawing.Point(282, 77);
            this.SelectEmployeeBtn.Name = "SelectEmployeeBtn";
            this.SelectEmployeeBtn.Size = new System.Drawing.Size(193, 33);
            this.SelectEmployeeBtn.TabIndex = 9;
            this.SelectEmployeeBtn.Text = "Select employees";
            this.SelectEmployeeBtn.UseVisualStyleBackColor = true;
            this.SelectEmployeeBtn.Click += new System.EventHandler(this.SelectEmployeeBtn_Click);
            // 
            // NewEmployeeBtn
            // 
            this.NewEmployeeBtn.Location = new System.Drawing.Point(282, 27);
            this.NewEmployeeBtn.Name = "NewEmployeeBtn";
            this.NewEmployeeBtn.Size = new System.Drawing.Size(193, 32);
            this.NewEmployeeBtn.TabIndex = 8;
            this.NewEmployeeBtn.Text = "New Employee";
            this.NewEmployeeBtn.UseVisualStyleBackColor = true;
            this.NewEmployeeBtn.Click += new System.EventHandler(this.NewEmployeeBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 221);
            this.Controls.Add(this.UpdateEmployeeBtn);
            this.Controls.Add(this.comboBoxEmployees);
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
        private System.Windows.Forms.ComboBox comboBoxEmployees;
        private System.Windows.Forms.Button SelectEmployeeBtn;
        private System.Windows.Forms.Button NewEmployeeBtn;
    }
}

