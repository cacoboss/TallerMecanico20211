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
    public class DAO_Categoria
    {
        string _cadenaConexion;

        public string CadenaConexion
        {
            get
            {
                if(_cadenaConexion == null)
                {
                    _cadenaConexion =
                        ConfigurationManager.ConnectionStrings["Conex"].ConnectionString;
                }
                return _cadenaConexion;
            }
            set => _cadenaConexion = value;
        }

        public List<Categoria> Listar()
        {
            List<Categoria> lista = new List<Categoria>();

            using(SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ListarCategorias", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        int Id = (int)dr["Id"];
                        string Codigo = (string)dr["Codigo"];
                        string Nombre = (string)dr["Nombre"];
                        string Observacion = (string)dr["Observacion"];

                        Categoria c = new Categoria(Id, Codigo, Nombre, Observacion);
                        lista.Add(c);
                    }
                }
            }
            return lista;
        }
    
        public Categoria TraerPorId(int Id)
        {
            Categoria c = new Categoria();
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("TraerCategoriaPorId", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", Id);
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr != null && dr.HasRows)
                {
                    dr.Read();
                    int l_Id = (int)dr["Id"];
                    string l_Codigo = (string)dr["Codigo"];
                    string l_Nombre = (string)dr["Nombre"];
                    string l_Observacion = (string)dr["Observacion"];

                    c = new Categoria(l_Id, l_Codigo, l_Nombre, l_Observacion);
                }
            }
            return c;
        }
    
        public int Insertar(Categoria categoria)
        {
            int n = -1;
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("InsertarCategoria", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo", categoria.Codigo);
                cmd.Parameters.AddWithValue("@Nombre", categoria.Nombre);
                cmd.Parameters.AddWithValue("@Observacion", categoria.Observacion);
                n = cmd.ExecuteNonQuery();
            }
            
            return n;
        }

        public int Actualizar(Categoria categoria)
        {
            int n = -1;
            using(SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ActualizarCategoria", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", categoria.Id);
                cmd.Parameters.AddWithValue("@Codigo", categoria.Codigo);
                cmd.Parameters.AddWithValue("@Nombew", categoria.Nombre);
                cmd.Parameters.AddWithValue("@Observacion", categoria.Observacion);
                n = cmd.ExecuteNonQuery();
            }
            return n;
        }

        public int Eliminar (int Id)
        {
            int n = -1;
            using(SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("EliminarCategoria", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", Id);
                n = cmd.ExecuteNonQuery();
            }
            return n;
        }
    }
}
