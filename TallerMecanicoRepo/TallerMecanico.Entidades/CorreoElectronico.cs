using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerMecanico.Entidades
{
    public class CorreoElectronico
    {
        public string DireccionCorreoElectronico { get; set; }

        public string Contraseña { get; set; }

        public long CedulaTrabajador { get; set; }

        public int identificadorCorreo { get; set; }

        // ############# Constructores
        public CorreoElectronico (string dirEmail, string password, long id, int id_email)
        {
            DireccionCorreoElectronico = dirEmail;
            Contraseña = password;
            CedulaTrabajador = id;
            identificadorCorreo = id_email;
        }
        public CorreoElectronico(string dirEmail, string password, long id )
        {
            DireccionCorreoElectronico = dirEmail;
            Contraseña = password;
            CedulaTrabajador = id;
        }
        public CorreoElectronico(string dirEmail, string password)
        {
            DireccionCorreoElectronico = dirEmail;
            Contraseña = password;
        }
    }
}
