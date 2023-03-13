using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace EN
{
    [DataContract]
    public class Producto
    {
        [DataMember(Order = 1)]
        public Int64 id { get; set; }
        [DataMember(Order = 2)]
        public string nombre { get; set; }
        [DataMember(Order = 3)]
        public Int64 id_tipo { get; set; }
        [DataMember(Order = 4)]
        public Int64 id_presentacion { get; set; }
        [DataMember(Order = 5)]
        public string Datatipo { get; set; }
        [DataMember(Order = 6)]
        public string DataPresentacion { get; set; }

        
    }
}
