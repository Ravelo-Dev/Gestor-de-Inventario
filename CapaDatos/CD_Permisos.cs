using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace CapaDatos
{
    public class CD_Permisos
    {

        public List<Permisos_sys> Llenar(int ID_USUARIO)
        {
            List<Permisos_sys> Lista_Permisos_Sys = new List<Permisos_sys>();

            using (SqlConnection Cnxion = new SqlConnection(CD_Conexion.CON_Cnxion))
            {

                try
                {

                    StringBuilder Consulta = new StringBuilder();
                    Consulta.AppendLine("SELECT P.ID_ROL, P.NOMBRE_MENU FROM PERMISOS_SYS P");
                    Consulta.AppendLine("INNER JOIN ROLES_SYS R ON R.ID_ROL = P.ID_ROL");
                    Consulta.AppendLine("INNER JOIN USUARIOS_SYS U ON U.ID_ROL = R.ID_ROL");
                    Consulta.AppendLine(" WHERE U.ID_USUARIO = @ID_USUARIO");

                   
                    SqlCommand CMD = new SqlCommand(Consulta.ToString(), Cnxion);
                    CMD.Parameters.AddWithValue("@ID_USUARIO", ID_USUARIO);
                    CMD.CommandType = CommandType.Text;

                    Cnxion.Open();

                    using (SqlDataReader Reader = CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            Lista_Permisos_Sys.Add(new Permisos_sys()
                            {
                                OBJ_ROL = new Roles_sys()
                                {
                                    ID_ROL = Convert.ToInt32(Reader["ID_ROL"])
                                },
                                NOMBRE_MENU = Reader["NOMBRE_MENU"].ToString(),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Lista_Permisos_Sys = new List<Permisos_sys>();
                }
            }
            return Lista_Permisos_Sys;
        }

    }
}
