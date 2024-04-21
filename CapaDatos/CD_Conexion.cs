using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Conexion
    {
        public static string CON_Cnxion = ConfigurationManager.ConnectionStrings["CON"].ToString();
    }
}
