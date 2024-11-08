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
    public class DAL_EmployeeLinQ
    {
        /*public static object NullToDBNull(object val)
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
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        public List<Employee> SelectEmployees()
        {
            try
            {
                if (!conexionBD.Open())
                    return null;

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
                    int? managerId = reader.IsDBNull(8) ? -1 : reader.GetInt32(8);
                    int? departmentId = reader.IsDBNull(9) ? -1 : reader.GetInt32(9);
                    if (managerId == -1)
                        managerId = null;
                    if (departmentId == -1)
                        departmentId = null;

                    Employee employee = new Employee(employeeId, firstName, lastName, email, phoneNumber, hireDate, jobID, salary, managerId, departmentId);
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

        public static Employee XSelectEmployeeById(int id)
        {
            DAL_Employee dalEmployee = new DAL_Employee();
            return dalEmployee.SelectEmployeeById(id);

        }

        public Employee SelectEmployeeById(int id)
        {
            try
            {
                if (!conexionBD.Open())
                    return null;

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
                    int? managerId = reader.IsDBNull(8) ? -1 : reader.GetInt32(8);
                    int? departmentId = reader.IsDBNull(9) ? -1 : reader.GetInt32(9);
                    if (managerId == -1)
                        managerId = null;
                    if (departmentId == -1)
                        departmentId = null;

                    employee = new Employee(employeeId, firstName, lastName, email, phoneNumber, hireDate, jobID, salary, managerId, departmentId);
                }
                reader.Close();
                return employee;
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
        public void UpdateEmployee(Employee employee)
        {
            try
            {
                if (!conexionBD.Open())
                    return;

                string query = "UPDATE employees SET first_name = @firstName, last_name = @lastName, email = @email, phone_number = @phone, hire_date = @hireDate, job_id = @jobId, salary= @salary, manager_id = @managerId, department_id = @departmentId WHERE employee_id = @id;";
                using (SqlCommand command = new SqlCommand(query, conexionBD.Conexion))
                {
                    command.Parameters.AddWithValue("@id", employee.Id);
                    command.Parameters.AddWithValue("@firstName", NullToDBNull(employee.First_name));
                    command.Parameters.AddWithValue("@lastName", employee.Last_name);
                    command.Parameters.AddWithValue("@email", employee.Email);
                    command.Parameters.AddWithValue("@phone", NullToDBNull(employee.Phone_number));
                    command.Parameters.AddWithValue("@hireDate", employee.Hire_date);
                    command.Parameters.AddWithValue("@jobId", employee.JobId);
                    command.Parameters.AddWithValue("@salary", employee.Salary);
                    command.Parameters.AddWithValue("@managerId", NullToDBNull(employee.ManagerId));
                    command.Parameters.AddWithValue("@departmentId", NullToDBNull(employee.DepartmentId));

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
        }*/
    }
}
