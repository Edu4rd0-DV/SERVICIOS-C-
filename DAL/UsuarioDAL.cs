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
     public class UsuarioDAL
    {
        public int agragar_usuario(Usuario pen)
        {
            IDbConnection _com =  Conexion.cnDB();
            _com.Open();
            SqlCommand _comando = new SqlCommand("agregar_usuario", _com as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@nombre", pen.nombre));
            _comando.Parameters.Add(new SqlParameter("@apellido", pen.apellido));
            _comando.Parameters.Add(new SqlParameter("@sexo", pen.sexo));
            _comando.Parameters.Add(new SqlParameter("@correo", pen.correo));
            _comando.Parameters.Add(new SqlParameter("@contraseña", pen.contraseña));
            _comando.Parameters.Add(new SqlParameter("@imagen", pen.imagen));

            int resultado = _comando.ExecuteNonQuery();
            _com.Close();

            return resultado;
        }

        public int actualizar_usuario(Usuario pen)
        {
            IDbConnection _com = Conexion.cnDB();
            _com.Open();
            SqlCommand _comando = new SqlCommand("actualizar_usuario", _com as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@id", pen.Id));
            _comando.Parameters.Add(new SqlParameter("@nombre", pen.nombre));
            _comando.Parameters.Add(new SqlParameter("@apellido", pen.apellido));
            _comando.Parameters.Add(new SqlParameter("@sexo", pen.sexo));
            _comando.Parameters.Add(new SqlParameter("@correo", pen.correo));
            _comando.Parameters.Add(new SqlParameter("@imagen", pen.imagen));

            int resultado = _comando.ExecuteNonQuery();
            _com.Close();

            return resultado;
        }

        // eliminar----
        public int eliminar_usuario(Usuario pen)
        {
            IDbConnection _com = Conexion.cnDB();
            _com.Open();
            SqlCommand _comando = new SqlCommand("eliminar_usuario", _com as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@id", pen.Id));
            int resultado = _comando.ExecuteNonQuery();
            _com.Close();
            return resultado;
        }

  /*      public List<Usuario> buscar_usuario(Usuario pen)
        {
            IDbConnection _con = Conexion.cnDB();
            _con.Open();
            SqlCommand _comando = new SqlCommand("buscar_usuario", _con as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@nick", pen.nick));
            IDataReader _lector = _comando.ExecuteReader();
            List<Usuario> lista = new List<Usuario>();
            while (_lector.Read())
            {
                Usuario _datos = new Usuario();
                _datos.Id = _lector.GetInt64(0);
                _datos.nick = _lector.GetString(1);
                _datos.pass = _lector.GetString(2);
                lista.Add(_datos);

            }
            _con.Close();
            return lista;

         } */

        public List<Usuario> mostrar_usuario()
        {
            IDbConnection _con = Conexion.cnDB();
            _con.Open();
            SqlCommand _comando = new SqlCommand("mostrar_usuario", _con as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            IDataReader _lector = _comando.ExecuteReader();
            List<Usuario> lista = new List<Usuario>();
            while (_lector.Read())
            {
                Usuario _datos = new Usuario();
                _datos.Id = _lector.GetInt64(0);
                _datos.nombre = _lector.GetString(1);
                _datos.apellido = _lector.GetString(2);
                _datos.sexo = _lector.GetInt32(3);
                _datos.correo = _lector.GetString(4);
                _datos.contraseña = _lector.GetString(5);
                _datos.imagen = (byte[])_lector["imagen"]; ;
                _datos.Datasexo = _lector.GetString(7);

                lista.Add(_datos);

            }
            _con.Close();
            return lista;

        }

        public int validar_usuario(Usuario pen)
        {
            Usuario _us = new Usuario();
            int validar;
            using (IDbConnection _conn = Conexion.cnDB())
            {
                _conn.Open();
                SqlCommand _comando = new SqlCommand("validar_user", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@correo", pen.correo));
                _comando.Parameters.Add(new SqlParameter("@contraseña", pen.contraseña));
                IDataReader _lector = _comando.ExecuteReader();
                if (_lector.Read())
                {

                    validar = 1;//Validación correcta

                    
                }
                else
                    validar = 0;//Validación inconrrecta
                _conn.Close();
            }
            return validar;
        }

        public List<Usuario> mostrar_usuario_correo(Usuario pen)
        {
            IDbConnection _con = Conexion.cnDB();
            _con.Open();
            SqlCommand _comando = new SqlCommand("mostrar_usuario_hotmail", _con as SqlConnection);
            _comando.Parameters.Add(new SqlParameter("@correo", pen.correo));
            _comando.CommandType = CommandType.StoredProcedure;
            IDataReader _lector = _comando.ExecuteReader();
            List<Usuario> lista = new List<Usuario>();
            while (_lector.Read())
            {
                Usuario _datos = new Usuario();
                _datos.Id = _lector.GetInt64(0);
                _datos.nombre = _lector.GetString(1);
                _datos.apellido = _lector.GetString(2);
                _datos.sexo = _lector.GetInt32(3);
                _datos.correo = _lector.GetString(4);
                _datos.contraseña = _lector.GetString(5);
                _datos.imagen = (byte[])_lector["imagen"]; ;
                _datos.Datasexo = _lector.GetString(7);

                lista.Add(_datos);

            }
            _con.Close();
            return lista;

        }

        public List<Usuario> mostrar_usuario_id(Int64 id)
        {
            IDbConnection _con = Conexion.cnDB();
            _con.Open();
            SqlCommand _comando = new SqlCommand("mostrar_usuario_id", _con as SqlConnection);
            _comando.Parameters.Add(new SqlParameter("@id", id));
            _comando.CommandType = CommandType.StoredProcedure;
            IDataReader _lector = _comando.ExecuteReader();
            List<Usuario> lista = new List<Usuario>();
            while (_lector.Read())
            {
                Usuario _datos = new Usuario();
                _datos.Id = _lector.GetInt64(0);
                _datos.nombre = _lector.GetString(1);
                _datos.apellido = _lector.GetString(2);
                _datos.sexo = _lector.GetInt32(3);
                _datos.correo = _lector.GetString(4);
                _datos.contraseña = _lector.GetString(5);
                _datos.imagen = (byte[])_lector["imagen"]; ;
                _datos.Datasexo = _lector.GetString(7);

                lista.Add(_datos);

            }
            _con.Close();
            return lista;

        }
    }
}
