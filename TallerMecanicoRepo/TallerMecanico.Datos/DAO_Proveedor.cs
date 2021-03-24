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
    public class DAO_Proveedor
    {



        string _cadenaConexion;
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




        public int Insertar(Proveedor proveedor)
        {
            int ID = -1;
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("dbo.SP_Proveedor_Insertar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NOMBRE", proveedor.NombreProveedor);
                    cmd.Parameters.AddWithValue("@DESCRIPCION", proveedor.DescripcionProveedor);
                    ID = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return ID;
        }

        public List<Proveedor> Listar()
        {
            List<Proveedor> lista = new List<Proveedor>();

            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_Proveedor_Listar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr != null && dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            Proveedor p = new Proveedor();
                            p.CodigoProveedor = (int) dr["CodigoProveedor"];
                            p.NombreProveedor =((string) dr["NombreProveedor"]) != null ? (string) dr["NombreProveedor"] : "Valor Nulo" ;
                            p.DescripcionProveedor = ((string) dr["DescripcionProveedor"]) != null ? (string) dr["DescripcionProveedor"] : "Valor Nulo";
                            lista.Add(p);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return lista;
        }

        public int Actualizar(Proveedor proveedor)
        {
            int ID = -1;

            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_Proveedor_Actualizar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", proveedor.CodigoProveedor);
                    cmd.Parameters.AddWithValue("@NOMBRE", proveedor.NombreProveedor);
                    cmd.Parameters.AddWithValue("@DESRCIPCION", proveedor.DescripcionProveedor);
                    ID = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return ID;
        }

        public Proveedor TraerPorID(int ID)
        {
            Proveedor proveedor = new Proveedor();

            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_Proveedor_TraerPorID", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ID);
                    SqlDataReader dr = cmd.ExecuteReader();



                    if (dr.HasRows)
                    {
                        dr.Read();
                        proveedor.CodigoProveedor = (int)dr["CodigoProveedor"];
                        proveedor.NombreProveedor = (string)dr["NombreProveedor"];
                        proveedor.DescripcionProveedor = (string)dr["DescripcionProveedor"];
                 
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return proveedor;
        }

        public int Eliminar(int ID)
        {

            int Identificador=-1;
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_Proveedor_Eliminar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ID);
                    Identificador = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
             
            }

            return Identificador;
        }
    }
}