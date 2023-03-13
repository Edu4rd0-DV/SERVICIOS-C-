using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EN;
namespace DAL
{
     public class CargoDAL
    {
        public int agregar_cargo(cargo pen)
        {
            IDbConnection _com = Conexion.cnDB();
            _com.Open();
            SqlCommand _comando = new SqlCommand("agregar_cargo", _com as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@nombre", pen.nombre));
            int resultado = _comando.ExecuteNonQuery();
            _com.Close();
            return resultado;
        }

        public List<cargo> mostrar_cargo()
        {
            IDbConnection _con = Conexion.cnDB();
            _con.Open();
            SqlCommand _comando = new SqlCommand("mostrar_cargo", _con as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            IDataReader _lector = _comando.ExecuteReader();
            List<cargo> lista = new List<cargo>();
            while (_lector.Read())
            {
                cargo _datos = new cargo();
                _datos.id = _lector.GetInt32(0);
                _datos.nombre = _lector.GetString(1);
                lista.Add(_datos);

            }
            _con.Close();
            return lista;

        }
    }
}
