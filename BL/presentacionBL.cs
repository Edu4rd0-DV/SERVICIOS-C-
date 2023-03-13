using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EN;
using DAL;
namespace BL
{
     public class presentacionBL
    {
        presentacionDAL _dal = new presentacionDAL();

        public int agregar_presentacion(presentacion pen)
        {
            return _dal.agragar_presentacion(pen);
        }

        public List<presentacion> mostrar_presentacion()
        {
            return _dal.mostrar_presentacion();
        }

        public int actualizar_presentacion(presentacion pen)
        {
            return _dal.actualizar_presentacion(pen);
        }
        public int eliminar_presentacion(presentacion pen)
        {
            return _dal.eliminar_presentacion(pen);
        }

        public  List<presentacion> buscar_presentacion(presentacion pen)
        {
            return _dal.buscar_presentacion(pen);
        }
    }
}
