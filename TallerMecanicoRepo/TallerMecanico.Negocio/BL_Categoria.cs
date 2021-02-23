using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TallerMecanico.Entidades;
using TallerMecanico.Datos;

namespace TallerMecanico.Negocio
{
    public class BL_Categoria
    {
        public List<Categoria> Listar()
        {
            DAO_Categoria dao_Categoria = new DAO_Categoria();
            return dao_Categoria.Listar();
        }

        public Categoria TraerPorId(int Id)
        {
            DAO_Categoria dao_Categoria = new DAO_Categoria();
            return dao_Categoria.TraerPorId(Id);
        }

        public int Insertar(Categoria categoria)
        {
            DAO_Categoria dao_categoria = new DAO_Categoria();
            return dao_categoria.Insertar(categoria);
        }

        public int Actualizar(Categoria categoria)
        {
            DAO_Categoria dao_categoria = new DAO_Categoria();
            return dao_categoria.Actualizar(categoria);
        }

        public int Eliminar(int Id)
        {
            DAO_Categoria dao_categoria = new DAO_Categoria();
            return dao_categoria.Eliminar(Id);
        }
    }
}
