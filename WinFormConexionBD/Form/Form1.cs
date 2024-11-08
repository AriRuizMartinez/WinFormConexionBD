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
            UpdateBtn.Enabled = false;
            UpdateEmployeeBtn.Enabled = false;
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

        private void UpdateEmployeeBtn_Click(object sender, EventArgs e)
        {
            newEmployeeForm = new NewEmployeeForm(dal_job.SelectJobs(), dal_employee.SelectEmployees(), new List<Department>(), (Employee) comboBoxEmployees.SelectedItem);
            if (newEmployeeForm.ShowDialog() == DialogResult.OK)
            {
                dal_employee.UpdateEmployee(newEmployeeForm.EmployeeProperty);
                UpdateComboBoxEmployees();
            }
        }

        private void comboBoxEmployees_TextChanged(object sender, EventArgs e)
        {
            if(comboBoxEmployees.SelectedItem == null || comboBoxEmployees.SelectedItem.ToString() != comboBoxEmployees.Text)
                UpdateEmployeeBtn.Enabled = false;
            else
                UpdateEmployeeBtn.Enabled = true;
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem == null || comboBox1.SelectedItem.ToString() != comboBox1.Text)
                UpdateBtn.Enabled = false;
            else
                UpdateBtn.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var data = from emp in dc.employees
                       where emp.first_name.Contains("S")
                       select emp;

            employees theOne = data.FirstOrDefault();
            //employees theOne = data.SingleOrDefault();
            button1.Text = theOne.ToString();

            comboBoxEmployees.DataSource = data;

            theOne.first_name = "*" + theOne.first_name;
            dc.SubmitChanges();
        }
    }
}
