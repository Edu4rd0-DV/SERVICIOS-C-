using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace EN
{
    [DataContract]
    public class Usuario
    {
        [DataMember (Order =1)]
        public Int64 Id { get; set; }
        [DataMember (Order =2)]
        public   string nombre { get; set; }
        [DataMember (Order =3)]
        public  string  apellido { get; set; }
        [DataMember(Order = 4)]
        public  int sexo { get; set; }
        [DataMember(Order = 5)]
        public  string correo { get; set; }
        [DataMember(Order = 6)]
        public  string contraseña  { get; set; }
        [DataMember(Order = 7)]
        public byte[] imagen { get; set; }

        [DataMember (Order =8)]
        public  string Datasexo { get; set; }
    
    }
}
