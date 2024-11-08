using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormConexionBD.Model;

namespace WinFormConexionBD.DAL
{
    public class DAL_Department
    {
        public static Department XSelectDepartmentById(int id)
        {
            DAL_Department department = new DAL_Department();
            return department.SelectDepartmentById(id);
        }
        public Department SelectDepartmentById(int id)
        {
            Console.WriteLine("Not implemented yet");
            return null;
        }
    }
}
