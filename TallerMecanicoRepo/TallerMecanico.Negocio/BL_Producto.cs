using System.Collections.Generic;
using TallerMecanico.Datos;
using TallerMecanico.Entidades;

namespace TallerMecanico.Negocio
{
    public class BL_Producto
    {
        public int Insertar(Producto producto)
        {
            DAO_Producto dao = new DAO_Producto();
            return dao.Insertar(producto);
        }

        public int Actualizar(Producto producto)
        {
            DAO_Producto dao = new DAO_Producto();
            return dao.Actualizar(producto);
        }

        public int Eliminar(int ID)
        {
            DAO_Producto dao = new DAO_Producto();
            return dao.Eliminar(ID);
        }

        public Producto TraerPorID(int ID)
        {
            DAO_Producto dao = new DAO_Producto();
            return dao.TraerPorID(ID);
        }

        public List<Producto> Listar()
        {
            DAO_Producto dao = new DAO_Producto();
            return dao.Listar();
        }

        public List<Producto> BuscarPorNombre(string nombre)
        {
            return new DAO_Producto().BuscarPorNombre(nombre);
        }
    }

}