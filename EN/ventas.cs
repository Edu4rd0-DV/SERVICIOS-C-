using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace EN
{ [DataContract]
    public  class ventas
    {
        [DataMember]
        public Int64 id  { get; set; }

        [DataMember]
        public Int64 id_producto { get; set; }

        [DataMember]
        public Int64 id_usuario { get; set; }

        [DataMember]
        public decimal precio { get; set; }

        [DataMember]
        public Int64 cantidad { get; set; }
        [DataMember]
        public decimal total { get; set; }
        [DataMember]
        public string direccion { get; set; }
        [DataMember]
        public string nombre { get; set; }
        [DataMember]
        public string correo { get; set; }
    }
}
