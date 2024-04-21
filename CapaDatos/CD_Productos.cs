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
    public class CD_Productos
    {

        SqlConnection Cnxion = new SqlConnection(CD_Conexion.CON_Cnxion);
        public List<Productos> Llenar(){
           List<Productos> Lista_Productos = new List<Productos>();

            try
            {
                StringBuilder Consulta = new StringBuilder();
                Consulta.AppendLine("SELECT ID_PRODUCTO, CODIGO, NOMBRE, P.DESCRIPCION, C.ID_CATEGORIA, C.DESCRIPCION[DESCRIPCION_CATEGORIA],");
                Consulta.AppendLine("CANT_DISPONIBLE, PRECIO_COMPRA, PRECIO_VENTA, P.ESTADO FROM PRODUCTOS P");
                Consulta.AppendLine("INNER JOIN CATEGORIAS C ON C.ID_CATEGORIA = P.ID_CATEGORIA");

                SqlCommand CMD = new SqlCommand(Consulta.ToString(), Cnxion);
                CMD.CommandType = CommandType.Text;

                Cnxion.Open();

                using (SqlDataReader Reader = CMD.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                    Lista_Productos.Add(new Productos()
                    {
                        ID_PRODUCTO = Convert.ToInt32(Reader["ID_PRODUCTO"]),
                        CODIGO = Reader["CODIGO"].ToString(),
                        NOMBRE = Reader["NOMBRE"].ToString(),
                        DESCRIPCION = Reader["DESCRIPCION"].ToString(),
                        OBJ_CATEGORIA = new Categorias()
                        {
                            ID_CATEGORIA = Convert.ToInt32(Reader["ID_CATEGORIA"]),
                            DESCRIPCION = Reader["DESCRIPCION_CATEGORIA"].ToString()
                        },
                        CANT_DISPONIBLE = Convert.ToInt32(Reader["CANT_DISPONIBLE"].ToString()),
                        PRECIO_COMPRA = Convert.ToDecimal(Reader["PRECIO_COMPRA"].ToString()),
                        PRECIO_VENTA = Convert.ToDecimal(Reader["PRECIO_VENTA"].ToString()),
                        ESTADO = Convert.ToBoolean(Reader["ESTADO"].ToString())
                    });
                    }
                }
            }
            catch (Exception ex)
            {
                Lista_Productos = new List<Productos>();
            }
        return Lista_Productos;
        }

        public int Insertar(Productos OBJ_PRODUCTO, out string MENSAJE)
        {
            int Id_Producto_Generado = 0;
            MENSAJE = string.Empty;

            try
            {
                
                SqlCommand CMD_INSERT = new SqlCommand("SP_INSERTAR_PRODUCTO", Cnxion);

                CMD_INSERT.CommandType = CommandType.StoredProcedure;
                CMD_INSERT.Parameters.AddWithValue("@CODIGO", OBJ_PRODUCTO.CODIGO);
                CMD_INSERT.Parameters.AddWithValue("@NOMBRE", OBJ_PRODUCTO.NOMBRE);
                CMD_INSERT.Parameters.AddWithValue("@DESCRIPCION", OBJ_PRODUCTO.DESCRIPCION);
                CMD_INSERT.Parameters.AddWithValue("@ID_CATEGORIA", OBJ_PRODUCTO.OBJ_CATEGORIA.ID_CATEGORIA);
                CMD_INSERT.Parameters.AddWithValue("@ESTADO", OBJ_PRODUCTO.ESTADO);
                CMD_INSERT.Parameters.Add("RESULTADO", SqlDbType.Int).Direction = ParameterDirection.Output;
                CMD_INSERT.Parameters.Add("MENSAJE", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                Cnxion.Open();

                CMD_INSERT.ExecuteNonQuery();
                Id_Producto_Generado = Convert.ToInt32(CMD_INSERT.Parameters["RESULTADO"].Value);
                MENSAJE = CMD_INSERT.Parameters["MENSAJE"].Value.ToString();


            }
            catch (Exception ex)
            {
                Id_Producto_Generado = 0;
                MENSAJE = ex.Message;
            }

            return Id_Producto_Generado;
        }

        public bool Editar(Productos OBJ_PRODUCTO, out string MENSAJE)
        {
            bool Respuesta = false;
            MENSAJE = string.Empty;

            try
            {
                SqlCommand CMD_UPDATE = new SqlCommand("SP_EDITAR_PRODUCTO", Cnxion);

                CMD_UPDATE.CommandType = CommandType.StoredProcedure;
                CMD_UPDATE.Parameters.AddWithValue("@ID_PRODUCTO", OBJ_PRODUCTO.ID_PRODUCTO);
                CMD_UPDATE.Parameters.AddWithValue("@CODIGO", OBJ_PRODUCTO.CODIGO);
                CMD_UPDATE.Parameters.AddWithValue("@NOMBRE", OBJ_PRODUCTO.NOMBRE);
                CMD_UPDATE.Parameters.AddWithValue("@DESCRIPCION", OBJ_PRODUCTO.DESCRIPCION);
                CMD_UPDATE.Parameters.AddWithValue("@ID_CATEGORIA", OBJ_PRODUCTO.OBJ_CATEGORIA.ID_CATEGORIA);
                CMD_UPDATE.Parameters.AddWithValue("@ESTADO", OBJ_PRODUCTO.ESTADO);
                CMD_UPDATE.Parameters.Add("RESULTADO", SqlDbType.Int).Direction = ParameterDirection.Output;
                CMD_UPDATE.Parameters.Add("MENSAJE", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                Cnxion.Open();

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

        public bool Eliminar(Productos OBJ_PRODUCTO, out string MENSAJE)
        {
            bool Respuesta = false;
            MENSAJE = string.Empty;

            try
            {

                Cnxion.Open();
                SqlCommand CMD_DELETE = new SqlCommand("SP_ELIMINAR_PRODUCTO", Cnxion);

                CMD_DELETE.CommandType = CommandType.StoredProcedure;
                CMD_DELETE.Parameters.AddWithValue("@ID_PRODUCTO", OBJ_PRODUCTO.ID_PRODUCTO);
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


