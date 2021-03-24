using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using TallerMecanico.Entidades;

namespace TallerMecanico.Datos
{
    public class DAO_ProveedorProductos
    {
        string _cadenaConexion=null;

        public string CadenaConexion
        {
            get
            {
                if (_cadenaConexion == null)
                {
                    _cadenaConexion = ConfigurationManager.
                        ConnectionStrings["Conex"].ConnectionString;
                }
                return _cadenaConexion;
            }
            set { _cadenaConexion = value; }
        }

        public List<ProveedorProductos> Listar()
        {

            List<ProveedorProductos> lista = new List<ProveedorProductos>();

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_ListarProveedorProducto", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ProveedorProductos ProPro = new ProveedorProductos();
                        ProPro.Consecutivo = (int)dr["Consecutivo"];
                        ProPro.CodigoProveedor = (int)dr["CodigoProveedor"];
                        ProPro.CodigoProducto = (int)dr["CodigoProducto"];
                        lista.Add(ProPro);

                    }
                }
            }
            return lista;
        }



        public ProveedorProductos TraerPorId(int ID)
        {
            ProveedorProductos ProPro = new ProveedorProductos();
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_TraerProductoProveedorPorId", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ID);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if ( dr.HasRows)
                    {
                        dr.Read();
                        ProPro.Consecutivo = ID;
                        ProPro.CodigoProveedor = (int)dr["CodigoProveedor"];
                        ProPro.CodigoProducto = (int)dr["CodigoProducto"];
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;

            }
            return ProPro;
        }





        public int Insertar(ProveedorProductos proveedorproductos)
        {
            int n = -1;
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_ProveedorProducto_Insertar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CODIGOPRODUCTO", proveedorproductos.CodigoProducto);
                    cmd.Parameters.AddWithValue("@CODIGOPROVEEDOR", proveedorproductos.CodigoProveedor);
                    n = cmd.ExecuteNonQuery();

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
            return n;
        }

        public int Actualizar(ProveedorProductos proveedorproductos)
        {
            int n = -1;
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_ProveedorProducto_Actualizar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", proveedorproductos.Consecutivo);
                    cmd.Parameters.AddWithValue("@CODIGOPRODUCTO", proveedorproductos.CodigoProducto);
                    cmd.Parameters.AddWithValue("@CODIGOPROVEEDOR", proveedorproductos.CodigoProveedor);


                    n = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }

            return n;
        }

        public int Eliminar(int Id)
        {
            int n = -1;
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_EliminarProductoProveedor", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", Id);
                    n = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

            }
            return n;
        }

    }
}
