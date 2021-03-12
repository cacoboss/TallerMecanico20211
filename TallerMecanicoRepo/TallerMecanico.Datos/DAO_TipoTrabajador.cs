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
                        dr.Read();
                        tipo.NombreCargo = (string)dr["NombreCargo"];
                        tipo.DescripcionCargo = (string)dr["DescripcionCargo"];
                        tipo.Permisos = new bool[7];
                        tipo.Permisos[0] = (bool) dr["Permiso_FichaTecnica"];
                        tipo.Permisos[1] = (bool) dr["Permiso_ListadoClientes"];
                        tipo.Permisos[2] = (bool) dr["Permiso_ListadoCompras"];
                        tipo.Permisos[3] = (bool) dr["Permiso_ListadoVentas"];
                        tipo.Permisos[4] = (bool) dr["Permiso_Facturas"];
                        tipo.Permisos[5] = (bool) dr["Permiso_Inventarios"];
                        tipo.Permisos[6] = (bool) dr["Permiso_CreacionUsuarios"];
                    }
                }
            }
                
            catch (Exception ex)
            {

            }
            return tipo;
        }
        
        public List<TipoTrabajador> Listar() {
            List<TipoTrabajador> lista = new List<TipoTrabajador>();
            using (SqlConnection con = new SqlConnection(CadenaConexion)) {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_TipoTrabajador_Listar", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read()) {
                    TipoTrabajador tipo = new TipoTrabajador();
                    tipo.NombreCargo = (string) dr["NombreCargo"];
                    tipo.CodigoTrabajador = (int) dr["CodigoTrabajador"];
                    tipo.DescripcionCargo = (string) dr["DescripcionCargo"];
                    tipo.Permisos = new bool[7];
                    tipo.Permisos[0] = (bool) dr["Permiso_FichaTecnica"];
                    tipo.Permisos[1] = (bool) dr["Permiso_ListadoClientes"];
                    tipo.Permisos[2] = (bool) dr["Permiso_ListadoCompras"];
                    tipo.Permisos[3] = (bool) dr["Permiso_ListadoVentas"];
                    tipo.Permisos[4] = (bool) dr["Permiso_Facturas"];
                    tipo.Permisos[5] = (bool) dr["Permiso_Inventarios"];
                    tipo.Permisos[6] = (bool) dr["Permiso_CreacionUsuarios"];
                    lista.Add(tipo);
                }
            }

            return lista;
        }
    }
}
