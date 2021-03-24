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
    public partial class Frm_ProductoProveedor : Form
    {

        private List<Proveedor> _proveedoresDisponibles = new List<Proveedor>();
        private List<Producto> _ProductoDisponibles = new List<Producto>();

        private bool NuevoProductoProveedor { get; set; }

        private int IndiceProductoProveedorSeleccionado;

        public Frm_ProductoProveedor()
        {
            InitializeComponent();
            ListadoProveedor = new BL_Proveedor().Listar();
            listadoProducto = new BL_Producto().Listar();
            AgregarOpcionesProveedor();
            AgregarOpcionesProducto();
            ActivarBotones(new[] { true, true, false, true, true });
            ActivarCajasTexto(grp_Controles, false);
            CargarDatos();
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


        public List<Proveedor> ListadoProveedor
        {
            get => _proveedoresDisponibles;
            set => _proveedoresDisponibles = value;
        }



        public List<Producto> listadoProducto
        {
            get => _ProductoDisponibles;
            set => _ProductoDisponibles = value;
        }


        private void AgregarOpcionesProveedor()
        {
            foreach (Proveedor proveedor in ListadoProveedor)
            {
                cmb_Proveedor.Items.Add(proveedor.NombreProveedor);
            }
        }


        private void AgregarOpcionesProducto()
        {
            foreach (Producto producto in listadoProducto)
            {
                cmb_Producto.Items.Add(producto.Nombre);
            }
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

        private void CargarDatos()
        {
            List<ProveedorProductos> proveedorproducto = new BL_ProveedorProductos().Listar();
            if (proveedorproducto.Count > 0)
            {
                dgv_ProductosProveedores.Rows.Clear();
                for (int i = 0; i < proveedorproducto.Count; i++)
                {
                    ProveedorProductos p = proveedorproducto[i];
                    dgv_ProductosProveedores.Rows.Add(
                        ObtenerNombreProveedor(p.CodigoProveedor),
                        ObtenerNombreProducto(p.CodigoProveedor)
                        );
                }
            }
        }

        private int ProveedorSeleccionado(string nombre)
        {
            int id = 0;
            foreach (Proveedor proveedor in ListadoProveedor)
            {
                if (proveedor.NombreProveedor == nombre)
                {
                    id = proveedor.CodigoProveedor;
                    break;
                }
            }

            return id;
        }


        private int ProductoSeleccionado(string nombre)
        {
            int id = 0;
            foreach (Producto producto in listadoProducto)
            {
                if (producto.Nombre == nombre)
                {
                    id = producto.CodigoProducto;
                    break;
                }
            }

            return id;
        }

        private string ObtenerNombreProveedor(int id)
        {
            string s = "";
            foreach (Proveedor proveedor in ListadoProveedor)
            {
                if (proveedor.CodigoProveedor == id)
                {
                    s = proveedor.NombreProveedor;
                    break;
                }
            }

            return s;
        }



        private string ObtenerNombreProducto(int id)
        {
            string s = "";
            foreach (Producto producto in listadoProducto)
            {
                if (producto.CodigoProducto == id)
                {
                    s = producto.Nombre;
                    break;
                }
            }

            return s;
        }

        private void cmb_Producto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            NuevoProductoProveedor = true;
            ListadoProveedor = new BL_Proveedor().Listar();
            listadoProducto = new BL_Producto().Listar();
            ActivarBotones(new[] { false, false, true, false, true });
            ActivarCajasTexto(grp_Controles, true);
            grp_Controles.Text = "Creando Nueva Relacion";
            LimpiarCajaTexto(grp_Controles);

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            int resultado = -1;

            if (NuevoProductoProveedor)
            {
                ProveedorProductos proveedorProductos = new ProveedorProductos
                {

                    CodigoProveedor = ProveedorSeleccionado((string)cmb_Proveedor.SelectedItem),
                    CodigoProducto = ProductoSeleccionado((string)cmb_Producto.SelectedItem)


                };
                resultado = new BL_ProveedorProductos().Insertar(proveedorProductos);
            }
            else
            {
                //Guardando una modificacion de algo
                ProveedorProductos productoproducto = new ProveedorProductos
                {
                    CodigoProveedor = ProveedorSeleccionado((string)cmb_Proveedor.SelectedItem),
                    CodigoProducto = ProductoSeleccionado((string)cmb_Producto.SelectedItem),
                    Consecutivo = IndiceProductoProveedorSeleccionado
                };
                resultado = new BL_ProveedorProductos().Actualizar(productoproducto);
                IndiceProductoProveedorSeleccionado = 0;
            }

            LimpiarCajaTexto(grp_Controles);
            ActivarBotones(new[] { true, true, false, true, true });
            ActivarCajasTexto(grp_Controles, false);
            CargarDatos();
            grp_Controles.Text = "Controles Bloqueados";
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {

            NuevoProductoProveedor = false;
            listadoProducto = new BL_Producto().Listar();
            ListadoProveedor = new BL_Proveedor().Listar();

            ActivarBotones(new[] { false, false, true, false, true });
            ActivarCajasTexto(grp_Controles, true);
            grp_Controles.Text = "Editando Relacion Existente";
            LimpiarCajaTexto(grp_Controles);
            cmb_Producto.Focus();


            IndiceProductoProveedorSeleccionado = (int)(dgv_ProductosProveedores[0, dgv_ProductosProveedores.CurrentRow.Index].Value);
            ProveedorProductos p = new BL_ProveedorProductos().TraerPorId(IndiceProductoProveedorSeleccionado);

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_ProductosProveedores.RowCount > 0)
            {
                IndiceProductoProveedorSeleccionado = (int)(dgv_ProductosProveedores[0, dgv_ProductosProveedores.CurrentRow.Index].Value);
                ProveedorProductos p = new BL_ProveedorProductos().TraerPorId(IndiceProductoProveedorSeleccionado);
                new BL_ProveedorProductos().Eliminar(p.Consecutivo);
                LimpiarCajaTexto(grp_Controles);
                ActivarBotones(new[] { true, true, true, true, true });
                ActivarCajasTexto(grp_Controles, false);
                CargarDatos();
            }
        }

    }




}
