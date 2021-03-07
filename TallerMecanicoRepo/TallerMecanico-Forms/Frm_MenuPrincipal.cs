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
    public partial class Frm_MenuPrincipal : Form
    {
        public Trabajador trabajador;
        public TipoTrabajador tipo;

        public Frm_MenuPrincipal(Trabajador trabajador, TipoTrabajador tipo)
        {
            InitializeComponent();
            this.trabajador = trabajador;
            this.tipo = tipo;
            HabilitarFuncionalidades();
            EsconderSubMenus();
        }

        private void HabilitarFuncionalidades()
        {
            if (tipo.Permisos[6])
                btn_ModuloUsuarios.Enabled = true;
            if (tipo.Permisos[3])
                btn_ModuloUsuarios.Enabled = true;
        }
        private void EsconderSubMenus()
        {
            
            pnl_ModuloUsuarios.Visible = false;
            pnl_ModuloVentas.Visible = false;
        }
        private void EsconderSubMenus_2()
        {
            if (pnl_ModuloUsuarios.Visible == true)
                pnl_ModuloUsuarios.Visible = false;
            if (pnl_ModuloVentas.Visible == true)
                pnl_ModuloVentas.Visible = false;
        }
        private void MostrarSubMenu(Panel subMenu)
        {
           subMenu.Visible = (!subMenu.Visible) ? true : false;
        }

        private void btn_ModuloUsuarios_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnl_ModuloUsuarios);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ModuloVentas_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnl_ModuloVentas);
        }
    }
}
