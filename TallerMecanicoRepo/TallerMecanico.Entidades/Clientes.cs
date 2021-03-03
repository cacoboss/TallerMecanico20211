using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerMecanico.Entidades
{
    public class Clientes
    {

        int _id;
        DateTime _fechaCreacion;
        DateTime _fechaModificacion;
        string _nombre;
        string _apellido;
        string _direccion;
        string _Telefono;
        string _email;


        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string Nombre{ get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public Clientes(int Id,DateTime FechaCreacion,DateTime FechaModificacion, string Nombre, string Apellido, 
                        string Direccion, string Telefono, string Email)
        {
            this._id = Id;
            this._fechaCreacion = FechaCreacion;
            this._fechaModificacion = FechaModificacion;
            this._nombre = Nombre;
            this._apellido = Apellido;
            this._direccion = Direccion;
            this._Telefono = Telefono;
            this._email = Email;
        }

        public Clientes()
        {
        }
    }
}
