using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerMecanico.Entidades
{
    public class Trabajador
    {
        public long Cedula { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public long? Celular { get; set; }
        public int TipoTrabajador { get; set; }
        public int? IdentificadorCorreo { get; set; }

        // Constructores

        public Trabajador (long Cedula, 
            string Nombres,
            string Apellidos,
            long? Celular,
            int TipoTrabajador,
            int? IdentificadorCorreo)
        {
            this.Cedula = Cedula;
            this.Nombres = Nombres;
            this.Celular = Celular;
            this.TipoTrabajador = TipoTrabajador;
            this.IdentificadorCorreo = IdentificadorCorreo;
        }

        public Trabajador(long Cedula,
            string Nombres,
            string Apellidos,
            int TipoTrabajador)
            : this (Cedula, Nombres, 
                  Apellidos, null, TipoTrabajador, null)
        {

        }
    }
}
