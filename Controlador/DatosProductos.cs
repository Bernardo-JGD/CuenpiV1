using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CuenPiDesk_V1.Modelo;
using System.Windows.Forms;
using System.Data;

namespace CuenPiDesk_V1.Controlador
{
    class DatosProductos
    {

        private SqlCommand cmd = new SqlCommand();
        SqlDataReader dr = null;
        public DataTable mostrarProductos()
        {
            try
            {
                ConexionBD.abrirConexion();
                cmd = new SqlCommand("SP_ConsultarProductos", ConexionBD.conexion);
                
                if (cmd.ExecuteNonQuery() != 0)
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    adaptador.Fill(dt);
                    return dt;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                ConexionBD.cerrarConexion();
            }
        }

        public Productos mostrarUnProducto(String pr)
        {
            try
            {
                
                ConexionBD.abrirConexion();
                cmd = new SqlCommand("SP_ConsultarUnProducto", ConexionBD.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@modelo", pr);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    Productos producto = new Productos();

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        //De donde me apoyé
                        //https://social.msdn.microsoft.com/Forums/es-ES/0fcb0667-ed16-48fd-9c3f-e589ec286677/guardar-resultado-de-select-en-un-array-c?forum=vcses
                        producto.Cantidad = Convert.ToByte(dr["cantidad"]);
                        producto.PrecioGanancia = Convert.ToInt16(dr["precioGanancia"]);
                    }
                    
                    return producto;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                ConexionBD.cerrarConexion();
            }
        }

        public bool insertarProductos(Productos pr)
        {
            try
            {
                ConexionBD.abrirConexion();
                cmd = new SqlCommand("SP_InsertarProductos", ConexionBD.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@modelo", pr.Modelo);
                cmd.Parameters.AddWithValue("@precioOriginal", pr.PrecioOriginal);
                cmd.Parameters.AddWithValue("@nombreMarca", pr.NombreMarca);
                cmd.Parameters.AddWithValue("@cantidad", pr.Cantidad);
                cmd.Parameters.AddWithValue("@detalle", pr.Detalle);
                cmd.Parameters.AddWithValue("@fechaCarga", pr.FechaCarga);
                cmd.Parameters.AddWithValue("@precioGanancia", pr.PrecioGanancia);

                if (cmd.ExecuteNonQuery() != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                ConexionBD.cerrarConexion();
            }
        }

    }
}
