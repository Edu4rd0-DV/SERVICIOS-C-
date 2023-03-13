using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace EN
{
    [DataContract]
    public class sexo
    {
        [DataMember (Order =1)]
        public int id  { get; set; }

        [DataMember(Order =2)]
        public  string  nombre { get; set; }

    }
}
