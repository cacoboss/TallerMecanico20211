using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using TallerMecanico.Entidades;
using TallerMecanico.Datos;


namespace TallerMecanico.Negocio
{
   public class BL_ProveedorProductos
    {

        public List<ProveedorProductos> Listar()
        {
            DAO_ProveedorProductos dao_proveedorProductos = new DAO_ProveedorProductos();
            return dao_proveedorProductos.Listar();
        }

        public ProveedorProductos TraerPorId(int Id)
        {
            DAO_ProveedorProductos dao_proveedorproductos = new DAO_ProveedorProductos();
            return dao_proveedorproductos.TraerPorId(Id);
        }


        public int Insertar(ProveedorProductos proveedorProductos)
        {
            DAO_ProveedorProductos dao_proveedorproductos = new DAO_ProveedorProductos();
            return dao_proveedorproductos.Insertar(proveedorProductos);
        }

        public int Actualizar(ProveedorProductos proveedorProductos)
        {
            DAO_ProveedorProductos dao_proveedorproductos = new DAO_ProveedorProductos();
            return dao_proveedorproductos.Actualizar(proveedorProductos);
        }

        public int Eliminar(int Id)
        {
            DAO_ProveedorProductos dao_proveedorproductos = new DAO_ProveedorProductos();
            return dao_proveedorproductos.Eliminar(Id);
        }
    }
}
