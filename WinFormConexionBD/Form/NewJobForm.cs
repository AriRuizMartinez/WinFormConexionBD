﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormConexionBD
{
    public partial class NewJobForm : Form
    {
        private Job job;
        public Job JobProperty { get { return job; } }
        public NewJobForm()
        {
            InitializeComponent();
        }

        public NewJobForm(Job job)
        {
            InitializeComponent();
            this.job = job;
            textBox1.Text = job.JobTitle;
            MinSalatyTextBox.Text = job.MinSalary + "";
            MaxSalaryTextBox.Text = job.MaxSalary + "";
            AddBtn.Text = "Update";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool valido = Validar();
            if (!valido)
                return;

            if(job != null)
                job = new Job(job.Id, textBox1.Text, GetDecimalValue(MinSalatyTextBox.Text), GetDecimalValue(MaxSalaryTextBox.Text));
            else                
                job = new Job(textBox1.Text, GetDecimalValue(MinSalatyTextBox.Text), GetDecimalValue(MaxSalaryTextBox.Text));

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private decimal? GetDecimalValue(string text)
        {
            if(!decimal.TryParse(text, out decimal result))
                return null;

            return result;
        }

        private bool Validar()
        {
            bool titleisNull = false;
            string message = "";

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                titleisNull = true;
                message += "No has rellenado el campo obligatorio de Title \n";
            }

            if (titleisNull)
                MessageBox.Show(message);

            return !titleisNull;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}