using System;

namespace TallerMecanico.Entidades
{
    public class Proveedor
    {
        public int CodigoProveedor { get; set; }
        public string NombreProveedor { get; set; }
        public string DescripcionProveedor { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}