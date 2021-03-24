using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using TallerMecanico.Entidades;

namespace TallerMecanico.Datos
{
    public class DAO_Producto
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

        public int Insertar(Producto producto)
        {
            int n = -1;
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_Productos_Insertar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CODIGOCAT", producto.CodigoCategoria);
                    cmd.Parameters.AddWithValue("@DESCRIPCION", producto.DescripcionProducto);
                    cmd.Parameters.AddWithValue("@VALORCOMPRA", producto.ValorUnitarioCompra);
                    cmd.Parameters.AddWithValue("@MARCA", producto.Marca);
                    cmd.Parameters.AddWithValue("@NOMBRE", producto.Nombre);
                    cmd.Parameters.AddWithValue("@PROVEEDOR", producto.CodigoProveedor);
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

        public int Actualizar(Producto producto)
        {
            int n = -1;
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_Productos_Actualizar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", producto.CodigoProducto);
                    cmd.Parameters.AddWithValue("@CODIGOCAT", producto.CodigoCategoria);
                    cmd.Parameters.AddWithValue("@DESCRIPCION", producto.DescripcionProducto);
                    cmd.Parameters.AddWithValue("@VALORCOMPRA", producto.ValorUnitarioCompra);
                    cmd.Parameters.AddWithValue("@MARCA", producto.Marca);
                    cmd.Parameters.AddWithValue("@NOMBRE", producto.Nombre);
                    cmd.Parameters.AddWithValue("@PROVEEDOR", producto.CodigoProveedor);
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

        public int Eliminar(int ID)
        {
            int n = -1;
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_Productos_Eliminar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ID);
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

        public Producto TraerPorID(int ID)
        {
            Producto producto = new Producto();
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_Productos_TraerPorID", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ID);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dr.Read();
                        producto.CodigoProducto = ID;
                        producto.Nombre = (string) dr["NombreProducto"];
                        producto.CodigoCategoria = (int) dr["CodigoCategoria"];
                        producto.Marca = (string) dr["Marca"];
                        producto.DescripcionProducto = (string) dr["DescripcionProducto"];
                        producto.ValorUnitarioCompra = (float) dr["ValorUnitarioCompra"];
                        producto.CodigoProveedor = (int)dr["CodigoProvedor"];

                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }

            return producto;
        }

        public List<Producto> Listar()
        {
            List<Producto> lista = new List<Producto>();

            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_Productos_Listar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            Producto producto = new Producto();
                            producto.CodigoProducto = (int) dr["CodigoProducto"];
                            producto.Nombre = (string) dr["NombreProducto"];
                            producto.CodigoCategoria = (int) dr["CodigoCategoria"];
                            producto.CodigoProveedor = (int)dr["CodigoProveedor"];
                            producto.Marca = (string) dr["Marca"];
                            producto.DescripcionProducto = (string) dr["DescripcionProducto"];
                            producto.ValorUnitarioCompra = (float) dr["ValorUnitarioCompra"];
                            lista.Add(producto);
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }

            return lista;
        }
    }
}