using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace EN
{
    [DataContract]
    public class proveedor
    {
        [DataMember(Order = 1)]
        public Int64 Id  { get; set; }
        [DataMember (Order =2)]
        public  string nombre  { get; set; }
        [DataMember(Order =3)]
        public string contacto { get; set; }
        [DataMember (Order =4)]
        public  string direcion { get; set; }
    }
}
