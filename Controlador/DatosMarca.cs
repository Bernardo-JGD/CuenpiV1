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
    class DatosMarca
    {
        private SqlCommand cmd = new SqlCommand();

        public DataTable mostrarMarcas()
        {

            try
            {
                ConexionBD.abrirConexion();
                cmd = new SqlCommand("SP_CargarMarcas", ConexionBD.conexion);
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                ConexionBD.cerrarConexion();
            }
            
        }

        public bool insertarMarcas(Marca ma)
        {
            try
            {

                ConexionBD.abrirConexion();
                cmd = new SqlCommand("SP_InsertarMarca", ConexionBD.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", ma.Nombre);

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
