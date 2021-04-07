using System;
using System.Collections.Generic;
using System.Windows.Forms;

using TallerMecanico.Entidades;
using TallerMecanico.Negocio;

namespace TallerMecanico_Forms
{
    public partial class Frm_Hijo_Proveedor : Form
    {
        private int IndiceProveedorSeleccionado;
        private bool _nuevo { get; set; }
        public Frm_Hijo_Proveedor()
        {
            InitializeComponent();
            ActivarBotones(new bool[] { true, true, true, true, true });
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
            int resultado = -1;

            if (_nuevo)
            {
                //Estoy creando un nuevo Proveedor
                Proveedor  proveedor = new Proveedor
                {
                    NombreProveedor = txt_Nombre.Text,
                    DescripcionProveedor = txt_Descripcion.Text
                };
                resultado = new BL_Proveedor().Insertar(proveedor); 

            }
            else
            {
                //Guardando una modificacion de algo
                Proveedor proveedor = new Proveedor
                {

                    NombreProveedor = txt_Nombre.Text,
                    DescripcionProveedor = txt_Descripcion.Text,
                    CodigoProveedor = IndiceProveedorSeleccionado

                };
                resultado = new BL_Proveedor().Actualizar(proveedor);
                IndiceProveedorSeleccionado = 0;
            }

            LimpiarCajaTexto(grp_DatosEntrada);
            ActivarBotones(new[] { true, true, false, true, true });
            ActivarCajasTexto(grp_DatosEntrada, false);
            CargarDatos();
            grp_DatosEntrada.Text = "Controles Bloqueados";
        }




        private void btn_Editar_Click(object sender, EventArgs e)
        {

            _nuevo = false;
            ActivarBotones(new[] { false, false, true, false, true });
            ActivarCajasTexto(grp_DatosEntrada, true);
            grp_DatosEntrada.Text = "Editando Proveedor  Existente";
            LimpiarCajaTexto(grp_DatosEntrada);
            txt_Nombre.Focus();

            IndiceProveedorSeleccionado = (int)(dgv_Datos[0, dgv_Datos.CurrentRow.Index].Value);
            Proveedor p = new BL_Proveedor().TraerPorID(IndiceProveedorSeleccionado);
            txt_Nombre.Text = p.NombreProveedor;
            txt_Descripcion.Text = p.DescripcionProveedor;


            //

          
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            {

                if (dgv_Datos.RowCount > 0)
                {
                    IndiceProveedorSeleccionado = (int)(dgv_Datos[0, dgv_Datos.CurrentRow.Index].Value);
                    Proveedor p = new BL_Proveedor().TraerPorID(IndiceProveedorSeleccionado);
                    new BL_Proveedor().Eliminar(p.CodigoProveedor);
                    LimpiarCajaTexto(grp_DatosEntrada);
                    ActivarBotones(new[] { true, true, true, true, true });
                    ActivarCajasTexto(grp_DatosEntrada, false);
                    CargarDatos();

                }
            }



        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Frm_Hijo_Proveedor_Load(object sender, EventArgs e)
        {

        }

      
    }
}