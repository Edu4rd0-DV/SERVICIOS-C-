using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EN;
using DAL;

namespace BL
{
    public class tipoBL
    {
       tipoDAL _dal = new tipoDAL();

        public int agregar_tipo(tipo pen)
        {
            return _dal.agragar_tipo(pen);
        }

        public List<tipo> mostrar_tipo()
        {
            return _dal.mostrar_tipo();
        }

        public int actualizar_tipo(tipo pen)
        {
            return _dal.actualizar_tipo(pen);
        }

        public int eliminar_tipo(tipo pen)
        {
            return _dal.eliminar_tipo(pen);
        }

        public  List<tipo> buscar_tipo(tipo pen)
        {
            return _dal.buscar_tipo(pen);
        }
    }
}
