using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EN;
namespace BL
{
     public class sexoBL
    {
        sexoDAL _dal = new sexoDAL();

        public int agregar_sexo (sexo en)
        {
            return _dal.agregar_sexo(en);
        }

        public List<sexo> mostrar_sexo()
        {
            return _dal.mostrar_sexo();
        }
    }
}
