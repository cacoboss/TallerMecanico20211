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

        public List<Clientes> Listar()
        {
            DAO_Cliente dao_Cliente = new DAO_Cliente();
            return dao_Cliente.Listar();
        }

        public Clientes TraerPorId(int Id)
        {
            DAO_Cliente dao_cliente = new DAO_Cliente();
            return dao_cliente.TraerPorId(Id);
        }

        public int Insertar(Clientes cliente)
        {
            DAO_Cliente dao_cliente = new DAO_Cliente();
            return dao_cliente.InsertarClientes(cliente);
        }

        public int Actualizar(Clientes cliente)
        {
            DAO_Cliente dao_cliente = new DAO_Cliente();
            return dao_cliente.ActualizarClientes(cliente);
        }

        public int Eliminar(int Id)
        {
            DAO_Cliente dao_cliente = new DAO_Cliente();
            return dao_cliente.EliminarCliente(Id);
        }
    }
}
