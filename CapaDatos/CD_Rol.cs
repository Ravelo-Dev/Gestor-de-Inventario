using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Rol
    {
        public List<Roles_sys> Llenar()
        {
            List<Roles_sys> Lista_Roles_Sys = new List<Roles_sys>();

            using (SqlConnection Cnxion = new SqlConnection(CD_Conexion.CON_Cnxion))
            {

                try
                {

                    SqlCommand CMD = new SqlCommand("SP_LLENAR_ROL", Cnxion);
                    CMD.CommandType = CommandType.StoredProcedure;

                    Cnxion.Open();

                    using (SqlDataReader Reader = CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            Lista_Roles_Sys.Add(new Roles_sys()
                            {

                                ID_ROL = Convert.ToInt32(Reader["ID_ROL"]),
                                DESCRIPCION = Reader["DESCRIPCION"].ToString()

                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Lista_Roles_Sys = new List<Roles_sys>();
                }
            }
            return Lista_Roles_Sys;
        }
    }
}
