using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TallerMecanico.Entidades;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace TallerMecanico.Datos
{
    public class DAO_Trabajador
    {
        string _cadenaConexion = null;

        public string CadenaConexion
        {
            get
            {
                if (_cadenaConexion == null)
                {
                    _cadenaConexion =
                        ConfigurationManager.ConnectionStrings["Conex2"].ConnectionString;
                }
                return _cadenaConexion;
            }
            set => _cadenaConexion = value;
        }

        public Trabajador TraerPorCorreo(string correo, string clave)
        { 
            Trabajador trabajador = new Trabajador();
            try
            {
                using(SqlConnection con = new SqlConnection(CadenaConexion))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("dbo.Trabajador_TraerTrabajadorPorCorreo", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CORREO", correo);
                    cmd.Parameters.AddWithValue("@CLAVE", clave);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if(dr != null && dr.HasRows){
                        trabajador.Cedula = (long)dr["Cedula"];
                        trabajador.Nombres = (string)dr["Nombres"];
                        trabajador.Apellidos = (string)dr["Apellidos"];
                        trabajador.Celular = (long)dr["Celular"];
                        trabajador.TipoTrabajador = (int)dr["TipoTrabajador"];
                        trabajador.TipoTrabajador = (int)dr["TipoTrabajador"];
                        trabajador.CorreoElectronico = correo;
                        trabajador.Clave = clave;
                    }
                }
            }catch(Exception ex)
            {

            }
            return trabajador;
        }
    }
}
