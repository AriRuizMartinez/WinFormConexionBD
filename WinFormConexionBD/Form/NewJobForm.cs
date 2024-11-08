using System;
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
        private jobs job;
        public jobs JobProperty { get { return job; } }
        public NewJobForm()
        {
            InitializeComponent();
        }

        public NewJobForm(jobs job)
        {
            InitializeComponent();
            this.job = job;
            textBox1.Text = job.job_title;
            MinSalatyTextBox.Text = job.min_salary + "";
            MaxSalaryTextBox.Text = job.max_salary + "";
            AddBtn.Text = "Update";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool valido = Validar();
            if (!valido)
                return;

            if(job != null)
            {
                job.job_title = textBox1.Text;
                job.min_salary = GetDecimalValue(MinSalatyTextBox.Text);
                job.max_salary = GetDecimalValue(MaxSalaryTextBox.Text);
            }
            else
            {
                job = new jobs();
                job.job_title = textBox1.Text;
                job.min_salary = GetDecimalValue(MinSalatyTextBox.Text);
                job.max_salary = GetDecimalValue(MaxSalaryTextBox.Text);
            }        

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
