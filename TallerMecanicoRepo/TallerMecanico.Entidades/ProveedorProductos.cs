using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerMecanico.Entidades
{
        public  class ProveedorProductos{
        public int Consecutivo { get; set; }
        public int CodigoProveedor { get; set; }
        public int CodigoProducto { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }


        public ProveedorProductos()
        {

        }


        }
}
