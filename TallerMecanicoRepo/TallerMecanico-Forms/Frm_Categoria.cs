using System;
using System.Collections.Generic;
using System.Windows.Forms;

using TallerMecanico.Entidades;
using TallerMecanico.Negocio;

namespace TallerMecanico_Forms
{
    public partial class Frm_Categoria : Form
    {
        List<Categoria> lista = null;
        BL_Categoria bl_categoria = new BL_Categoria();
        Categoria c;
        bool _nuevo = false;

        public Frm_Categoria()
        {
            InitializeComponent();
            ActivarControlDatos(gb_Datos, false);
            CargarDatos();
        }

        #region Logica
        private void ActivarControlDatos(Control contenedor, bool Estados)
        {
            try
            {
                foreach (var item in contenedor.Controls)
                {
                    if (item.GetType() == typeof(TextBox))
                        ((TextBox)item).Enabled = Estados;
                }
            }
            catch (Exception e)
            {

            }
        }

        private void LimpiarControl(Control contenedor)
        {
            foreach (var item in contenedor.Controls)
                if (item.GetType() == typeof(TextBox))
                    ((TextBox)item).Clear();
        }

        private void ActivarBoton(bool Estado)
        {
            btn_Editar.Enabled = Estado;
            btn_Eliminar.Enabled = Estado;
            btn_Salir.Enabled = Estado;

            btn_Grabar.Enabled = !Estado;
        }

        private void CargarDatos()
        {
            if (lista == null)
                lista = bl_categoria.Listar();
            if (lista.Count > 0)
            {
                dgv_Datos.Rows.Clear();
                for (int i = 0; i < lista.Count; i++)
                    dgv_Datos.Rows.Add(lista[i].Id,
                        lista[i].Codigo,
                        lista[i].Nombre,
                        lista[i].Observacion);
            }
        }
        #endregion


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = -1;
            if (_nuevo)
            {
                c = new Categoria(0, txt_Codigo.Text,
                    txt_Nombre.Text,
                    txt_Observacion.Text);
                n = bl_categoria.Insertar(c);
            }
            else
            {
                c.Codigo = txt_Codigo.Text;
                c.Nombre = txt_Nombre.Text;
                c.Observacion = txt_Observacion.Text;
                n = bl_categoria.Actualizar(c);
            }

            if (n > 0)
            {
                MessageBox.Show("Datos Grabados Correctamente", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActivarControlDatos(gb_Datos, false);
                ActivarBoton(true);
                dgv_Datos.Enabled = true;
                LimpiarControl(gb_Datos);
                btn_Editar.Text = "Editar";
                lista = bl_categoria.Listar();
                CargarDatos();
            }
            else
            {
                MessageBox.Show("Error al grabar", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _nuevo = false;
            if(btn_Editar.Text == "Cancelar")
            {
                LimpiarControl(gb_Datos);
                ActivarControlDatos(gb_Datos, false);
                ActivarBoton(true);
                dgv_Datos.Enabled = true;
                btn_Editar.Text = "Editar";
            }
            else
            {
                if(dgv_Datos.RowCount > 0)
                {
                    c = bl_categoria.TraerPorId(
                        (int)dgv_Datos[0, dgv_Datos.CurrentRow.Index].Value);
                    txt_Codigo.Text = c.Codigo;
                    txt_Nombre.Text = c.Nombre;
                    txt_Observacion.Text = c.Observacion;
                    ActivarControlDatos(gb_Datos, true);
                    ActivarBoton(false);
                    dgv_Datos.Enabled = false;
                    btn_Editar.Text = "Cancelar";
                }
            }
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            _nuevo = true;
            ActivarControlDatos(gb_Datos, true);
            btn_Editar.Text = "Cancelar";
            ActivarBoton(false);
            LimpiarControl(gb_Datos);
            txt_Codigo.Focus();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_Datos.RowCount > 0)
            {
                c = bl_categoria.TraerPorId(
                    (int)dgv_Datos[0, dgv_Datos.CurrentRow.Index].Value);
                DialogResult rpta = MessageBox.Show("Desea eliminar el registro", "Eliminar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(rpta == System.Windows.Forms.DialogResult.Yes)
                {
                    int n = bl_categoria.Eliminar(c.Id);
                    if (n > 0)
                    {
                        MessageBox.Show("Registro Eliminado", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lista = bl_categoria.Listar();
                        CargarDatos();
                    }
                }
                else
                {
                    MessageBox.Show("Error al Eliminar", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
