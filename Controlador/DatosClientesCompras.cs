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
    class DatosClientesCompras
    {

        private SqlCommand cmd = new SqlCommand();

        public DataTable mostrarCompras(int idCliente)
        {
            try
            {
                ConexionBD.abrirConexion();
                cmd = new SqlCommand("SP_ConsultarCompras", ConexionBD.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idDeudor", idCliente);

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

        public DataTable mostrarComprasFiltradas(int idCliente, DateTime fecha1, DateTime fecha2)
        {
            try
            {
                ConexionBD.abrirConexion();
                cmd = new SqlCommand("SP_ConsultarComprasRangoFecha", ConexionBD.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idDeudor", idCliente);
                cmd.Parameters.AddWithValue("@fecha1", fecha1);
                cmd.Parameters.AddWithValue("@fecha2", fecha2);

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

        public bool insertarCompra(Compra c)
        {
            try
            {
                ConexionBD.abrirConexion();
                cmd = new SqlCommand("SP_InsertarCompra", ConexionBD.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@modelo", c.Modelo);
                cmd.Parameters.AddWithValue("@idDeudor", c.IdDeudor);
                cmd.Parameters.AddWithValue("@cantidad", c.Cantidad);
                cmd.Parameters.AddWithValue("@detalleCompra", c.Detalle);
                cmd.Parameters.AddWithValue("@totalCompra", c.TotalCompra);
                cmd.Parameters.AddWithValue("@fechaCompra", c.FechaCompra);


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

        public bool modificarCompras(Compra c)
        {
            try
            {
                ConexionBD.abrirConexion();
                cmd = new SqlCommand("SP_ModificarCompra", ConexionBD.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCompra", c.IdCompra);
                cmd.Parameters.AddWithValue("@modelo", c.Modelo);
                cmd.Parameters.AddWithValue("@cantidad", c.Cantidad);
                cmd.Parameters.AddWithValue("@detalle", c.Detalle);
                cmd.Parameters.AddWithValue("@fechaCompra", c.FechaCompra);
                cmd.Parameters.AddWithValue("@totalCompra", c.TotalCompra);

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

        public Compra consultarUnaCompra(int idCompra)
        {
            try
            {

                ConexionBD.abrirConexion();
                cmd = new SqlCommand("SP_SeleccionarModeloCompra", ConexionBD.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCompra", idCompra);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    Compra datosCompra = new Compra();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        //De donde me apoyé
                        //https://social.msdn.microsoft.com/Forums/es-ES/0fcb0667-ed16-48fd-9c3f-e589ec286677/guardar-resultado-de-select-en-un-array-c?forum=vcses
                        datosCompra.Modelo = Convert.ToString(dr["modelo"]);
                        datosCompra.Cantidad = Convert.ToByte(dr["cantidad"]);
                        datosCompra.TotalCompra = Convert.ToInt16(dr["precioGanancia"]);
                        datosCompra.CantidadUnaCompra = Convert.ToByte(dr["cantidadProducto"]);
                        datosCompra.Detalle = Convert.ToString(dr["detalleCompra"]);
                    }

                    return datosCompra;
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

        public Int16 consultarTotalCompras(int idDeudor)
        {
            try
            {

                ConexionBD.abrirConexion();
                cmd = new SqlCommand("SP_TotalCompra", ConexionBD.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idDeudor", idDeudor);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    Int16 total = 0;

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        //De donde me apoyé
                        //https://social.msdn.microsoft.com/Forums/es-ES/0fcb0667-ed16-48fd-9c3f-e589ec286677/guardar-resultado-de-select-en-un-array-c?forum=vcses
                        total = Convert.ToInt16(dr["SUMValor"]);
                    }

                    return total;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay compras registrados: " + ex.Message);
                return 0;
            }
            finally
            {
                ConexionBD.cerrarConexion();
            }
        }

        public bool eliminarCompra(int idCompra, string modelo, byte cantidadCompra)
        {
            try
            {
                ConexionBD.abrirConexion();
                cmd = new SqlCommand("SP_EliminarCompra", ConexionBD.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCompra", idCompra);
                cmd.Parameters.AddWithValue("@modelo", modelo);
                cmd.Parameters.AddWithValue("@cantidad", cantidadCompra);

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
                MessageBox.Show("Error: " + ex);
                return false;
            }
            finally
            {
                ConexionBD.cerrarConexion();
            }
        }

    }
}
