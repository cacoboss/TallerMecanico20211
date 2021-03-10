using System;

namespace TallerMecanico.Entidades
{
    public class Producto
    {
        public int CodigoProducto { get; set; }
        public int CodigoCategoria { get; set; }
        public string DescripcionProducto { get; set; } 
        public float ValorUnitarioCompra { get; set; }
        public float ValorUnitarioVenta { get; set; }
        public string Marca { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}