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
                        ConfigurationManager.ConnectionStrings["Conex"].ConnectionString;
                }
                return _cadenaConexion;
            }
            set => _cadenaConexion = value;
        }

        public List<Clientes> Listar()
        {
            List<Clientes> lista = new List<Clientes>();

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ListarClientes", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())

                    {
                        int CodigoCliente = (int)dr["Id"];
                        DateTime FechaCreacion = (DateTime)dr["FechaCreacion"];
                        DateTime FechaModificacion = (DateTime)dr["FchaModificacion"];
                        string Nombre = (string)dr["Nombre"];
                        string Apellido = (string)dr["Apellido"];
                        string Direccion = (string)dr["Direccion"];
                        string Telefono = (string)dr["Telefono"];
                        string Email = (string)dr["Email"];


                        Clientes cl = new Clientes (CodigoCliente, FechaCreacion, FechaModificacion, Nombre, Apellido, Direccion, Telefono, Email);
                        lista.Add(cl);
                    }
                }
            }


            return lista;
        }


        public Clientes TraerPorId(int Id)
        {
            Clientes cl = new Clientes();
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("TraerClientePorId", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", Id);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    dr.Read();
                    int l_Id = (int)dr["Id"];
                    DateTime l_FechaCreacion = (DateTime)dr["FechaCreacion"];
                    DateTime l_FechaModificacion = (DateTime)dr["FechaModificacion"];
                    string l_Nombre = (string)dr["Nombre"];
                    string l_Apellido = (string)dr["Apellido"];
                    string l_Direccion = (string)dr["Direccion"];
                    string l_Telefno  = (string)dr["Telefono"];
                    string l_Email = (string)dr["Email"];

                    cl = new Clientes (l_Id, l_FechaCreacion, l_FechaModificacion, l_Nombre, l_Apellido, l_Direccion, l_Telefno, l_Email);
                }
            }
            return cl;
        }


        public int InsertarClientes(Clientes clientes)
        {
            int n = -1;
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("InsertarCliente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FechaCreacion", clientes.FechaCreacion);
                cmd.Parameters.AddWithValue("@FechaModificacion", clientes.FechaModificacion);
                cmd.Parameters.AddWithValue("@Nombre", clientes.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", clientes.Apellido);
                cmd.Parameters.AddWithValue("@Direccion", clientes.Direccion);
                cmd.Parameters.AddWithValue("@Telefono", clientes.Telefono);
                cmd.Parameters.AddWithValue("@Email", clientes.Email);

                n = cmd.ExecuteNonQuery();
            }

            return n;
        }

        public int ActualizarClientes(Clientes clientes)
        {
            int n = -1;
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ActualizarCliente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", clientes.Id);
                cmd.Parameters.AddWithValue("@FechaCreacion", clientes.FechaCreacion);
                cmd.Parameters.AddWithValue("@FechaModificacion", clientes.FechaModificacion);
                cmd.Parameters.AddWithValue("@Nombre", clientes.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", clientes.Apellido);
                cmd.Parameters.AddWithValue("@Direccion", clientes.Direccion);
                cmd.Parameters.AddWithValue("@Telefono", clientes.Telefono);
                cmd.Parameters.AddWithValue("@Email", clientes.Email);
                n = cmd.ExecuteNonQuery();
            }
            return n;
        }

        public int EliminarCliente(int Id)
        {
            int n = -1;
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("EliminarCliente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", Id);
                n = cmd.ExecuteNonQuery();
            }
            return n;
        }

    }

}


