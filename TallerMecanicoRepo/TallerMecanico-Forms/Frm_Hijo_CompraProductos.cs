using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using TallerMecanico.Entidades;
using TallerMecanico.Negocio;

namespace TallerMecanico_Forms {
    public partial class Frm_Hijo_CompraProductos : Form {
        
        private List<Producto> _productos { get; set; }
        private List<DetalleCompra> _listaCompras { get; set; }
        
        private BindingList<DetalleCompra> data { get; set; }
        
        public Frm_Hijo_CompraProductos() {
            InitializeComponent();
            _listaCompras = new List<DetalleCompra>();

            data = new BindingList<DetalleCompra>();
            
            dgv_ProductosAComprar.AutoGenerateColumns = false;
            dgv_ProductosAComprar.AutoSize = true;
            dgv_ProductosAComprar.DataSource = data;
            dgv_ProductosAComprar.Columns[0].DataPropertyName = "IdProducto";
            dgv_ProductosAComprar.Columns[1].DataPropertyName = "NombreProducto";
            dgv_ProductosAComprar.Columns[2].DataPropertyName = "Cantidad";
            dgv_ProductosAComprar.Columns[3].DataPropertyName = "ValorUnitario";
            
        }

        private void btn_BuscarXNombre_Click(object sender, EventArgs e) {
            _productos = new BL_Producto().BuscarPorNombre(txt_BuscarXNombre.Text);
            
            cmb_BuscarXNombre.DataSource = _productos;
            cmb_BuscarXNombre.ValueMember = "CodigoProducto";
            cmb_BuscarXNombre.DisplayMember = "Nombre";
        }

        private void btn_Agregar_Click(object sender, EventArgs e) {
            DetalleCompra detalleCompra = new DetalleCompra();
            
            detalleCompra.Cantidad = int.Parse(txt_Cantidad.Text);
            detalleCompra.IdProducto = ((Producto) cmb_BuscarXNombre.SelectedItem).CodigoProducto;
            detalleCompra.NombreProducto = ((Producto) cmb_BuscarXNombre.SelectedItem).Nombre;
            detalleCompra.ValorUnitario = float.Parse(txt_Precio.Text);
            
            data.Add(detalleCompra);
            
            //_listaCompras.Add(detalleCompra);
            //dgv_ProductosAComprar.DataSource = new BindingSource().DataSource = _listaCompras;

            //data.Cast<DetalleCompra>().ToList();
            /*
            dgv_ProductosAComprar.Rows.Add(
                detalleCompra.IdProducto,
                detalleCompra.NombreProducto,
                detalleCompra.Cantidad,
                detalleCompra.ValorUnitario);
                */
        }
    }
}