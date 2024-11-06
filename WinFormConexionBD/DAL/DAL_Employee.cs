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

                string query = "INSERT INTO employees(first_name, last_name, email, phone_number, hire_date, job_id, salary) " +
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
    }
}
