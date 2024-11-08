﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormConexionBD.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormConexionBD
{
    public partial class NewEmployeeForm : Form
    {
        private Employee employee;
        public Employee EmployeeProperty { get { return employee; } }
        public NewEmployeeForm(List<jobs> jobs, List<Employee> employees, List<Department> departments)
        {
            InitializeComponent();
            comboBox1.DataSource = jobs;
            comboBoxManager.DataSource = employees;
            comboBoxDepartment.DataSource = departments;
        }

        public NewEmployeeForm(List<jobs> jobs, List<Employee> employees, List<Department> departments, Employee employee)
        {
            InitializeComponent();
            comboBox1.DataSource = jobs;
            comboBoxManager.DataSource = employees;
            comboBoxDepartment.DataSource = departments;
            textBoxFirstName.Text = employee.First_name;
            textBoxLastName.Text = employee.Last_name;
            textBoxEmail.Text = employee.Email;
            textBoxPhoneNumber.Text = employee.Phone_number;
            dateTimePicker1.Value = employee.Hire_date;
            comboBox1.SelectedItem = employee.JobProperty;
            UpdateMinimumMaximum(employee.JobProperty);
            numericUpDown1.Value = employee.Salary;
            AddBtn.Text = "Update";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateMinimumMaximum(((Job)comboBox1.SelectedItem));
        }

        private void UpdateMinimumMaximum(Job job)
        {
            numericUpDown1.Minimum = job.MinSalary ?? 0;
            numericUpDown1.Maximum = job.MaxSalary ?? decimal.MaxValue;
        }

        private bool Validar()
        {
            bool LastNameisNull = false, emailIsNull = false, jobIsNull = false;
            string message = "";

            if (string.IsNullOrWhiteSpace(textBoxLastName.Text))
            {
                LastNameisNull = true;
                message += "No has rellenado el campo obligatorio de Last name \n";
            }

            if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                emailIsNull = true;
                message += "No has rellenado el campo obligatorio de Email \n";
            }

            if(comboBox1.SelectedItem == null)
            {
                jobIsNull = true;
                message += "No has rellenado el campo obligatorio de Job \n";
            }

            if (LastNameisNull || emailIsNull || jobIsNull)
                MessageBox.Show(message);

            return !LastNameisNull && !emailIsNull && !jobIsNull;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            bool valido = Validar();
            if (!valido)
                return;

            if (employee != null)
                employee = new Employee(
                    employee.Id, 
                    string.IsNullOrWhiteSpace(textBoxFirstName.Text) ? null : textBoxFirstName.Text, 
                    textBoxLastName.Text, 
                    textBoxEmail.Text, 
                    string.IsNullOrWhiteSpace(textBoxPhoneNumber.Text) ? null : textBoxPhoneNumber.Text, 
                    dateTimePicker1.Value, 
                    ((Job) comboBox1.SelectedItem).Id, 
                    numericUpDown1.Value, 
                    ((Employee) comboBoxManager.SelectedItem)?.Id, 
                    ((Department)comboBoxDepartment.SelectedItem)?.Id);
            else
                employee = new Employee(
                    string.IsNullOrWhiteSpace(textBoxFirstName.Text) ? null : textBoxFirstName.Text, 
                    textBoxLastName.Text, 
                    textBoxEmail.Text, 
                    string.IsNullOrWhiteSpace(textBoxPhoneNumber.Text) ? null : textBoxPhoneNumber.Text, 
                    dateTimePicker1.Value,
                    ((Job)comboBox1.SelectedItem).Id, 
                    numericUpDown1.Value, 
                    ((Employee)comboBoxManager.SelectedItem)?.Id, 
                    ((Department)comboBoxDepartment.SelectedItem)?.Id);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
