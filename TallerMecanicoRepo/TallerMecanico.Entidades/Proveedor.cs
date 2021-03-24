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


        public Proveedor(int id, string nombre,  string descripcion)
        {
            this.CodigoProveedor = id;
            this.NombreProveedor = nombre;
            this.DescripcionProveedor = descripcion;
        
        }

        public Proveedor()
        {
        }
    }
}