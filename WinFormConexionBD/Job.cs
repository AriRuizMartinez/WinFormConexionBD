using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormConexionBD
{
    public class Job
    {
        private int id;
        public int Id { get { return id; } set { id = value; } }
        private string job_title;
        public string JobTitle { get { return job_title; } set { job_title = value; } }
        private decimal? min_salary;
        public decimal? MinSalary { get { return min_salary; } set { min_salary = value; } }
        private decimal? max_salary;
        public decimal? MaxSalary {  get { return max_salary; } set { max_salary = value; } }

        public Job(string jobTitle, decimal? min_salary, decimal? max_salary)
        {
            this.job_title = jobTitle;
            this.max_salary = max_salary;
            this.min_salary = min_salary;
        }

        public Job(int id, string jobTitle, decimal? min_salary, decimal? max_salary)
        {
            this.id = id;
            this.job_title = jobTitle;
            this.max_salary = max_salary;
            this.min_salary = min_salary;
        }

        public override string ToString()
        {
            return job_title;
        }

        

    }
}
