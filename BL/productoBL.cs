using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EN;
using DAL;

namespace BL
{
     public class productoBL
    {
        ProductoDAL _dal = new ProductoDAL();

        public int agregar_producto(Producto pen)
        {
            return _dal.agregar_producto(pen);
        }

        public int actualizar_producto(Producto pen)
        {
            return _dal.actualizar_producto(pen);
        }
        public int eliminar_producto(Producto pen)
        {
            return _dal.eliminar_producto(pen);
        }
        public List<Producto> mostrar_producto()
        {
            return _dal.mostrar_producto();
        }

        public List<Producto> buscar_producto(Producto pen)
        {
            return _dal.buscar_producto(pen);
        }
    }
}
