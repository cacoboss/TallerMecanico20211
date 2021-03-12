using System;
using System.Collections.Generic;
using System.Windows.Forms;

using TallerMecanico.Entidades;
using TallerMecanico.Negocio;

namespace TallerMecanico_Forms
{
    public partial class Frm_Hijo_Proveedor : Form
    {
        private bool _nuevo { get; set; }
        private Proveedor proveedor { get; set; }
        public Frm_Hijo_Proveedor()
        {
            InitializeComponent();
            ActivarBotones(new bool[] {true, true, false, false, true});
            ActivarCajasTexto(grp_DatosEntrada, false);
            CargarDatos();
        }

        private void ActivarCajasTexto(Control contenedor, bool estado)
        {
            try
            {
                foreach (var cajaTexto in contenedor.Controls)
                {
                    if (cajaTexto.GetType() == typeof(TextBox))
                        ((TextBox) cajaTexto).Enabled = estado;
                    if (cajaTexto.GetType() == typeof(ComboBox))
                        ((ComboBox) cajaTexto).Enabled = estado;
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
                        ((TextBox) cajaTexto).Clear();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private void ActivarBotones(bool[] opciones )
        {
            btn_Nuevo.Enabled = opciones[0];
            btn_Editar.Enabled = opciones[1];
            btn_Guardar.Enabled = opciones[2];
            btn_Eliminar.Enabled = opciones[3];
            btn_Cerrar.Enabled = opciones[4];
        }

        private void CargarDatos()
        {
            List<Proveedor> lista = new BL_Proveedor().Listar();
            if (lista.Count > 0)
            {
                dgv_Datos.Rows.Clear();
                for (int i = 0; i < lista.Count; i++)
                {
                    Proveedor p = lista[i];
                    dgv_Datos.Rows.Add(p.CodigoProveedor,
                        p.NombreProveedor,
                        p.DescripcionProveedor);
                }
            }
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            _nuevo = true;
            ActivarBotones(new []{false, false, true, false, true});
            ActivarCajasTexto(grp_DatosEntrada, true);
            grp_DatosEntrada.Text = "Creando Nuevo Proveedor";
            LimpiarCajaTexto(grp_DatosEntrada);
            txt_Nombre.Focus();
        }


        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            ActivarBotones(new bool[] {true, true, false, false, true});
            
            if (_nuevo)
            {
                //Estoy creando un nuevo Proveedor
                proveedor = new Proveedor
                {
                    CodigoProveedor = 0,
                    NombreProveedor = txt_Nombre.Text,
                    DescripcionProveedor = txt_Descripcion.Text
                };
                BL_Proveedor blProveedor = new BL_Proveedor();
                blProveedor.Insertar(proveedor);
            }
            else
            {
                //Estoy actualizando un Proveedor
                /*
                proveedor = new Proveedor
                {
                    NombreProveedor = txt_Nombre.Text,
                    DescripcionProveedor = txt_Descripcion.Text
                };*/
            }
            
            ActivarCajasTexto(grp_DatosEntrada, false);
            LimpiarCajaTexto(grp_DatosEntrada);
        }
    }
}