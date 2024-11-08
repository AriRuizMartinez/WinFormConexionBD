using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormConexionBD.DAL
{
    public class DAL_JobLinQ
    {
        public void InsertJob(jobs job)
        {
            try
            {
                DataClasses1DataContext dc = new DataClasses1DataContext();

                jobs newOne = new jobs();

                newOne.job_title = job.job_title;
                newOne.min_salary = job.min_salary;
                newOne.max_salary = job.max_salary;

                dc.jobs.InsertOnSubmit(newOne);

                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public static object NullToDBNull(object val)
        {
            if (val == null)
                return DBNull.Value;
            else
                return val;
        }

        public List<jobs> SelectJobs()
        {
            try
            {
                DataClasses1DataContext dc = new DataClasses1DataContext();
                var data = from job in dc.jobs
                           select job;
                return data.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                return null;
            }
        }

        public static jobs XSelectJobById(int id)
        {
            DAL_JobLinQ dalJob = new DAL_JobLinQ();
            return dalJob.SelectJobById(id);
        }

        public jobs SelectJobById(int id)
        {
            try
            {
                DataClasses1DataContext dc = new DataClasses1DataContext();
                var data = from job in dc.jobs
                           where job.job_id == id
                           select job;
                return data.SingleOrDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                return null;
            }
        }

        public void UpdateJob(jobs job)
        {
            try
            {
                DataClasses1DataContext dc = new DataClasses1DataContext();
                var data = from j in dc.jobs
                           where j.job_id == job.job_id
                           select j;
                jobs theOne = data.SingleOrDefault();

                theOne.job_title = job.job_title;
                theOne.max_salary = job.max_salary;
                theOne.min_salary = job.min_salary;

                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
    }
}
