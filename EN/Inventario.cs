using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace EN
{
    [DataContract]
    public  class Inventariob
    {
        [DataMember (Order =1)]
        public Int64 id { get; set; }
        [DataMember (Order =2)]
        public  Int64  id_producto { get; set; }
        [DataMember (Order =3)]
        public  Int64  Cantidad { get; set; }
        [DataMember (Order =4)]
        public  decimal Precio { get; set; }
        [DataMember (Order =5)]
        public  Int64  id_proveedor { get; set; }
        [DataMember (Order =6)]
        public   int id_sexo { get; set; }
        [DataMember (Order =7)]
        public   string  fecha_e { get; set; }
        [DataMember (Order =8)]
        public byte[] imagen { get; set; }

        [DataMember(Order = 9)]
        public string descripcion { get; set; }

        [DataMember (Order =10)]
        public  string DataProducto { get; set; }

        [DataMember (Order =11)]
        public string DataProveedor { get; set; }

        [DataMember (Order =12)]
        public string Datasexo { get; set; }
                                           //--------------------------------------------------------------------------------------------



    }
}
