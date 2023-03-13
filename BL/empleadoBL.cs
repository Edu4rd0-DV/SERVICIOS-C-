using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EN;
namespace BL
{
    public class empleadoBL
    {
        empleadoDAL _dal = new empleadoDAL();

        public int agregar_empleado( Empleado en)
        {
            return _dal.agregar_empleado(en);
        }
        public int actualizar_empelados(Empleado en)
        {
            return _dal.actualizar_empleado(en);

        }
        public int eliminar_empleado(Empleado en)
        {
            return _dal.eliminar_empleado(en);
        }
        public List<Empleado> mostrar_empleados()
        {
            return _dal.mostrar_empleado();
        }
        public int validar_empleado(Empleado en)
        {
            return _dal.validar_empleado(en);
        }

    }
}
