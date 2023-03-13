using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EN;
namespace BL
{
     public class UsuarioBL
    {
        UsuarioDAL _dal = new UsuarioDAL();

        public int agregar_usuario(Usuario pen)
        {
            return _dal.agragar_usuario(pen);
        }

        public int elimina_usuario(Usuario pen)
        {
            return _dal.eliminar_usuario(pen);
        }

     /*   public List<Usuario> buscar_usuario(Usuario pen)
        {
            return _dal.buscar_usuario(pen);
        }*/

        public List<Usuario> mostrar_usuario()
        {
            return _dal.mostrar_usuario();
        }

        public int validar_usuario(Usuario pen)
        {
            return _dal.validar_usuario(pen);
        }

        public List<Usuario>mostrar_usuario_correo(Usuario pen)
        {
            return _dal.mostrar_usuario_correo(pen);
        }

        public List<Usuario> mostrar_usuario_id(Int64 id)
        {
            return _dal.mostrar_usuario_id(id);
        }

        public int actualizar_usuario (Usuario pen)
        {
            return _dal.actualizar_usuario(pen);
        }
    }
}
