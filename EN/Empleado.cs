using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace EN
{
    [DataContract]
    public class Empleado
    {
        [DataMember(Order = 1)]
        public Int64 id { get; set; }
        [DataMember(Order = 2)]
        public string nombre { get; set; }
        [DataMember(Order = 3)]
        public string apellido { get; set; }
        [DataMember(Order =4)]
        public int sexo { get; set; }
        [DataMember (Order =5)]
        public int dui { get; set; }
        [DataMember (Order =6)]
        public DateTime fecha_n   { get; set; }
        [DataMember(Order =7)]
        public int cargo { get; set; }
        [DataMember(Order =8)]
        public byte[] foto { get; set; }
        [DataMember (Order =9)]
        public string  nick { get; set; }
        [DataMember (Order =10)]
        public string  pass { get; set; }
        [DataMember (Order =11)]
        public string datasexo { get; set; }
        [DataMember (Order =12)]
        public string  datacargo { get; set; }


    }
}
