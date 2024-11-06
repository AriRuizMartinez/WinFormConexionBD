using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormConexionBD.Model
{
    public class Employee
    {
        private int id;
        public int Id { get { return id; } set { id = value} }

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
        
        private Job job;
        public Job JobProperty { get { return job; } }

        private decimal salary;
        public decimal Salary { get { return salary; } }

        public Employee(int id, string first_name, string last_name, string email, string phone_number, DateTime hire_date, Job job, decimal salary)
        {
            this.id = id;
            this.first_name = first_name;
            this.last_name = last_name;
            this.email = email;
            this.phone_number = phone_number;
            this.hire_date = hire_date;
            this.job = job;
            this.salary = salary;
        }

        public Employee(string first_name, string last_name, string email, string phone_number, DateTime hire_date, Job job, decimal salary)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.email = email;
            this.phone_number = phone_number;
            this.hire_date = hire_date;
            this.job = job;
            this.salary = salary;
        }

        public override string ToString()
        {
            return first_name + " " + last_name;
        }
    }
}
