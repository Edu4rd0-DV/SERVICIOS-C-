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
     public class ventasDAL
    {
        public int agragar_venta(ventas pen)
        {
            IDbConnection _com = Conexion.cnDB();
            _com.Open();
            SqlCommand _comando = new SqlCommand("agregar_venta", _com as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@id_producto",pen.id_producto ));
            _comando.Parameters.Add(new SqlParameter("@id_usuario", pen.id_usuario));
            _comando.Parameters.Add(new SqlParameter("@precio", pen.precio));
            _comando.Parameters.Add(new SqlParameter("@cantidad", pen.cantidad));
            _comando.Parameters.Add(new SqlParameter("@total", pen.total));
            _comando.Parameters.Add(new SqlParameter("@direccion", pen.direccion));
            int resultado = _comando.ExecuteNonQuery();
            _com.Close();
            return resultado;
        }

        public List<ventas> mostrar_ventas()
        {
            IDbConnection _con = Conexion.cnDB();
            _con.Open();
            SqlCommand _comando = new SqlCommand("mostra_venta", _con as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            IDataReader _lector = _comando.ExecuteReader();
            List<ventas> lista = new List<ventas>();
            while (_lector.Read())
            {
                ventas _datos = new ventas();
                _datos.id = _lector.GetInt64(0);
                _datos.id_producto = _lector.GetInt64(1);
                _datos.id_usuario = _lector.GetInt64(2);
                _datos.precio = _lector.GetDecimal(3);
                _datos.cantidad = _lector.GetInt64(4);
                _datos.total = _lector.GetDecimal(5);
                _datos.direccion = _lector.GetString(6);
                _datos.nombre = _lector.GetString(7);           
                _datos.correo = _lector.GetString(8);
                lista.Add(_datos);

            }
            _con.Close();
            return lista;

        }
        public List<ventas> buscar_ventas(ventas pen)
        {
            IDbConnection _con = Conexion.cnDB();
            _con.Open();
            SqlCommand _comando = new SqlCommand("buscar_venta", _con as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@correo", pen.correo));
            IDataReader _lector = _comando.ExecuteReader();
            List<ventas> lista = new List<ventas>();
            while (_lector.Read())
            {
                ventas _datos = new ventas();
                _datos.id = _lector.GetInt64(0);
                _datos.id_producto = _lector.GetInt64(1);
                _datos.id_usuario = _lector.GetInt64(2);
                _datos.precio = _lector.GetDecimal(3);
                _datos.cantidad = _lector.GetInt64(4);
                _datos.total = _lector.GetDecimal(5);
                _datos.direccion = _lector.GetString(6);
                _datos.nombre = _lector.GetString(7);
                _datos.correo = _lector.GetString(8);
                lista.Add(_datos);

            }
            _con.Close();
            return lista;

        }


    }
}
