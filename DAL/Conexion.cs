using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DAL
{
     public static class Conexion
    {
        private static string conn = @"Data Source=LAPTOP-QFG60LF9\SQLEXPRESS;Initial Catalog = inventario_ex; Integrated Security = True";

        public static IDbConnection cnDB()
        {
            return new SqlConnection(conn);
        }
        public static IDbCommand obtenercomando(string pComando, IDbConnection pcn)
        {
            return new SqlCommand(pComando, pcn as SqlConnection);
        }

    }
}
