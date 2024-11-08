﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormConexionBD
{
    public class DAL_Job
    {
        ConexionBD conexionBD;

        public DAL_Job()
        {
            this.conexionBD = new ConexionBD();
        }

        public void InsertJob(Job job)
        {
            try
            {
                if (!conexionBD.Open())
                    return;

                string query = "INSERT INTO jobs(job_title, min_salary, max_salary) " +
                    "VALUES (@title, @min, @max);" +
                    "SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, conexionBD.Conexion))
                {
                    command.Parameters.AddWithValue("@title", job.JobTitle);
                    command.Parameters.AddWithValue("@min", NullToDBNull(job.MinSalary));
                    command.Parameters.AddWithValue("@max", NullToDBNull(job.MaxSalary));

                    decimal result = (decimal)command.ExecuteScalar();
                    job.Id = Convert.ToInt32(result);
                    MessageBox.Show("El id es " + job.Id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        public static object NullToDBNull(object val)
        {
            if (val == null)
                return DBNull.Value;
            else
                return val;
        }

        public List<Job> SelectJobs()
        {
            try
            {
                if (!conexionBD.Open())
                    return null;

                List<Job> jobs = new List<Job>();

                string query = "SELECT * FROM jobs;";
                SqlCommand command = new SqlCommand(query, conexionBD.Conexion);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int jobId = reader.GetInt32(0);
                    string jobTitle = reader.GetString(1);
                    decimal? min = reader.IsDBNull(2) ? (decimal?)null : reader.GetDecimal(2);
                    decimal? max = reader.IsDBNull(3) ? (decimal?)null : reader.GetDecimal(3);

                    Job job = new Job(jobId, jobTitle, min, max);
                    jobs.Add(job);
                }
                reader.Close();

                return jobs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                return null;
            }
            finally
            {
                conexionBD.Close();
            }

        }

        public static Job XSelectJobById(int id)
        {
            DAL_Job dalJob = new DAL_Job();
            return dalJob.SelectJobById(id);
        }

        public Job SelectJobById(int id)
        {
            try
            {
                if (!conexionBD.Open())
                    return null;

                string query = "SELECT * FROM jobs WHERE job_id = " + id + ";";
                SqlCommand command = new SqlCommand(query, conexionBD.Conexion);

                SqlDataReader reader = command.ExecuteReader();

                Job job = null;

                while (reader.Read())
                {
                    int jobId = reader.GetInt32(0);
                    string jobTitle = reader.GetString(1);
                    decimal? min = reader.IsDBNull(2) ? (decimal?)null : reader.GetDecimal(2);
                    decimal? max = reader.IsDBNull(3) ? (decimal?)null : reader.GetDecimal(3);

                    job = new Job(jobId, jobTitle, min, max);
                }
                reader.Close();
                return job;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                return null;
            }
            finally
            {
                conexionBD.Close();
            }
        }

        public void UpdateJob(Job job)
        {
            try
            {
                if (!conexionBD.Open())
                    return;

                string query = "UPDATE jobs SET job_title = @title, min_salary = @min, max_salary = @max WHERE job_id = @id;";
                using (SqlCommand command = new SqlCommand(query, conexionBD.Conexion))
                {
                    command.Parameters.AddWithValue("@title", job.JobTitle);
                    command.Parameters.AddWithValue("@min", NullToDBNull(job.MinSalary));
                    command.Parameters.AddWithValue("@max", NullToDBNull(job.MaxSalary));
                    command.Parameters.AddWithValue("@id", job.Id);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            finally
            {
                conexionBD.Close();
            }
        }
    }
}
