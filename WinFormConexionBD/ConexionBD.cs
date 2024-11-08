using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace WinFormConexionBD
{
    public class ConexionBD
    {
        public SqlConnection Conexion {  get; }

        public ConexionBD()
        {
            SqlConnectionStringBuilder constructorCadenaConexion = new SqlConnectionStringBuilder
            {
                DataSource = "85.208.21.117,54321",
                InitialCatalog = "AriEmployees",
                UserID = "sa",
                Password = "Sql#123456789"
            };
            Conexion = new SqlConnection(constructorCadenaConexion.ToString());
        }

        public bool Open()
        {
            if (Conexion.State == ConnectionState.Open)
                return true;
            try
            {
                Conexion.Open();
                return true;
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error: " + ex);
                return false;
            }
        }

        public bool Close() 
        {
            try
            {
                Conexion.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                return false;
            }
        }
    }
}
