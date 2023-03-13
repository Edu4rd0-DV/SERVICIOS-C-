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
    public  class tipoDAL
    {
        public int agragar_tipo(tipo pen)
        {
            IDbConnection _com = Conexion.cnDB();
            _com.Open();
            SqlCommand _comando = new SqlCommand("agregar_tipo", _com as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@nombre", pen.nombre));
            int resultado = _comando.ExecuteNonQuery();
            _com.Close();
            return resultado;
        }

        public List<tipo> mostrar_tipo()
        {
            IDbConnection _con = Conexion.cnDB();
            _con.Open();
            SqlCommand _comando = new SqlCommand("mostrar_tipo", _con as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            IDataReader _lector = _comando.ExecuteReader();
            List<tipo> lista = new List<tipo>();
            while (_lector.Read())
            {
                tipo _datos = new tipo();
                _datos.id = _lector.GetInt64(0);
                _datos.nombre = _lector.GetString(1);
                lista.Add(_datos);

            }
            _con.Close();
            return lista;

        }
        public int actualizar_tipo(tipo pen)
        {
            IDbConnection _com = Conexion.cnDB();
            _com.Open();
            SqlCommand _comando = new SqlCommand("actualizar_tipo", _com as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@id", pen.nombre));
            _comando.Parameters.Add(new SqlParameter("@nombre", pen.nombre));
            int resultado = _comando.ExecuteNonQuery();
            _com.Close();
            return resultado;
        }
        public int eliminar_tipo(tipo pen)
        {
            IDbConnection _com = Conexion.cnDB();
            _com.Open();
            SqlCommand _comando = new SqlCommand("eliminar_tipo", _com as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@id", pen.nombre));
            int resultado = _comando.ExecuteNonQuery();
            _com.Close();
            return resultado;
        }
        public List<tipo> buscar_tipo( tipo pen)
        {
            IDbConnection _con = Conexion.cnDB();
            _con.Open();
            SqlCommand _comando = new SqlCommand("buscar_tipo", _con as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@nombre", pen.nombre));
            IDataReader _lector = _comando.ExecuteReader();
            List<tipo> lista = new List<tipo>();
            while (_lector.Read())
            {
                tipo _datos = new tipo();
                _datos.id = _lector.GetInt64(0);
                _datos.nombre = _lector.GetString(1);
                lista.Add(_datos);

            }
            _con.Close();
            return lista;

        }
    }
}
