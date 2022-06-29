using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CuenPiDesk_V1.Controlador
{
    internal static class ConexionBD
    {

        public static SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-2PFS1IO; Initial Catalog=CuenpiV1Desk; User ID=sa; Password=c0n53rver");
        public static void abrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
        }

        public static void cerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }

    }
}
