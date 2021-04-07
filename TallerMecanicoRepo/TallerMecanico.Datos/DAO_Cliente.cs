using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TallerMecanico.Entidades;
using TallerMecanico.Datos;


using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace TallerMecanico.Datos
{
    public class DAO_Cliente
    {

        string _cadenaConexion;
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




        public int Insertar(Cliente cliente)
        {
            int ID = -1;
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("InsertarCliente", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NOMBRES", cliente.Nombres);
                    cmd.Parameters.AddWithValue("@APELLIDOS", cliente.Apellidos);
                    cmd.Parameters.AddWithValue("@DIRECCION", cliente.Direccion);
                    cmd.Parameters.AddWithValue("@TELEFONO", cliente.Telefono);
                    cmd.Parameters.AddWithValue("@EMAIL", cliente.Email);


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

        public List<Cliente> Listar()
        {
            List<Cliente> lista = new List<Cliente>();

            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("ListarClientes", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            Cliente cliente = new Cliente();
                            cliente.CodigoCliente = (int)dr["CodigoCliente"];
                            cliente.Nombres = ((string)dr["Nombres"]);
                            cliente.Apellidos = ((string)dr["Apellidos"]);
                            cliente.Direccion = ((string)dr["Direccion"]);
                            cliente.Email = ((string)dr["EMAIL"]);
                            lista.Add(cliente);

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

        public int Actualizar(Cliente cliente)
        {
            int ID = -1;

            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("ActualizarCliente", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", cliente.CodigoCliente);
                    cmd.Parameters.AddWithValue("@NOMBRES", cliente.Nombres);
                    cmd.Parameters.AddWithValue("@APELLIDOS", cliente.Apellidos);
                    cmd.Parameters.AddWithValue("@DIRECCION", cliente.Direccion);
                    cmd.Parameters.AddWithValue("@TELEFONO", cliente.Telefono);
                    cmd.Parameters.AddWithValue("@EMAIL", cliente.Email);


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

        public Cliente TraerPorID(int ID)
        {
            Cliente cliente = new Cliente();

            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("TraerClientePorId", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ID);
                    SqlDataReader dr = cmd.ExecuteReader();



                    if (dr.HasRows)
                    {
                        dr.Read();
                        cliente.CodigoCliente = (int)dr["CodigoCliente"];
                        cliente.Nombres = (string)dr["Nombres"];
                        cliente.Apellidos = (string)dr["Apellidos"];
                        cliente.Direccion = (string)dr["Direccion"];
                        cliente.Telefono = (long)dr["Telefono"];
                        cliente.Email = (string)dr["Email"];
                       
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return cliente;
        }

        public int Eliminar(int ID)
        {

            int Identificador = -1;
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("EliminarCliente", con);
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
