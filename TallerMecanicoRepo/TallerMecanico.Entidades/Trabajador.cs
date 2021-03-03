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
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string CorreoElectronico { get; set; }
        public string Clave { get; set; }

        // Constructores

        public Trabajador (long Cedula, 
            string Nombres,
            string Apellidos,
            long? Celular,
            int TipoTrabajador,
            DateTime FechaCreacion,
            DateTime FechaModificacion,
            string Correo,
            string Clave)
        {
            this.Cedula = Cedula;
            this.Nombres = Nombres;
            this.Celular = Celular;
            this.TipoTrabajador = TipoTrabajador;
            this.FechaCreacion = FechaCreacion;
            this.FechaModificacion = FechaModificacion;
            this.CorreoElectronico = Correo;
            this.Clave = Clave;
        }

        public Trabajador() : this(0, "", "", null, 0, DateTime.Now, DateTime.Now, "", "")
        {

        }
    }
}
