using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EN;
using DAL;
namespace BL
{
      public class InventarioBL
    {
        InventarioDAL _dal = new InventarioDAL();

        public int agregar_inventario(Inventariob pen)
        {
            return _dal.agragar_inventario(pen);
        }

        public int actualizar_inventario(Inventariob pen)
        {
            return _dal.actualizar_inventario(pen);
        }
        public int elimina_inventario(Inventariob pen)
        {
            return _dal.eliminar_inventario(pen);
        }
        public List<Inventariob> mostrar_inventario()
        {
            return _dal.mostrar_inventario();
        }
    
        public List<Inventariob> buscar_inventario(Inventariob pen)
        {
            return _dal.buscar_inventario(pen);
        }

        public List<Inventariob> mostrar_inventario_id(Int64 pen)
        {
            return _dal.mostrar_inventario_id(pen);
        }

        public Inventariob Listar_Productos_carrito(Int64 pen)
        {
            return _dal.Listar_Productos_carrito(pen);
        }

        public  List <Inventariob> mostrar_inventario_mujeres()
        {
            return _dal.mostrar_inventario_mujeres();
        }

        public List<Inventariob> mostrar_inventario_hombres()
        {
            return _dal.mostrar_inventario_hombres();
        }

        public List<Inventariob> ventas_top()
        {
            return _dal.ventas_top();
        }
    }
}
