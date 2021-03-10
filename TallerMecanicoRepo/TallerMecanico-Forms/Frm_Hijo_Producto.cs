using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

using TallerMecanico.Entidades;
using TallerMecanico.Negocio;

namespace TallerMecanico_Forms
{
    public partial class Frm_Hijo_Producto : Form
    {
        private List<Categoria> _categoriasDisponibles = new List<Categoria>();
        
        private bool NuevoProducto { get; set; }

        public List<Categoria> listadoCategoria
        {
            get => _categoriasDisponibles;
            set => _categoriasDisponibles = value;
        }
        
        public Frm_Hijo_Producto()
        {
            InitializeComponent();
            listadoCategoria = new BL_Categoria().Listar();
            //cmb_Categoria.Items.AddRange(listadoCategoria.ToArray());
            AgregarOpcionesDeCategoria();
            ActivarBotones(new []{true, true, false, true, true});
            ActivarCajasTexto(grp_Controles, false);
        }

        #region Logica del Funcionamiento del Formulario
        
        private void AgregarOpcionesDeCategoria()
        {
            foreach (Categoria categoria in listadoCategoria)
            {
                cmb_Categoria.Items.Add(categoria.Nombre);
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

        private int CategoriaSeleccionada(string nombre)
        {
            int id = 0;
            foreach (Categoria categoria in listadoCategoria)
            {
                if (categoria.Nombre == nombre)
                {
                    id = categoria.Id;
                    break;
                }
            }

            return id;
        }

        private void CargarDatos()
        {
            List<Producto> productos = new List<Producto>();
            if (productos.Count > 0)
            {
                dgv_Productos.Rows.Clear();
            }
        }
        #endregion
        
        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            NuevoProducto = true;
            ActivarBotones(new []{false, false, true, false, true});
            ActivarCajasTexto(grp_Controles, true);
            grp_Controles.Text = "Creando Nuevo Producto";
            LimpiarCajaTexto(grp_Controles);
            txt_Nombre.Focus();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            int resultado = -1;
            if (NuevoProducto)
            {
                //Guardando un nuevo Producto
                Producto producto = new Producto
                {
                    CodigoCategoria = CategoriaSeleccionada((string)cmb_Categoria.SelectedItem),
                    DescripcionProducto = txt_Descripcion.Text,
                    Marca = txt_Marca.Text,
                    ValorUnitarioCompra = float.Parse(txt_Compra.Text) ,
                    ValorUnitarioVenta = float.Parse(txt_Venta.Text),
                    Nombre = txt_Nombre.Text
                };
                
                resultado = new BL_Producto().Insertar(producto);
                LimpiarCajaTexto(grp_Controles);
                ActivarBotones(new []{true, true, false, true, true});
                ActivarCajasTexto(grp_Controles, false);
            }
            else
            {
                //Guardando una modificacion de algo
                Producto producto = new Producto
                {
                    CodigoCategoria = CategoriaSeleccionada((string)cmb_Categoria.SelectedItem),
                    DescripcionProducto = txt_Descripcion.Text,
                    Marca = txt_Marca.Text,
                    ValorUnitarioCompra = float.Parse(txt_Compra.Text) ,
                    ValorUnitarioVenta = float.Parse(txt_Venta.Text),
                    Nombre = txt_Nombre.Text
                };
            }
        }
    }  
}