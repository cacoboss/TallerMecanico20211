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
                        ConfigurationManager.ConnectionStrings["Conex"].ConnectionString;
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
                    SqlCommand cmd = new SqlCommand("Trabajador_TraerTrabajadorPorCorreo", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CORREO", correo);
                    cmd.Parameters.AddWithValue("@CLAVE", clave);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if(dr != null && dr.HasRows){
                        dr.Read();
                        trabajador.Cedula = (long)dr["Cedula"];
                        trabajador.Nombres = (string)dr["Nombres"];
                        trabajador.Apellidos = (string)dr["Apellidos"];
                        trabajador.Celular = (long)dr["Celular"];
                        trabajador.TipoTrabajador = (int)dr["TipoTrabajador"];
                        //trabajador.TipoTrabajador = (int)dr["TipoTrabajador"];
                        trabajador.CorreoElectronico = correo;
                        trabajador.Clave = clave;
                    }
                }
            }catch(Exception ex)
            {

            }
            return trabajador;
        }

        public Trabajador TraerPorID(long ID) {
            Trabajador trabajador = new Trabajador();
            using (SqlConnection con = new SqlConnection(CadenaConexion)) {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_Trabajador_TraerPorID", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", ID);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows) {
                    dr.Read();
                    trabajador.Cedula = (long) dr["Cedula"];
                    trabajador.Nombres = (string) dr["Nombres"];
                    trabajador.Apellidos = (string) dr["Apellidos"];
                    trabajador.Celular = (long) dr["Celular"];
                    trabajador.CorreoElectronico = (string) dr["Correo"];
                    trabajador.Clave = (string) dr["Clave"];
                    trabajador.TipoTrabajador = (int) dr["TipoTrabajador"];
                }
            }

            return trabajador;
        }

        public List<Trabajador> Listar() {
            List<Trabajador> trabajadores = new List<Trabajador>();
            using (SqlConnection con = new SqlConnection(CadenaConexion)) {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_Trabajador_Listar", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read()) {
                    Trabajador trabajador = new Trabajador();
                    trabajador.Cedula = (long) dr["Cedula"];
                    trabajador.Nombres = (string) dr["Nombres"];
                    trabajador.Apellidos = (string) dr["Apellidos"];
                    trabajador.Celular = (long) dr["Celular"];
                    trabajador.CorreoElectronico = (string) dr["Correo"];
                    trabajador.Clave = (string) dr["Clave"];
                    trabajador.TipoTrabajador = (int) dr["TipoTrabajador"];
                    
                    trabajadores.Add(trabajador);
                }
            }

            return trabajadores;
        }

        public int Insertar(Trabajador trabajador) {
            int n;
            using (SqlConnection con = new SqlConnection(CadenaConexion)) {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_Trabajador_Insertar", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CEDULA", trabajador.Cedula);
                cmd.Parameters.AddWithValue("@NOMBRES", trabajador.Nombres);
                cmd.Parameters.AddWithValue("@APELLIDOS", trabajador.Apellidos);
                cmd.Parameters.AddWithValue("@TIPO", trabajador.TipoTrabajador);
                cmd.Parameters.AddWithValue("@CELULAR", trabajador.Celular);
                cmd.Parameters.AddWithValue("@CORREO", trabajador.CorreoElectronico);
                cmd.Parameters.AddWithValue("@CLAVE", trabajador.Clave);
                n = cmd.ExecuteNonQuery();
            }

            return n;
        }

        public int Actualizar(Trabajador trabajador) {
            int n;
            using (SqlConnection con = new SqlConnection(CadenaConexion)) {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_Trabajador_Actualizar", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CEDULA", trabajador.Cedula);
                cmd.Parameters.AddWithValue("@NOMBRES", trabajador.Nombres);
                cmd.Parameters.AddWithValue("@APELLIDOS", trabajador.Apellidos);
                cmd.Parameters.AddWithValue("@TIPO", trabajador.TipoTrabajador);
                cmd.Parameters.AddWithValue("@CELULAR", trabajador.Celular);
                cmd.Parameters.AddWithValue("@CORREO", trabajador.CorreoElectronico);
                cmd.Parameters.AddWithValue("@CLAVE", trabajador.Clave);
                n = cmd.ExecuteNonQuery();
            }

            return n;
        }

        public int Eliminar(long ID) {
            int n;
            using (SqlConnection con = new SqlConnection(CadenaConexion)) {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_Trabajador_Eliminar", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", ID);
                n = cmd.ExecuteNonQuery();
            }

            return n;
        }
    }
}
