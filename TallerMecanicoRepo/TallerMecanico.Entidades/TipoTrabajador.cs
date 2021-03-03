using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerMecanico.Entidades
{
    public class TipoTrabajador
    {
        public int CodigoTrabajador { get; set; }
        public string NombreCargo { get; set; }
        public string DescripcionCargo { get; set; }
        public bool[] Permisos { get; set; } = new bool[7];
            // [0] => FichaTécnica.
            // [1] => ListadoClientes.
            // [2] => ListadoCompras.
            // [3] => ListadoVentas.
            // [4] => Facturas.
            // [5] => Inventarios.
            // [6] => CreaciónUsuarios.

        // Constructores
        public TipoTrabajador(string NombreCargo, 
            string DescripcionCargo,
            bool[] Permisos)
        {
            this.NombreCargo = NombreCargo;
            this.DescripcionCargo = DescripcionCargo;
            this.Permisos = Permisos;
        }

        public TipoTrabajador(string NombreCargo, bool[] Permisos)
            : this (NombreCargo, "", Permisos)
        {
            
        }
        public TipoTrabajador(string NombreCargo)
        {
            this.NombreCargo = NombreCargo;
            this.DescripcionCargo = "";
            this.Permisos = new bool[7] {false, false, false,
                    false, false, false, false};
        }
        public TipoTrabajador() : this("")
        {

        }
    }
}
