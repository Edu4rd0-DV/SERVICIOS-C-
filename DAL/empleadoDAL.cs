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
    public class empleadoDAL
    {
        
            public int agregar_empleado(Empleado pen)
            {
                IDbConnection _com = Conexion.cnDB();
                _com.Open();
                SqlCommand _comando = new SqlCommand("agregar_empleado", _com as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@nombre", pen.nombre));
                _comando.Parameters.Add(new SqlParameter("@apellido", pen.apellido));
                _comando.Parameters.Add(new SqlParameter("@sexo", pen.sexo));
                _comando.Parameters.Add(new SqlParameter("@dui", pen.dui));
                _comando.Parameters.Add(new SqlParameter("@fecha_n", pen.fecha_n));
                _comando.Parameters.Add(new SqlParameter("@cargo", pen.cargo));
                _comando.Parameters.Add(new SqlParameter("@foto", pen.foto));
                _comando.Parameters.Add(new SqlParameter("@nick", pen.nick));
                _comando.Parameters.Add(new SqlParameter("@pass", pen.pass));
                int resultado = _comando.ExecuteNonQuery();
                _com.Close();
                return resultado;
            }


        public int actualizar_empleado(Empleado pen)
        {
            IDbConnection _com = Conexion.cnDB();
            _com.Open();
            SqlCommand _comando = new SqlCommand("agregar_empleado", _com as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@id", pen.id));
            _comando.Parameters.Add(new SqlParameter("@nombre", pen.nombre));
            _comando.Parameters.Add(new SqlParameter("@apellido", pen.apellido));
            _comando.Parameters.Add(new SqlParameter("@sexo", pen.sexo));
            _comando.Parameters.Add(new SqlParameter("@dui", pen.dui));
            _comando.Parameters.Add(new SqlParameter("@fecha_n", pen.fecha_n));
            _comando.Parameters.Add(new SqlParameter("@cargo", pen.cargo));
            _comando.Parameters.Add(new SqlParameter("@foto", pen.foto));
            _comando.Parameters.Add(new SqlParameter("@nick", pen.nick));
            int resultado = _comando.ExecuteNonQuery();
            _com.Close();
            return resultado;
        }


        public int eliminar_empleado(Empleado pen)
        {
            IDbConnection _com = Conexion.cnDB();
            _com.Open();
            SqlCommand _comando = new SqlCommand("eliminar_empleado", _com as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@id", pen.id));
            int resultado = _comando.ExecuteNonQuery();
            _com.Close();
            return resultado;
        }

        public List<Empleado> mostrar_empleado()
        {
            IDbConnection _con = Conexion.cnDB();
            _con.Open();
            SqlCommand _comando = new SqlCommand("mostrar_empleado", _con as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            IDataReader _lector = _comando.ExecuteReader();
            List<Empleado> lista = new List<Empleado>();
            while (_lector.Read())
            {
                Empleado _datos = new Empleado();
                _datos.id = _lector.GetInt64(0);
                _datos.nombre = _lector.GetString(1);
                _datos.apellido = _lector.GetString(2);
                _datos.sexo = _lector.GetInt32(3);
                _datos.dui = _lector.GetInt32(4);
                _datos.fecha_n = _lector.GetDateTime(5);
                _datos.cargo = _lector.GetInt32(6);
                _datos.foto = (byte[])_lector["foto"]; ;
                _datos.nick = _lector.GetString(8);
                _datos.pass = _lector.GetString(9);
                _datos.datasexo = _lector.GetString(10);
                _datos.datacargo = _lector.GetString(11);
                lista.Add(_datos);

            }
            _con.Close();
            return lista;

        }

        public int validar_empleado(Empleado pen)
        {
            int validar;
            using (IDbConnection _conn = Conexion.cnDB())
            {
                _conn.Open();
                SqlCommand _comando = new SqlCommand("validar_usuario", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@nick", pen.nick));
                _comando.Parameters.Add(new SqlParameter("@pass", pen.pass));
                _comando.Parameters.Add(new SqlParameter("@cargo", pen.cargo));
                IDataReader _lector = _comando.ExecuteReader();
                if (_lector.Read())
                    validar = 1;//Validación correcta
                else
                    validar = 0;//Validación inconrrecta
                _conn.Close();
            }
            return validar;
        }





    }
}
