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
    public class DAO_TipoTrabajador
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

        public TipoTrabajador TraerTipoPorID(int Id)
        {
            TipoTrabajador tipo = new TipoTrabajador();
            try
            {
                using(SqlConnection con = new SqlConnection(CadenaConexion))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("dbo.TipoTrabajador_TraerTipoPorID", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", Id);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if(dr != null && dr.HasRows)
                    {
                        tipo.NombreCargo = (string)dr["NombreCargo"];
                        tipo.DescripcionCargo = (string)dr["DescripcionCargo"];
                        tipo.Permisos = new bool[]
                        {
                            (bool)dr["Permiso_FichaTecnica"],
                            (bool)dr["Permiso_ListadoClientes"],
                            (bool)dr["Permiso_ListadoCompras"],
                            (bool)dr["Permiso_ListadoVentas"],
                            (bool)dr["Permiso_Facturas"],
                            (bool)dr["Permiso_Inventarios"],
                            (bool)dr["Permiso_CreacionUsuarios"]
                        };
                    }
                }
                
            }catch (Exception ex)
            {

            }
            return tipo;
        }
    }
}
