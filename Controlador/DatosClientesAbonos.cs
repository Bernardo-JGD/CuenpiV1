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
    class DatosClientesAbonos
    {

        private SqlCommand cmd = new SqlCommand();

        public bool insertarAbonos(AbonosClientes ac)
        {
            try
            {

                ConexionBD.abrirConexion();
                cmd = new SqlCommand("SP_InsertarAbonos", ConexionBD.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idDeudor", ac.IdDeudor);
                cmd.Parameters.AddWithValue("@cantidad", ac.Cantidad);
                cmd.Parameters.AddWithValue("@fecha", ac.FechaAbono);

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

        public DataTable mostrarAbonos(int idCliente)
        {
            try
            {
                ConexionBD.abrirConexion();
                cmd = new SqlCommand("SP_ConsultarAbonos", ConexionBD.conexion);
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

        public bool modificarAbonos(AbonosClientes ac)
        {
            try
            {
                ConexionBD.abrirConexion();
                cmd = new SqlCommand("SP_ModificarAbonos", ConexionBD.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idAbono", ac.IdAbono);
                cmd.Parameters.AddWithValue("@cantidad", ac.Cantidad);
                cmd.Parameters.AddWithValue("@fecha", ac.FechaAbono);

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

        public Int16 consultarTotalAbonos(int idDeudor)
        {
            try
            {

                ConexionBD.abrirConexion();
                cmd = new SqlCommand("SP_TotalAbono", ConexionBD.conexion);
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
                MessageBox.Show("No hay abonos registrados: " + ex.Message);
                return 0;
            }
            finally
            {
                ConexionBD.cerrarConexion();
            }
        }

        public DataTable mostrarAbonosFiltrados(int idCliente, DateTime fecha1, DateTime fecha2)
        {
            try
            {
                ConexionBD.abrirConexion();
                cmd = new SqlCommand("SP_ConsultarAbonosRangoFecha", ConexionBD.conexion);
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
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
            finally
            {
                ConexionBD.cerrarConexion();
            }
        }

    }
}
