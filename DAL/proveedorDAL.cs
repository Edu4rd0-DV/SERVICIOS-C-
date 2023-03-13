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
     public  class proveedorDAL
    {
        public int agregar_proveedor(proveedor pen)
        {
            IDbConnection _com = Conexion.cnDB();
            _com.Open();
            SqlCommand _comando = new SqlCommand("agregar_proveedor", _com as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@nombre", pen.nombre));
            _comando.Parameters.Add(new SqlParameter("@contacto", pen.contacto));
            _comando.Parameters.Add(new SqlParameter("@dirrecion", pen.direcion));
            int resultado = _comando.ExecuteNonQuery();
            _com.Close();
            return resultado;
        }


        public int actualizar_proveedor(proveedor pen)
        {
            IDbConnection _com = Conexion.cnDB();
            _com.Open();
            SqlCommand _comando = new SqlCommand("actualizar_proveedor", _com as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@id", pen.Id));
            _comando.Parameters.Add(new SqlParameter("@nombre", pen.nombre));
            _comando.Parameters.Add(new SqlParameter("@contacto", pen.contacto));
            _comando.Parameters.Add(new SqlParameter("@dirrecion", pen.direcion));
            int resultado = _comando.ExecuteNonQuery();
            _com.Close();
            return resultado;
        }
        public int eliminar_proveedor(proveedor pen)
        {
            IDbConnection _com = Conexion.cnDB();
            _com.Open();
            SqlCommand _comando = new SqlCommand("eliminar_proveedor", _com as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@id", pen.Id));
            int resultado = _comando.ExecuteNonQuery();
            _com.Close();
            return resultado;
        }
        public List<proveedor> mostrar_proveedor()
        {
            IDbConnection _con = Conexion.cnDB();
            _con.Open();
            SqlCommand _comando = new SqlCommand("mostrar_proveedor", _con as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            IDataReader _lector = _comando.ExecuteReader();
            List<proveedor> lista = new List<proveedor>();
            while (_lector.Read())
            {
                proveedor _datos = new proveedor();
                _datos.Id = _lector.GetInt64(0);
                _datos.nombre = _lector.GetString(1);
                _datos.contacto = _lector.GetString(2);
                _datos.direcion = _lector.GetString(3);
                lista.Add(_datos);

            }
            _con.Close();
            return lista;

        }

        public List<proveedor> mostrar_proveedor_nombre( proveedor pen)
        {
            IDbConnection _con = Conexion.cnDB();
            _con.Open();
            SqlCommand _comando = new SqlCommand("buscar_proveedor", _con as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@nombre", pen.nombre));
            IDataReader _lector = _comando.ExecuteReader();
            List<proveedor> lista = new List<proveedor>();
            while (_lector.Read())
            {
                proveedor _datos = new proveedor();
                _datos.Id = _lector.GetInt64(0);
                _datos.nombre = _lector.GetString(1);
                _datos.contacto = _lector.GetString(2);
                _datos.direcion = _lector.GetString(3);
                lista.Add(_datos);

            }
            _con.Close();
            return lista;

        }

    }
}
