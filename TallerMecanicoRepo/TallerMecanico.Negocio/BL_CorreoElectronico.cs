using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TallerMecanico.Entidades;
using TallerMecanico.Datos;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace TallerMecanico.Negocio
{
    public class BL_CorreoElectronico
    {
        public int TraerPorCorreoClave(CorreoElectronico email)
        {
            DAO_CorreoElectronico dao_correo = new DAO_CorreoElectronico();
            return dao_correo.TraerPorCorreoClave(email.DireccionCorreoElectronico, email.Contraseña);
        }
    }
}
