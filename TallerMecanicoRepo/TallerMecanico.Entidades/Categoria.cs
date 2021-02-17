using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerMecanico.Entidades
{
    public class Categoria
    {
        int _id;
        string _codigo;
        string _nombre;
        string _observacion;

        public int Id { get => _id; set => _id = value; }
        public string Codigo { get => _codigo; set => _codigo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Observacion { get => _observacion; set => _observacion = value; }

        // ############# Constructores
        public Categoria(int id, string codigo, string nombre, string observacion)
        {
            _id = id;
            _codigo = codigo;
            _nombre = nombre;
            _observacion = observacion;
        }
        public Categoria(int id, string codigo, string nombre) : this (id, codigo, nombre, "")
        {
        }
        public Categoria(int id, string nombre) : this (id, "", nombre, "")
        {
        }
        public Categoria() : this (0, "", "", "")
        {
        }
    }
}
