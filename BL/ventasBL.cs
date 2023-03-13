using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EN;

namespace BL
{
     public class ventasBL
    {
        ventasDAL _dal = new ventasDAL();
        public int agregar_venta(ventas en)
        {
            return _dal.agragar_venta(en);
        }
        
        public List<ventas> mostrar_ventas()
        {
            return _dal.mostrar_ventas();
        }

        public List<ventas>buscar_venta(ventas en)
        {
            return _dal.buscar_ventas(en);
        }
    }
}
