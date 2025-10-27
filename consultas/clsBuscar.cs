using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using tarea_4._3_TransaccionBD.pojo;

namespace tarea_4._3_TransaccionBD.consultas
{
    public class clsBuscar
    {
        public DataTable ObtenerProductos(clsProducts producto)
        {
            DataTable tabla = new DataTable();

            using (MySqlConnection cn = new MySqlConnection("server=localhost; database=products; user=root; pwd=Dagu12oa"))
            {
                cn.Open();

                 string strSQL = "select * from product where codigo = @codigo";

                using (MySqlCommand comando = new MySqlCommand(strSQL, cn))
                {
                    comando.Parameters.AddWithValue("@codigo", producto.Codigo);

                    using (MySqlDataAdapter da = new MySqlDataAdapter(comando))
                    {
                        da.Fill(tabla);
                    }
                }
            }

            return tabla;
        }

        public int buscarProducto(clsProducts producto)
        {
            /// CREAR LA CONEXIÓN, CONFIGURAR Y ABRIRLA
            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = "server=localhost; database=products; user=root; pwd=Dagu12oa";
            cn.Open();

            /// CONSULTA
            string strSQL = "select count(*) from product where codigo = @codigo";

            MySqlCommand comando = new MySqlCommand(strSQL, cn);
            comando.Parameters.AddWithValue("@codigo", producto.Codigo);
           

            int resultado = Convert.ToInt32(comando.ExecuteScalar());

            // comando.ExecuteNonQuery();

            /// FINALIZAMOS LA CONEXION CERRAMOS TODO
            comando.Dispose();
            cn.Close();
            cn.Dispose();

            if (resultado > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public bool DescontinuarProducto(List<clsProducts> productos)
        {
            if (productos.Count == 0)
            {
                return false;
            }

            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = "server=localhost; database=products; user=root; pwd=Dagu12oa";
            cn.Open();
            MySqlTransaction trans = cn.BeginTransaction();

            try
            {
                foreach (clsProducts producto in productos) {
                    string strSQL = "UPDATE product SET estado = 'Inactivo' WHERE codigo = @codigo";
                    MySqlCommand comando = new MySqlCommand(strSQL, cn);
                    comando.Parameters.AddWithValue("codigo", producto.Codigo);
                    comando.ExecuteNonQuery();
                    comando.Dispose();
                }

                 trans.Commit();
                 return true;
            }
            catch (Exception ex)
            {
                trans.Rollback();
                throw new Exception(ex.Message);
            }
            finally
            {
                trans.Dispose();
                cn.Close();
                cn.Dispose();
            }
        }
    }
}
