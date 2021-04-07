using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using TallerMecanico.Entidades;
using TallerMecanico.Datos;

namespace TallerMecanico.Negocio
{
     public class BL_Cliente
     {
        public List<Cliente> Listar()
        {
            DAO_Cliente dao_Cliente = new DAO_Cliente();
            return dao_Cliente.Listar();
        }

        public Cliente TraerPorId(int Id)
        {
            DAO_Cliente dao_Cliente = new DAO_Cliente();
            return dao_Cliente.TraerPorID(Id);
        }

        public int Insertar(Cliente cliente)
        {
            DAO_Cliente dao_Cliente = new DAO_Cliente();
            return dao_Cliente.Insertar(cliente);
        }

        public int Actualizar(Cliente cliente)
        {
            DAO_Cliente dao_Cliente = new DAO_Cliente();
            return dao_Cliente.Actualizar(cliente);
        }

        public int Eliminar(int Id)
        {
            DAO_Cliente dao_Cliente = new DAO_Cliente();
            return dao_Cliente.Eliminar(Id);
        }


    }
}
