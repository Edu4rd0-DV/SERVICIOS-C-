using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EN;
using DAL;
namespace BL
{
    public class proveedorBL
    {
         proveedorDAL  _dal = new proveedorDAL();

        public int agregar_proveedor(proveedor pen)
        {
            return _dal.agregar_proveedor(pen);
        }

        public int actualizar_proveedor(proveedor pen)
        {
            return _dal.actualizar_proveedor(pen);

        }
        public int eliminar_proveedor(proveedor pen)
        {
            return _dal.eliminar_proveedor(pen);
        }
        public List<proveedor> mostrar_proveedor()
        {
            return _dal.mostrar_proveedor();
        }

        public List<proveedor> buscar_proveedor( proveedor pen)
        {
            return _dal.mostrar_proveedor_nombre(pen);
        }
    }
}
