using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EN;

namespace BL
{
     public class cargoBL
    {
        CargoDAL _dal = new CargoDAL();
        public int agregar_cargo(cargo en)
        {
            return _dal.agregar_cargo(en);
        }
        public List<cargo> mostrar_cargo()
        {
            return _dal.mostrar_cargo();
        }
    }
}
