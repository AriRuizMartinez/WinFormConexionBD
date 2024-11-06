using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormConexionBD.Model;

namespace WinFormConexionBD.DAL
{
    public class DAL_Employee
    {
        ConexionBD conexionBD;

        public DAL_Employee()
        {
            this.conexionBD = new ConexionBD();
        }

        public static object NullToDBNull(object val)
        {
            if (val == null)
                return DBNull.Value;
            else
                return val;
        }

        public void InsertEmployee(Employee employee)
        {
            try
            {
                if (!conexionBD.Open())
                {
                    MessageBox.Show("Ha habido un problema.");
                    return;
                }

                string query = "INSERT INTO employees(first_name, last_name, email, phone_number, hire_date, employee_id, salary) " +
                    "VALUES (@firstName, @lastName, @email, @phone, @hireDate, @jobId, @salary);" +
                    "SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, conexionBD.Conexion))
                {
                    command.Parameters.AddWithValue("@firstName", NullToDBNull(employee.First_name));
                    command.Parameters.AddWithValue("@lastName", employee.Last_name);
                    command.Parameters.AddWithValue("@email", employee.Email);
                    command.Parameters.AddWithValue("@phone", NullToDBNull(employee.Phone_number));
                    command.Parameters.AddWithValue("@hireDate", employee.Hire_date);
                    command.Parameters.AddWithValue("@jobId", employee.JobProperty.Id);
                    command.Parameters.AddWithValue("@salary", employee.Salary);


                    decimal result = (decimal)command.ExecuteScalar();
                    employee.Id = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conexionBD.Close();
            }
        }

        public List<Employee> SelectEmployees(DAL_Job dal_job)
        {
            try
            {
                if (!conexionBD.Open())
                {
                    MessageBox.Show("Ha habido un problema.");
                    return null;
                }

                List<Employee> employees = new List<Employee>();

                string query = "SELECT * FROM employees;";
                SqlCommand command = new SqlCommand(query, conexionBD.Conexion);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int employeeId = reader.GetInt32(0);
                    string firstName = reader.IsDBNull(1) ? null : reader.GetString(1);
                    string lastName = reader.GetString(2);
                    string email = reader.GetString(3);
                    string phoneNumber = reader.IsDBNull(4) ? null : reader.GetString(4);
                    DateTime hireDate = reader.GetDateTime(5);
                    int jobID = reader.GetInt32(6);
                    decimal salary = reader.GetDecimal(7);

                    Employee job = new Employee(employeeId, firstName, lastName, email, phoneNumber, hireDate, dal_job.SelectJob(jobID), salary);
                    employees.Add(job);
                }
                reader.Close();

                return employees;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                conexionBD.Close();
            }
        }
    }
}
