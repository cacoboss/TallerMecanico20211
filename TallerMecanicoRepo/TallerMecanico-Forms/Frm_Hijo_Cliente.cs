using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TallerMecanico.Entidades;
using TallerMecanico.Negocio;


namespace TallerMecanico_Forms
{
    public partial class Frm_Hijo_Cliente : Form
    {
        private bool NuevoCliente { get; set; }
        private int IndiceClienteSeleccionado;


        public Frm_Hijo_Cliente()
        {
            InitializeComponent();
         
            ActivarBotones(new[] { true, true, false, true, true });
            ActivarCajasTexto(grp_Controles, false);
            CargarDatos();
        }

        private void ActivarBotones(bool[] opciones)
        {
            btn_Nuevo.Enabled = opciones[0];
            btn_Editar.Enabled = opciones[1];
            btn_Guardar.Enabled = opciones[2];
            btn_Eliminar.Enabled = opciones[3];
            btn_Cerrar.Enabled = opciones[4];
        }


        private void ActivarCajasTexto(Control contenedor, bool estado)
        {
            try
            {
                foreach (var cajaTexto in contenedor.Controls)
                {
                    if (cajaTexto.GetType() == typeof(TextBox))
                        ((TextBox)cajaTexto).Enabled = estado;
                    if (cajaTexto.GetType() == typeof(ComboBox))
                        ((ComboBox)cajaTexto).Enabled = estado;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }


        private void LimpiarCajaTexto(Control contenedor)
        {
            try
            {
                foreach (var cajaTexto in contenedor.Controls)
                {
                    if (cajaTexto.GetType() == typeof(TextBox))
                        ((TextBox)cajaTexto).Clear();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }


        private void CargarDatos()
        {
            List<Cliente> cliente = new BL_Cliente().Listar();
            if (cliente.Count > 0)
            {
                dgv_Cliente.Rows.Clear();
                for (int i = 0; i < cliente.Count; i++)
                {
                    Cliente p = cliente[i];
                    dgv_Cliente.Rows.Add
                        (
                        p.CodigoCliente,
                        p.Nombres,
                        p.Apellidos,
                        p.Direccion,
                        p.Telefono,
                        p.Email
                        );
                }
            }
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            NuevoCliente = true;
         
            ActivarBotones(new[] { false, false, true, false, true });
            ActivarCajasTexto(grp_Controles, true);
            grp_Controles.Text = "Creando Nuevo Cliente";
            LimpiarCajaTexto(grp_Controles);
            txt_Nombres.Focus();
        }

     

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            int resultado = -1;

            if (NuevoCliente)
            {
                Cliente cliente = new Cliente
                {

                    Nombres=txt_Nombres.Text,
                    Apellidos = txt_Apellidos.Text,
                    Direccion = txt_Direccion.Text,
                    Telefono= long.Parse(txt_Telefono.Text),
                    Email = txt_Email.Text,

                    
                };
                resultado = new BL_Cliente().Insertar(cliente);
            }
            else
            {
                //Guardando una modificacion de algo
                Cliente cliente = new Cliente
                {
                    
                    Nombres = txt_Nombres.Text,
                    Apellidos = txt_Apellidos.Text,
                    Direccion = txt_Direccion.Text,
                    Telefono = long.Parse(txt_Telefono.Text),
                    Email = txt_Email.Text,
                    CodigoCliente = IndiceClienteSeleccionado
                };
                resultado = new BL_Cliente().Actualizar(cliente);
                IndiceClienteSeleccionado = 0;
            }

            LimpiarCajaTexto(grp_Controles);
            ActivarBotones(new[] { true, true, false, true, true });
            ActivarCajasTexto(grp_Controles, false);
            CargarDatos();
            grp_Controles.Text = "Controles Bloqueados";
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            NuevoCliente = false;

            ActivarBotones(new[] { false, false, true, false, true });
            ActivarCajasTexto(grp_Controles, true);
            grp_Controles.Text = "Editando Producto Existente";
            LimpiarCajaTexto(grp_Controles);
            txt_Nombres.Focus();

            IndiceClienteSeleccionado = (int)(dgv_Cliente[0, dgv_Cliente.CurrentRow.Index].Value);
            Cliente p = new BL_Cliente().TraerPorId(IndiceClienteSeleccionado);
            txt_Nombres.Text = p.Nombres;
            txt_Apellidos.Text = p.Apellidos;
            txt_Direccion.Text = p.Direccion;
            txt_Telefono.Text = p.Telefono.ToString();
            txt_Email.Text = p.Email;


        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_Cliente.RowCount > 0)
            {
                IndiceClienteSeleccionado = (int)(dgv_Cliente[0, dgv_Cliente.CurrentRow.Index].Value);
                Cliente p = new BL_Cliente().TraerPorId(IndiceClienteSeleccionado);
                new BL_Cliente().Eliminar(p.CodigoCliente);
                LimpiarCajaTexto(grp_Controles);
                ActivarBotones(new[] { true, true, false, true, true });
                ActivarCajasTexto(grp_Controles, false);
                CargarDatos();
            }
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
