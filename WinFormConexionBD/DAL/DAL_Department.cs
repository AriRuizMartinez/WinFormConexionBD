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

        public Department SelectDepartment(int id)
        {
            if(id == -1)
                return null;

            MessageBox.Show("Not implemented yet");
            return null;
        }
    }
}
