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
    public class CD_Categorias
    {
        SqlConnection Cnxion = new SqlConnection(CD_Conexion.CON_Cnxion);
        public List<Categorias> Llenar()
        {
            List<Categorias> Lista_Categorias = new List<Categorias>();

            try
            {
                SqlCommand CMD = new SqlCommand("SP_LLENAR_CATEGORIA", Cnxion);
                CMD.CommandType = CommandType.StoredProcedure;

                Cnxion.Open();

                using (SqlDataReader Reader = CMD.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        Lista_Categorias.Add(new Categorias()
                        {
                            ID_CATEGORIA = Convert.ToInt32(Reader["ID_CATEGORIA"]),
                            DESCRIPCION = Reader["DESCRIPCION"].ToString(),
                            ESTADO = Convert.ToBoolean(Reader["ESTADO"]),
                            
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Lista_Categorias = new List<Categorias>();
            }
            return Lista_Categorias;
        }

        public int Insertar(Categorias OBJ_CATEGORIA, out string MENSAJE)
        {
            int Id_Categoria_Generado = 0;
            MENSAJE = string.Empty;

            try
            {
                Cnxion.Open();
                SqlCommand CMD_INSERT = new SqlCommand("SP_INSERTAR_CATEGORIA", Cnxion);

                CMD_INSERT.CommandType = CommandType.StoredProcedure;
                CMD_INSERT.Parameters.AddWithValue("@DESCRIPCION", OBJ_CATEGORIA.DESCRIPCION);
                CMD_INSERT.Parameters.AddWithValue("@ESTADO", OBJ_CATEGORIA.ESTADO);
                CMD_INSERT.Parameters.Add("RESULTADO", SqlDbType.Int).Direction = ParameterDirection.Output;
                CMD_INSERT.Parameters.Add("MENSAJE", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                CMD_INSERT.ExecuteNonQuery();
                Id_Categoria_Generado = Convert.ToInt32(CMD_INSERT.Parameters["RESULTADO"].Value);
                MENSAJE = CMD_INSERT.Parameters["MENSAJE"].Value.ToString();


            }
            catch (Exception ex)
            {
                Id_Categoria_Generado = 0;
                MENSAJE = ex.Message;
            }

            return Id_Categoria_Generado;
        }

        public bool Editar(Categorias OBJ_CATEGORIA, out string MENSAJE)
        {
            bool Respuesta = false;
            MENSAJE = string.Empty;

            try
            {

                Cnxion.Open();
                SqlCommand CMD_UPDATE = new SqlCommand("SP_EDITAR_CATEGORIA", Cnxion);

                CMD_UPDATE.CommandType = CommandType.StoredProcedure;
                CMD_UPDATE.Parameters.AddWithValue("@ID_CATEGORIA", OBJ_CATEGORIA.ID_CATEGORIA);
                CMD_UPDATE.Parameters.AddWithValue("@DESCRIPCION", OBJ_CATEGORIA.DESCRIPCION);
                CMD_UPDATE.Parameters.AddWithValue("@ESTADO", OBJ_CATEGORIA.ESTADO);
                CMD_UPDATE.Parameters.Add("RESULTADO", SqlDbType.Int).Direction = ParameterDirection.Output;
                CMD_UPDATE.Parameters.Add("MENSAJE", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                CMD_UPDATE.ExecuteNonQuery();

                Respuesta = Convert.ToBoolean(CMD_UPDATE.Parameters["RESULTADO"].Value);
                MENSAJE = CMD_UPDATE.Parameters["MENSAJE"].Value.ToString();


            }
            catch (Exception ex)
            {
                Respuesta = false;
                MENSAJE = ex.Message;
            }

            return Respuesta;
        }

        public bool Eliminar(Categorias OBJ_CATEGORIA, out string MENSAJE)
        {
            bool Respuesta = false;
            MENSAJE = string.Empty;

            try
            {

                Cnxion.Open();
                SqlCommand CMD_DELETE = new SqlCommand("SP_ELIMINAR_CATEGORIA", Cnxion);

                CMD_DELETE.CommandType = CommandType.StoredProcedure;
                CMD_DELETE.Parameters.AddWithValue("@ID_CATEGORIA", OBJ_CATEGORIA.ID_CATEGORIA);
                CMD_DELETE.Parameters.Add("RESULTADO", SqlDbType.Int).Direction = ParameterDirection.Output;
                CMD_DELETE.Parameters.Add("MENSAJE", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                CMD_DELETE.ExecuteNonQuery();

                Respuesta = Convert.ToBoolean(CMD_DELETE.Parameters["RESULTADO"].Value);
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
