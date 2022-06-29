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
    class DatosClientes
    {

        private SqlCommand cmd = new SqlCommand();

        public DataTable mostrarClientes()
        {
            try
            {
                ConexionBD.abrirConexion();
                cmd = new SqlCommand("SP_ConsultarClientes", ConexionBD.conexion);
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

        public bool insertarClientes(Clientes cl)
        {
            try
            {
                
                ConexionBD.abrirConexion();
                cmd = new SqlCommand("SP_InsertarClientes", ConexionBD.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", cl.Nombre);
                cmd.Parameters.AddWithValue("@apodo", cl.Apodo);
                cmd.Parameters.AddWithValue("@direccion", cl.Direccion);
                cmd.Parameters.AddWithValue("@telefono", cl.Telefono);

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

        public bool modificarClientes(Clientes cl)
        {
            try
            {
                ConexionBD.abrirConexion();
                cmd = new SqlCommand("SP_ModificarClientes", ConexionBD.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idDeudor", cl.ID);
                cmd.Parameters.AddWithValue("@nombre", cl.Nombre);
                cmd.Parameters.AddWithValue("@apodo", cl.Apodo);
                cmd.Parameters.AddWithValue("@direccion", cl.Direccion);
                cmd.Parameters.AddWithValue("@telefono", cl.Telefono);

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
