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
     public class presentacionDAL
    {
        public int agragar_presentacion(presentacion pen)
        {
            IDbConnection _com = Conexion.cnDB();
            _com.Open();
            SqlCommand _comando = new SqlCommand("agregar_presentacion", _com as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@nombre", pen.nombre));
            int resultado = _comando.ExecuteNonQuery();
            _com.Close();
            return resultado;
        }

        public int actualizar_presentacion(presentacion pen)
        {
            IDbConnection _com = Conexion.cnDB();
            _com.Open();
            SqlCommand _comando = new SqlCommand("actualizar_presentacion", _com as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@id", pen.id));
            _comando.Parameters.Add(new SqlParameter("@nombre", pen.nombre));
            int resultado = _comando.ExecuteNonQuery();
            _com.Close();
            return resultado;
        }



        public int eliminar_presentacion(presentacion pen)
        {
            IDbConnection _com = Conexion.cnDB();
            _com.Open();
            SqlCommand _comando = new SqlCommand("eliminar_presentacion", _com as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@id", pen.id));
            int resultado = _comando.ExecuteNonQuery();
            _com.Close();
            return resultado;
        }


        public List<presentacion> mostrar_presentacion()
        {
            IDbConnection _con = Conexion.cnDB();
            _con.Open();
            SqlCommand _comando = new SqlCommand("mostrar_presentacion", _con as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            IDataReader _lector = _comando.ExecuteReader();
            List<presentacion> lista = new List<presentacion>();
            while (_lector.Read())
            {
                presentacion _datos = new presentacion();
                _datos.id = _lector.GetInt64(0);
                _datos.nombre = _lector.GetString(1);
                lista.Add(_datos);

            }
            _con.Close();
            return lista;

        }



        public List<presentacion> buscar_presentacion( presentacion pen)
        {
            IDbConnection _con = Conexion.cnDB();
            _con.Open();
            SqlCommand _comando = new SqlCommand("buscar_presentacion", _con as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@nombre", pen.nombre));
            IDataReader _lector = _comando.ExecuteReader();
            List<presentacion> lista = new List<presentacion>();
            while (_lector.Read())
            {
                presentacion _datos = new presentacion();
                _datos.id = _lector.GetInt64(0);
                _datos.nombre = _lector.GetString(1);
                lista.Add(_datos);

            }
            _con.Close();
            return lista;

        }


    }
}
