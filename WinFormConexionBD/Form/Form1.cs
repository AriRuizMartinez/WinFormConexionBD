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
        NewJobForm newJobForm;
        DAL_Job DAL_Job;
        public Form1()
        {
            InitializeComponent();
            DAL_Job = new DAL_Job();
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
