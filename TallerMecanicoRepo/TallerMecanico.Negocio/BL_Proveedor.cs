using System.Collections.Generic;

using TallerMecanico.Entidades;
using TallerMecanico.Datos;

namespace TallerMecanico.Negocio
{
    public class BL_Proveedor
    {
        public List<Proveedor> Listar()
        {
            DAO_Proveedor dao = new DAO_Proveedor();
            return dao.Listar();
        }

        public Proveedor TraerPorID(int ID)
        {
            DAO_Proveedor dao = new DAO_Proveedor();
            return dao.TraerPorID(ID);
        }

        public int Insertar(Proveedor p)
        {
            DAO_Proveedor dao = new DAO_Proveedor();
            return dao.Insertar(p);
        }

        public int Actualizar(Proveedor p)
        {
            DAO_Proveedor dao = new DAO_Proveedor();
            return dao.Actualizar(p);
        }

        public int Eliminar(int ID)
        {
            DAO_Proveedor dao = new DAO_Proveedor();
            return dao.Eliminar(ID);
        }
    }
}