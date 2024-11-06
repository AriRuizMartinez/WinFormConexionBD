using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormConexionBD
{
    public partial class Form1 : Form
    {
        ConexionBD conexionBD;
        NewJobForm newJobForm;
        DAL_Job DAL_Job;
        public Form1()
        {
            InitializeComponent();
            conexionBD = new ConexionBD();
            DAL_Job = new DAL_Job();
            OpenBtn.Enabled = true;
            CloseBtn.Enabled = false;
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            if (conexionBD.Open())
            {
                label1.Text = "Opened";
                OpenBtn.Enabled = false;
                CloseBtn.Enabled = true;
            }
            else
                MessageBox.Show("Ha habido un problema.");
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            if (conexionBD.Close())
            {
                label1.Text = "Closed";
                OpenBtn.Enabled = true;
                CloseBtn.Enabled = false;
            }
            else
                MessageBox.Show("Ha habido un problema.");
        }

        private void NewJobBtn_Click(object sender, EventArgs e)
        {
            newJobForm = new NewJobForm();
            if (newJobForm.ShowDialog() == DialogResult.OK)
                DAL_Job.InsertJob(newJobForm.JobProperty);
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            UpdateComboBox();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            newJobForm = new NewJobForm((Job)comboBox1.SelectedItem);
            if (newJobForm.ShowDialog() == DialogResult.OK)
            {
                DAL_Job.UpdateJob(newJobForm.JobProperty);
                UpdateComboBox();
            }


        }
        private void UpdateComboBox()
        {
            List<Job> jobs = DAL_Job.SelectJobs();
            comboBox1.DataSource = jobs;
        }
    }
}
