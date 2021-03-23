using System;

namespace TallerMecanico.Entidades {
    public class DetalleCompra {
        
        public string NombreProducto { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public float ValorUnitario { get; set; }
        public float ValorTotal { get; set; }

        public DateTime FechaCompra { get; set; }
    }
}