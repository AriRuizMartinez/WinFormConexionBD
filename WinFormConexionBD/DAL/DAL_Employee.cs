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

                string query = "INSERT INTO employees(first_name, last_name, email, phone_number, hire_date, employee_id, salary, manager_id, department_id) " +
                    "VALUES (@firstName, @lastName, @email, @phone, @hireDate, @jobId, @salary, @manager, @department);" +
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
                    if (employee.Manager != null)
                        command.Parameters.AddWithValue("@manager", employee.Manager.Id);
                    else
                        command.Parameters.AddWithValue("@manager", NullToDBNull(employee.Manager));
                    if(employee.DepartmentProperty != null)
                        command.Parameters.AddWithValue("@department", employee.DepartmentProperty.Id);
                    else
                        command.Parameters.AddWithValue("@department", NullToDBNull(employee.DepartmentProperty));

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

        public List<Employee> SelectEmployees(DAL_Job dal_job, DAL_Department dal_department)
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
                    int managerId = reader.IsDBNull(8) ? -1 : reader.GetInt32(8);
                    int departmentId = reader.IsDBNull(9) ? -1 : reader.GetInt32(9);

                    //Cuando busca al manager cierra el reader y por lo tanto no puede leer la siguiente linia
                    Employee employee = new Employee(employeeId, firstName, lastName, email, phoneNumber, hireDate, dal_job.SelectJob(jobID), salary, SelectEmployee(dal_job, dal_department, managerId), dal_department.SelectDepartment(departmentId));
                    employees.Add(employee);
                }
                reader.Close();

                return employees;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
            finally
            {
                conexionBD.Close();
            }
        }

        public Employee SelectEmployee(DAL_Job dal_job, DAL_Department dal_department, int id)
        {
            if (id == -1)
                return null;
            try
            {
                if (!conexionBD.Open())
                {
                    MessageBox.Show("Ha habido un problema.");
                    return null;
                }

                string query = "SELECT * FROM employees WHERE employee_id = " + id + ";";
                SqlCommand command = new SqlCommand(query, conexionBD.Conexion);

                SqlDataReader reader = command.ExecuteReader();

                Employee employee = null;

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
                    int managerId = reader.IsDBNull(8) ? -1 : reader.GetInt32(8);
                    int departmentId = reader.IsDBNull(9) ? -1 : reader.GetInt32(9);

                    employee = new Employee(employeeId, firstName, lastName, email, phoneNumber, hireDate, dal_job.SelectJob(jobID), salary, SelectEmployee(dal_job, dal_department, managerId), dal_department.SelectDepartment(departmentId));
                }
                reader.Close();
                return employee;
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
