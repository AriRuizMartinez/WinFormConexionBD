using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormConexionBD.DAL;
using WinFormConexionBD.Model;

namespace WinFormConexionBD
{
    public partial class Form1 : Form
    {
        NewJobForm newJobForm;
        NewEmployeeForm newEmployeeForm;
        DAL_Job dal_job;
        DAL_Employee dal_employee;
        DAL_Department dal_department;
        public Form1()
        {
            InitializeComponent();
            dal_job = new DAL_Job();
            dal_employee = new DAL_Employee();
            dal_department = new DAL_Department();
        }

        private void NewJobBtn_Click(object sender, EventArgs e)
        {
            newJobForm = new NewJobForm();
            if (newJobForm.ShowDialog() == DialogResult.OK)
            {
                dal_job.InsertJob(newJobForm.JobProperty);
                UpdateComboBox();
            }
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
                dal_job.UpdateJob(newJobForm.JobProperty);
                UpdateComboBox();
            }


        }
        private void UpdateComboBox()
        {
            List<Job> jobs = dal_job.SelectJobs();
            comboBox1.DataSource = jobs;
        }

        private void UpdateComboBoxEmployees()
        {
            List<Employee> employees = dal_employee.SelectEmployees();
            comboBoxEmployees.DataSource = employees;
        }

        private void NewEmployeeBtn_Click(object sender, EventArgs e)
        {
            newEmployeeForm = new NewEmployeeForm(dal_job.SelectJobs(), dal_employee.SelectEmployees(), new List<Department>());
            if (newEmployeeForm.ShowDialog() == DialogResult.OK)
            {
                dal_employee.InsertEmployee(newEmployeeForm.EmployeeProperty);
                UpdateComboBoxEmployees();
            }
        }

        private void SelectEmployeeBtn_Click(object sender, EventArgs e)
        {
            UpdateComboBoxEmployees();
        }
    }
}
