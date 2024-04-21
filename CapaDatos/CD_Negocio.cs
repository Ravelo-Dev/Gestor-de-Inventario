using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaDatos
{
    public class CD_Negocio
    {
        SqlConnection Cnxion = new SqlConnection(CD_Conexion.CON_Cnxion);
        public Negocios LlenarDatos()
        {
            Negocios obj = new Negocios();

            try
            {
           
                string Consulta = "SELECT ID_NEGOCIO, NOMBRE, RNC, DIRECCION FROM NEGOCIO WHERE ID_NEGOCIO = 1";
                SqlCommand CMD = new SqlCommand(Consulta, Cnxion);
                CMD.CommandType = CommandType.Text;

                Cnxion.Open();

                using (SqlDataReader reader = CMD.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        obj = new Negocios()
                        {
                            ID_NEGOCIO = int.Parse(reader["ID_NEGOCIO"].ToString()),
                            NOMBRE = reader["NOMBRE"].ToString(),
                            RNC = reader["RNC"].ToString(),
                            DIRECCION = reader["DIRECCION"].ToString()

                        };
                    }
                }

                Cnxion.Close();
            }
            catch { }
            {
                //obj = new Negocios();

            }

            return obj;
        }

        public bool GuardarDatos(Negocios obj, out string MENSAJE)
        {
            MENSAJE = string.Empty;
            bool Respuesta = true;

            try
            {
               
                Cnxion.Open();

                StringBuilder Consulta = new StringBuilder();
                Consulta.AppendLine("UPDATE NEGOCIO SET NOMBRE = @NOMBRE, RNC = @RNC,");
                Consulta.AppendLine("DIRECCION = @DIRECCCION WHERE ID_NEGOCIO = 1,");

                SqlCommand CMD = new SqlCommand(Consulta.ToString(), Cnxion);
                CMD.Parameters.AddWithValue("@NOMBRE", obj.NOMBRE);
                CMD.Parameters.AddWithValue("@RNC", obj.RNC);
                CMD.Parameters.AddWithValue("@DIRECCION", obj.DIRECCION);
                CMD.CommandType = CommandType.Text;

                if (CMD.ExecuteNonQuery() < 1) {
                    MENSAJE = "NO SE PUDO GUARDAR!";
                    Respuesta = false; 
                }

            }
            catch (Exception e) 
            {
                MENSAJE = e.Message;
                Respuesta = false;

            }

            return Respuesta;
        }

        public byte[] ObtenerLogo(out bool Obtenido)
        {
            Obtenido = true;
            byte[] LogoBytes = new byte[0];

            try
            {
                
                Cnxion.Open();
                string Consulta = "SELECT LOGO FROM NEGOCIO WHERE ID_NEGOCIO = 1";

                SqlCommand CMD = new SqlCommand(Consulta, Cnxion);
                
                CMD.CommandType = CommandType.Text;

                using (SqlDataReader reader = CMD.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        LogoBytes = (byte[])reader["LOGO"];
                    }
                }
                
            }
            catch (Exception e)
            {
                Obtenido = false;
                LogoBytes = new byte[0];

            }

            return LogoBytes;

        }


        public bool ActualizarLogo(byte[] IMAGEN, out string MENSAJE)
        {
            MENSAJE = string.Empty;
            bool Respuesta = true;

            try
            {
                using (SqlConnection Cnxion = new SqlConnection(CD_Conexion.CON_Cnxion))
                {
                    Cnxion.Open();

                    StringBuilder Consulta = new StringBuilder();
                    Consulta.AppendLine("UPDATE NEGOCIO SET LOGO = @IMAGEN");
                    Consulta.AppendLine(" WHERE ID_NEGOCIO = 1");

                    SqlCommand CMD = new SqlCommand(Consulta.ToString(), Cnxion);
                    CMD.Parameters.AddWithValue("@IMAGEN", IMAGEN);
                    CMD.CommandType = CommandType.Text;

                    if (CMD.ExecuteNonQuery() < 1)
                    {
                        MENSAJE = "NO SE PUDO ACTUALIZAR!";
                        Respuesta = false;
                    }

                }
            }
            catch (Exception e)
            {
                MENSAJE = e.Message;
                Respuesta = false;

            }

            return Respuesta;
        }

    }
}
