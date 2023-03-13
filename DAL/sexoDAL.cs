using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EN;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
   public class sexoDAL
    {
        public int agregar_sexo(sexo pen)
        {
            IDbConnection _com = Conexion.cnDB();
            _com.Open();
            SqlCommand _comando = new SqlCommand("agregar_sexo", _com as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@nombre", pen.nombre));
            int resultado = _comando.ExecuteNonQuery();
            _com.Close();
            return resultado;
        }

        public List<sexo> mostrar_sexo()
        {
            IDbConnection _con = Conexion.cnDB();
            _con.Open();
            SqlCommand _comando = new SqlCommand("mostrar_sexo", _con as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            IDataReader _lector = _comando.ExecuteReader();
            List<sexo> lista = new List<sexo>();
            while (_lector.Read())
            {
                sexo _datos = new sexo();
                _datos.id = _lector.GetInt32(0);
                _datos.nombre = _lector.GetString(1);
                lista.Add(_datos);

            }
            _con.Close();
            return lista;

        }

    }
}
