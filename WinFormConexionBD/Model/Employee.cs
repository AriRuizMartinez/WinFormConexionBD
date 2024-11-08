using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormConexionBD.DAL;

namespace WinFormConexionBD.Model
{
    public class Employee
    {
        private int id;
        public int Id { get { return id; } set { id = value; } }

        private string first_name;
        public string First_name { get {  return first_name; } }

        private string last_name;
        public string Last_name { get { return last_name; } }

        private string email;
        public string Email { get { return email; } }

        private string phone_number;
        public string Phone_number { get { return phone_number; } }
        
        private DateTime hire_date;
        public DateTime Hire_date {  get { return hire_date; } }

        private int jobId;
        public int JobId { get { return jobId; } }
        
        private Job job;
        public Job JobProperty 
        { 
            get 
            { 
                if(job == null)
                    job = DAL_Job.XSelectJobById(jobId);
                return job; 
            }
        }

        private decimal salary;
        public decimal Salary { get { return salary; } }

        private int? managerId;
        public int? ManagerId { get { return managerId; } }

        private Employee manager;
        public Employee Manager
        {
            get
            {
                if (managerId == null)
                    return null;
                if (manager == null)
                    manager = DAL_Employee.XSelectEmployeeById( (int) managerId );
                return manager;
            }
        }

        private int? departmentId;
        public int? DepartmentId { get { return departmentId; } }

        private Department department;
        public Department DepartmentProperty
        {
            get
            {
                if (departmentId == null)
                    return null;
                if (department == null)
                    department = DAL_Department.XSelectDepartmentById( (int) departmentId );
                return department;
            }
        }

        public Employee(int id, string first_name, string last_name, string email, string phone_number, DateTime hire_date, int jobId, decimal salary, int? managerId, int? departmentId)
        {
            this.id = id;
            this.first_name = first_name;
            this.last_name = last_name;
            this.email = email;
            this.phone_number = phone_number;
            this.hire_date = hire_date;
            this.jobId = jobId;
            this.salary = salary;
            this.departmentId = departmentId;
            this.managerId = managerId;
        }

        public Employee(string first_name, string last_name, string email, string phone_number, DateTime hire_date, int jobId, decimal salary, int? managerId, int? departmentId)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.email = email;
            this.phone_number = phone_number;
            this.hire_date = hire_date;
            this.jobId = jobId;
            this.salary = salary;
            this.managerId = managerId;
            this.departmentId = departmentId;
        }

        public override string ToString()
        {
            return first_name + " " + last_name;
        }
    }
}
