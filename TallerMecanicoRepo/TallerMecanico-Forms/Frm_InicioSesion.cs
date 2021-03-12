using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TallerMecanico.Negocio;
using TallerMecanico.Entidades;

namespace TallerMecanico_Forms
{
    public partial class Frm_InicioSesion : Form
    {
        public Frm_InicioSesion()
        {
            InitializeComponent();
        }

        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            bool estaVacio = txt_Correo.Text != "" && txt__Clave.Text != "";
            if (estaVacio)
            {
                //lbl_Verificacion.Text = new BL_Trabajador().TraerTrabajadorPorCorreo(txt_Correo.Text, txt__Clave.Text).Nombres;
                
                // Obtener Trabajador
                Trabajador trabajador = new BL_Trabajador().TraerTrabajadorPorCorreo(txt_Correo.Text, txt__Clave.Text);
                // Obtener Permisos del Trabajador
                TipoTrabajador tipo = new BL_TipoTrabajador().TraerTipoTrabajadorPorID(trabajador.TipoTrabajador);
                //tipo.Permisos = new bool[] { true, true, true, true, true, true, true };
                this.Hide();
                Frm_MenuPrincipal menuPrincipal = new Frm_MenuPrincipal(trabajador, tipo);
                menuPrincipal.Show();
            }
                
            
            else
                MessageBox.Show("Debe Ingresar Correo Electrónico y Contraseña",
                    "Datos Faltantes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
        }
    }
}
