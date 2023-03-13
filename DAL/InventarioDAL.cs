using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EN;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class InventarioDAL
    {
        public int agragar_inventario(Inventariob pen)
        {
            IDbConnection _com = Conexion.cnDB();
            _com.Open();
            SqlCommand _comando = new SqlCommand("agregar_inventario", _com as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@id_p", pen.id_producto));
            _comando.Parameters.Add(new SqlParameter("@cantidad", pen.Cantidad));
            _comando.Parameters.Add(new SqlParameter("@precio", pen.Precio));
            _comando.Parameters.Add(new SqlParameter("@id_pv", pen.id_proveedor));
            _comando.Parameters.Add(new SqlParameter("@sexo", pen.id_sexo));
            _comando.Parameters.Add(new SqlParameter("@fe", pen.fecha_e));
            _comando.Parameters.Add(new SqlParameter("@imagen", pen.imagen));
            _comando.Parameters.Add(new SqlParameter("@descripcion", pen.descripcion));
            int resultado = _comando.ExecuteNonQuery();
            _com.Close();
            return resultado;
        }
        /// actualizar 
        public int actualizar_inventario(Inventariob pen)
        {
            IDbConnection _com = Conexion.cnDB();
            _com.Open();
            SqlCommand _comando = new SqlCommand("actualizar_inventario", _com as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@id", pen.id));
            _comando.Parameters.Add(new SqlParameter("@id_p", pen.id_producto));
            _comando.Parameters.Add(new SqlParameter("@cantidad", pen.Cantidad));
            _comando.Parameters.Add(new SqlParameter("@precio", pen.Precio));
            _comando.Parameters.Add(new SqlParameter("@id_pv", pen.id_proveedor));
            _comando.Parameters.Add(new SqlParameter("sexo", pen.id_sexo));
            _comando.Parameters.Add(new SqlParameter("fe", pen.fecha_e));
            _comando.Parameters.Add(new SqlParameter("@imagen", pen.imagen));
            int resultado = _comando.ExecuteNonQuery();
            _com.Close();
            return resultado;
        }
        // eliminar----
        public int eliminar_inventario( Inventariob pen)
        {
            IDbConnection _com = Conexion.cnDB();
            _com.Open();
            SqlCommand _comando = new SqlCommand("eliminar_inventario", _com as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@id", pen.id));
            int resultado = _comando.ExecuteNonQuery();
            _com.Close();
            return resultado;
        }
        // mostrar----
        public List<Inventariob> mostrar_inventario()
        {
            IDbConnection _con = Conexion.cnDB();
            _con.Open();
            SqlCommand _comando = new SqlCommand("mostrar_inventario", _con as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            IDataReader _lector = _comando.ExecuteReader();
            List<Inventariob> lista = new List<Inventariob>();
            while (_lector.Read())
            {
                Inventariob _datos = new  Inventariob();
                _datos.id = _lector.GetInt64(0);
                _datos.id_producto = _lector.GetInt64(1);
                _datos.Cantidad = _lector.GetInt64(2);
                _datos.Precio = _lector.GetDecimal(3);
                _datos.id_proveedor = _lector.GetInt64(4);
                _datos.id_sexo = _lector.GetInt32(5);
                _datos.fecha_e = _lector.GetString(6);
                _datos.imagen = (byte[])_lector["imagen"]; ;
                _datos.descripcion = _lector.GetString(8);
                _datos.DataProducto = _lector.GetString(9);
                _datos.DataProveedor = _lector.GetString(10);
                _datos.Datasexo = _lector.GetString(11);
                lista.Add(_datos);

            }
            _con.Close();
            return lista;

        }


        public List<Inventariob> buscar_inventario(Inventariob pen)
        {
            IDbConnection _con = Conexion.cnDB();
            _con.Open();
            SqlCommand _comando = new SqlCommand("buscar_inventario", _con as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@nombre", pen.DataProducto));
            IDataReader _lector = _comando.ExecuteReader();
            List<Inventariob> lista = new List<Inventariob>();
            while (_lector.Read())
            {
                Inventariob _datos = new Inventariob();
                _datos.id = _lector.GetInt64(0);
                _datos.id_producto = _lector.GetInt64(1);
                _datos.Cantidad = _lector.GetInt64(2);
                _datos.Precio = _lector.GetDecimal(3);
                _datos.id_proveedor = _lector.GetInt64(4);
                _datos.id_sexo = _lector.GetInt32 (5);
                _datos.fecha_e = _lector.GetString(6);
                _datos.imagen = (byte[])_lector["imagen"]; ;
                _datos.descripcion = _lector.GetString(8);
                _datos.DataProducto = _lector.GetString(9);
                _datos.DataProveedor = _lector.GetString(10);
                _datos.Datasexo = _lector.GetString(11);
                lista.Add(_datos);

            }
            _con.Close();
            return lista;

        }



        public List<Inventariob> mostrar_inventario_id (Int64 pen)
        {
            IDbConnection _con = Conexion.cnDB();
            _con.Open();
            SqlCommand _comando = new SqlCommand("buscar_inventario_id", _con as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@id", pen));
            IDataReader _lector = _comando.ExecuteReader();
            List<Inventariob> lista = new List<Inventariob>();
            while (_lector.Read())
            {
                Inventariob _datos = new Inventariob();
                _datos.id = _lector.GetInt64(0);
                _datos.id_producto = _lector.GetInt64(1);
                _datos.Cantidad = _lector.GetInt64(2);
                _datos.Precio = _lector.GetDecimal(3);
                _datos.id_proveedor = _lector.GetInt64(4);
                _datos.id_sexo = _lector.GetInt32(5);
                _datos.fecha_e = _lector.GetString(6);
                _datos.imagen = (byte[])_lector["imagen"]; ;
                _datos.descripcion = _lector.GetString(8);
                _datos.DataProducto = _lector.GetString(9);
                _datos.DataProveedor = _lector.GetString(10);
                _datos.Datasexo = _lector.GetString(11);
                lista.Add(_datos);

            }
            _con.Close();
            return lista;

        }

        public Inventariob Listar_Productos_carrito(Int64 pid)
        {
            IDbConnection _con = Conexion.cnDB();
            _con.Open();
            SqlCommand _comando = new SqlCommand("buscar_inventario_id", _con as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@id", pid));
            IDataReader _lector = _comando.ExecuteReader();
           Inventariob _datos = new Inventariob();
            if (_lector.Read())
            {
                _datos.id = _lector.GetInt64(0);
                _datos.id_producto = _lector.GetInt64(1);
                _datos.Cantidad = _lector.GetInt64(2);
                _datos.Precio = _lector.GetDecimal(3);
                _datos.id_proveedor = _lector.GetInt64(4);
                _datos.id_sexo = _lector.GetInt32(5);
                _datos.fecha_e = _lector.GetString(6);
                _datos.imagen = (byte[])_lector["imagen"]; ;
                _datos.descripcion = _lector.GetString(8);
                _datos.DataProducto = _lector.GetString(9);
                _datos.DataProveedor = _lector.GetString(10);
                _datos.Datasexo = _lector.GetString(11);
            }
            _con.Close();
            return _datos;

        }

        public List<Inventariob> mostrar_inventario_mujeres()
        {
            IDbConnection _con = Conexion.cnDB();
            _con.Open();
            SqlCommand _comando = new SqlCommand("buscar_inventario_mujeres", _con as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            IDataReader _lector = _comando.ExecuteReader();
            List<Inventariob> lista = new List<Inventariob>();
            while (_lector.Read())
            {
                Inventariob _datos = new Inventariob();
                _datos.id = _lector.GetInt64(0);
                _datos.id_producto = _lector.GetInt64(1);
                _datos.Cantidad = _lector.GetInt64(2);
                _datos.Precio = _lector.GetDecimal(3);
                _datos.id_proveedor = _lector.GetInt64(4);
                _datos.id_sexo = _lector.GetInt32(5);
                _datos.fecha_e = _lector.GetString(6);
                _datos.imagen = (byte[])_lector["imagen"]; ;
                _datos.descripcion = _lector.GetString(8);
                _datos.DataProducto = _lector.GetString(9);
                _datos.DataProveedor = _lector.GetString(10);
                _datos.Datasexo = _lector.GetString(11);
                lista.Add(_datos);

            }
            _con.Close();
            return lista;

        }


        public List<Inventariob> mostrar_inventario_hombres()
        {
            IDbConnection _con = Conexion.cnDB();
            _con.Open();
            SqlCommand _comando = new SqlCommand("buscar_inventario_hombres", _con as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            IDataReader _lector = _comando.ExecuteReader();
            List<Inventariob> lista = new List<Inventariob>();
            while (_lector.Read())
            {
                Inventariob _datos = new Inventariob();
                _datos.id = _lector.GetInt64(0);
                _datos.id_producto = _lector.GetInt64(1);
                _datos.Cantidad = _lector.GetInt64(2);
                _datos.Precio = _lector.GetDecimal(3);
                _datos.id_proveedor = _lector.GetInt64(4);
                _datos.id_sexo = _lector.GetInt32(5);
                _datos.fecha_e = _lector.GetString(6);
                _datos.imagen = (byte[])_lector["imagen"]; ;
                _datos.descripcion = _lector.GetString(8);
                _datos.DataProducto = _lector.GetString(9);
                _datos.DataProveedor = _lector.GetString(10);
                _datos.Datasexo = _lector.GetString(11);
                lista.Add(_datos);

            }
            _con.Close();
            return lista;

        }

        public List<Inventariob> ventas_top()
        {
            IDbConnection _con = Conexion.cnDB();
            _con.Open();
            SqlCommand _comando = new SqlCommand("ventas_top", _con as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            IDataReader _lector = _comando.ExecuteReader();
            List<Inventariob> lista = new List<Inventariob>();
            while (_lector.Read())
            {
                Inventariob _datos = new Inventariob();
                _datos.id = _lector.GetInt64(0);
                _datos.id_producto = _lector.GetInt64(1);
                _datos.Cantidad = _lector.GetInt64(2);
                _datos.Precio = _lector.GetDecimal(3);
                _datos.id_proveedor = _lector.GetInt64(4);
                _datos.id_sexo = _lector.GetInt32(5);
                _datos.fecha_e = _lector.GetString(6);
                _datos.imagen = (byte[])_lector["imagen"]; ;
                _datos.descripcion = _lector.GetString(8);
                _datos.DataProducto = _lector.GetString(9);
                _datos.DataProveedor = _lector.GetString(10);
                _datos.Datasexo = _lector.GetString(11);
                lista.Add(_datos);

            }
            _con.Close();
            return lista;

        }

    }
}
