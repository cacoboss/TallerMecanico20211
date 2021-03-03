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
    public class BL_TipoTrabajador
    {
        public TipoTrabajador TraerTipoTrabajadorPorID(int Id)
        {
            DAO_TipoTrabajador dao_tipo = new DAO_TipoTrabajador();
            return dao_tipo.TraerTipoPorID(Id);
        }
    }
}
