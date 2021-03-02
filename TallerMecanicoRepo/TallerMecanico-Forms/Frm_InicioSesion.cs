using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                lbl_Verificacion.Text = txt_Correo.Text + txt__Clave.Text;
            else
                MessageBox.Show("Debe Ingresar Correo Electrónico y Contraseña",
                    "Datos Faltantes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
        }
    }
}
