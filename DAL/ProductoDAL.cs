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
      public class ProductoDAL
    {
        public int agregar_producto( Producto pen)
        {
            IDbConnection _com = Conexion.cnDB();
            _com.Open();
            SqlCommand _comando = new SqlCommand("agregar_producto", _com as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@nombre", pen.nombre));
            _comando.Parameters.Add(new SqlParameter("@id_t", pen.id_tipo));
            _comando.Parameters.Add(new SqlParameter("@id_p", pen.id_presentacion));
            int resultado = _comando.ExecuteNonQuery();
            _com.Close();
            return resultado;
        }
        /// actualizar 
        public int actualizar_producto(Producto pen)
        {
            IDbConnection _com = Conexion.cnDB();
            _com.Open();
            SqlCommand _comando = new SqlCommand("actualizar_producto", _com as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@id", pen.id));
            _comando.Parameters.Add(new SqlParameter("@nombre", pen.nombre));
            _comando.Parameters.Add(new SqlParameter("@id_t", pen.id_tipo));
            _comando.Parameters.Add(new SqlParameter("@id_p", pen.id_presentacion));
            int resultado = _comando.ExecuteNonQuery();
            _com.Close();
            return resultado;
        }
        // eliminar----
        public int eliminar_producto(Producto pen)
        {
            IDbConnection _com = Conexion.cnDB();
            _com.Open();
            SqlCommand _comando = new SqlCommand("eliminar_producto", _com as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@id", pen.id));
            int resultado = _comando.ExecuteNonQuery();
            _com.Close();
            return resultado;
        }
        // mostrar----
        public List<Producto> mostrar_producto()
        {
            IDbConnection _con = Conexion.cnDB();
            _con.Open();
            SqlCommand _comando = new SqlCommand("mostrar_producto", _con as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            IDataReader _lector = _comando.ExecuteReader();
            List<Producto> lista = new List<Producto>();
            while (_lector.Read())
            {
                Producto _datos = new Producto();
                _datos.id= _lector.GetInt64(0);
                _datos.nombre = _lector.GetString(1);
                _datos.id_tipo = _lector.GetInt64(2);
                _datos.id_presentacion = _lector.GetInt64(3);
                _datos.Datatipo = _lector.GetString(4);
                _datos.DataPresentacion = _lector.GetString(5);
                lista.Add(_datos);

            }
            _con.Close();
            return lista;

        }

        public List<Producto> buscar_producto(Producto pen)
        {
            IDbConnection _con = Conexion.cnDB();
            _con.Open();
            SqlCommand _comando = new SqlCommand("buscar_producto", _con as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@nombre", pen.nombre));
            IDataReader _lector = _comando.ExecuteReader();
            List<Producto> lista = new List<Producto>();
            while (_lector.Read())
            {
                Producto _datos = new Producto();
                _datos.id = _lector.GetInt64(0);
                _datos.nombre = _lector.GetString(1);
                _datos.id_tipo = _lector.GetInt64(2);
                _datos.id_presentacion = _lector.GetInt64(3);
                _datos.Datatipo = _lector.GetString(4);
                _datos.DataPresentacion = _lector.GetString(5);
                lista.Add(_datos);

            }
            _con.Close();
            return lista;

        }
    }
}
