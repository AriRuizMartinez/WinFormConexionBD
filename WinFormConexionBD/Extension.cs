using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormConexionBD
{
    public partial class employees
    {
        public override string ToString()
        {
            return first_name + " " + last_name;
        }
    }

    public partial class jobs
    {
        public override string ToString() 
        {
            return job_title;
        }
    }
}
