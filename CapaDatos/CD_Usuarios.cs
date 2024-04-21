using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

using System.Data.SqlClient;
using System.Data;
using CapaEntidad;
using System.Runtime.Remoting.Messaging;

namespace CapaDatos
{
    public class CD_Usuarios
    {
        SqlConnection Cnxion = new SqlConnection(CD_Conexion.CON_Cnxion);
        public List<Usuarios_sys> Llenar() {
            List<Usuarios_sys> Lista_Usuarios_Sys = new List<Usuarios_sys>();

                try
                {
                    SqlCommand CMD = new SqlCommand("SP_LLENAR_USUARIO", Cnxion);
                    CMD.CommandType = CommandType.StoredProcedure;

                    Cnxion.Open();

                    using (SqlDataReader Reader = CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                        Lista_Usuarios_Sys.Add(new Usuarios_sys()
                        {
                            ID_USUARIO = Convert.ToInt32(Reader["ID_USUARIO"]),
                            DOCUMENTO = Reader["DOCUMENTO"].ToString(),
                            NOMBRE = Reader["NOMBRE"].ToString(),
                            CORREO = Reader["CORREO"].ToString(),
                            PASSWORD = Reader["PASSW0RD"].ToString(),
                            ESTADO = Convert.ToBoolean(Reader["ESTADO"]),
                            OBJ_ROL = new Roles_sys()
                            {
                                ID_ROL = Convert.ToInt32(Reader["ID_ROL"]),
                                DESCRIPCION = Reader["DESCRIPCION"].ToString()
                            }
                        });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Lista_Usuarios_Sys = new List<Usuarios_sys>();
                }
           return Lista_Usuarios_Sys;
        }

        public int Insertar(Usuarios_sys OBJ_USUARIO, out string MENSAJE)
        {
            int Id_Usuario_Generado = 0;
            MENSAJE = string.Empty;

            try
            {
                Cnxion.Open();
                SqlCommand CMD_INSERT = new SqlCommand("SP_INSERTAR_USUARIOS", Cnxion);

                CMD_INSERT.CommandType = CommandType.StoredProcedure;
                CMD_INSERT.Parameters.AddWithValue("@DOCUMENTO", OBJ_USUARIO.DOCUMENTO);
                CMD_INSERT.Parameters.AddWithValue("@NOMBRE", OBJ_USUARIO.NOMBRE);
                CMD_INSERT.Parameters.AddWithValue("@CORREO", OBJ_USUARIO.CORREO);
                CMD_INSERT.Parameters.AddWithValue("@PASSW0RD", OBJ_USUARIO.PASSWORD);
                CMD_INSERT.Parameters.AddWithValue("@ID_ROL", OBJ_USUARIO.OBJ_ROL.ID_ROL);
                CMD_INSERT.Parameters.AddWithValue("@ESTADO", OBJ_USUARIO.ESTADO);
                CMD_INSERT.Parameters.Add("ID_USUARIO_RESULT",SqlDbType.Int).Direction = ParameterDirection.Output;
                CMD_INSERT.Parameters.Add("MENSAJE", SqlDbType.VarChar,500).Direction = ParameterDirection.Output;

                CMD_INSERT.ExecuteNonQuery();
                Id_Usuario_Generado = Convert.ToInt32(CMD_INSERT.Parameters["ID_USUARIO_RESULT"].Value);
                MENSAJE = CMD_INSERT.Parameters["MENSAJE"].Value.ToString();
               

            }
            catch (Exception ex)
            {
                Id_Usuario_Generado = 0;
                MENSAJE = ex.Message;
            }
            
            return Id_Usuario_Generado;
        }

        public bool Editar(Usuarios_sys OBJ_USUARIO, out string MENSAJE)
        {
            bool Respuesta = false;
            MENSAJE = string.Empty;

            try
            {
                
                Cnxion.Open();
                SqlCommand CMD_UPDATE = new SqlCommand("SP_EDITAR_USUARIOS", Cnxion);

                CMD_UPDATE.CommandType = CommandType.StoredProcedure;
                CMD_UPDATE.Parameters.AddWithValue("@ID_USUARIO", OBJ_USUARIO.ID_USUARIO);
                CMD_UPDATE.Parameters.AddWithValue("@DOCUMENTO", OBJ_USUARIO.DOCUMENTO);
                CMD_UPDATE.Parameters.AddWithValue("@NOMBRE", OBJ_USUARIO.NOMBRE);
                CMD_UPDATE.Parameters.AddWithValue("@CORREO", OBJ_USUARIO.CORREO);
                CMD_UPDATE.Parameters.AddWithValue("@PASSW0RD", OBJ_USUARIO.PASSWORD);
                CMD_UPDATE.Parameters.AddWithValue("@ID_ROL", OBJ_USUARIO.OBJ_ROL.ID_ROL);
                CMD_UPDATE.Parameters.AddWithValue("@ESTADO", OBJ_USUARIO.ESTADO);
                CMD_UPDATE.Parameters.Add("RESPUESTA", SqlDbType.Int).Direction = ParameterDirection.Output;
                CMD_UPDATE.Parameters.Add("MENSAJE", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                CMD_UPDATE.ExecuteNonQuery();

                Respuesta = Convert.ToBoolean(CMD_UPDATE.Parameters["RESPUESTA"].Value);
                MENSAJE = CMD_UPDATE.Parameters["MENSAJE"].Value.ToString();
               

            }
            catch (Exception ex)
            {
                Respuesta = false;
                MENSAJE = ex.Message;
            }

            return Respuesta;
        }

        public bool Eliminar(Usuarios_sys OBJ_USUARIO, out string MENSAJE)
        {
            bool Respuesta = false;
            MENSAJE = string.Empty;

            try
            {

                Cnxion.Open();
                SqlCommand CMD_DELETE = new SqlCommand("SP_ELIMINAR_USUARIOS", Cnxion);

                CMD_DELETE.CommandType = CommandType.StoredProcedure;
                CMD_DELETE.Parameters.AddWithValue("@ID_USUARIO", OBJ_USUARIO.ID_USUARIO);
                CMD_DELETE.Parameters.Add("RESPUESTA", SqlDbType.Int).Direction = ParameterDirection.Output;
                CMD_DELETE.Parameters.Add("MENSAJE", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                CMD_DELETE.ExecuteNonQuery();

                Respuesta = Convert.ToBoolean(CMD_DELETE.Parameters["RESPUESTA"].Value);
                MENSAJE = CMD_DELETE.Parameters["MENSAJE"].Value.ToString();
                Cnxion.Close();

            }
            catch (Exception ex)
            {
                Respuesta = false;
                MENSAJE = ex.Message;
            }

            return Respuesta;
        }

    }

}
