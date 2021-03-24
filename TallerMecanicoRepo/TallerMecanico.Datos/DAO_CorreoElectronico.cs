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
    public class DAO_CorreoElectronico
    {
        string _cadenaConexion = null;

        public string CadenaConexion
        {
            get
            {
                if (_cadenaConexion == null)
                {
                    _cadenaConexion =
                        ConfigurationManager.ConnectionStrings["Conex"].ConnectionString;
                }
                return _cadenaConexion;
            }
            set => _cadenaConexion = value;
        }

        public int TraerPorCorreoClave(string correo, string clave)
        {
            int resultado = -1;

            try
            {
                using(SqlConnection con = new SqlConnection(CadenaConexion))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("dbo.CorreoElectronico_InicioSesion", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CORREOUSADO", correo);
                    cmd.Parameters.AddWithValue("@CLAVEUSADA", clave);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if(dr.HasRows && dr != null)
                    {
                        dr.Read();
                        resultado = (int)dr["IdentificadorCorreo"];
                    }
                }
            }catch (Exception ex)
            {

            }
            return resultado;
        }
    }
}
