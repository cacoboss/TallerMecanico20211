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
    public class BL_Trabajador
    {
        public Trabajador TraerTrabajadorPorCorreo(string correo, string clave)
        {
            DAO_Trabajador dao_trabajador = new DAO_Trabajador();
            return dao_trabajador.TraerPorCorreo(correo, clave);
        }

        public Trabajador TraerTrabajadorPorCedula(long cedula) {
            DAO_Trabajador dao = new DAO_Trabajador();
            return dao.TraerPorID(cedula);
        }
        
        public List<Trabajador> ListarTrabajadores() {
            DAO_Trabajador dao = new DAO_Trabajador();
            return dao.Listar();
        }

        public int InsertarTrabajador(Trabajador trabajador) {
            DAO_Trabajador dao = new DAO_Trabajador();
            return dao.Insertar(trabajador);
        }
        public int ActualizarTrabajador(Trabajador trabajador) {
            DAO_Trabajador dao = new DAO_Trabajador();
            return dao.Actualizar(trabajador);
        }

        public int EliminarTrabajador(long ID) {
            DAO_Trabajador dao = new DAO_Trabajador();
            return dao.Eliminar(ID);
        }
    }
}
