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
    public partial class Frm_MenuPrincipal : Form
    {


        public Frm_MenuPrincipal()
        {
            InitializeComponent();
            EsconderSubMenus();
        }

        private void EsconderSubMenus()
        {
            pnl_ModuloUsuarios.Visible = false;
        }
        private void EsconderSubMenus_2()
        {
            if (pnl_ModuloUsuarios.Visible == true)
                pnl_ModuloUsuarios.Visible = false;
        }
        private void MostrarSubMenu(Panel subMenu)
        {
           subMenu.Visible = (!subMenu.Visible) ? true : false;
        }

        private void btn_ModuloUsuarios_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnl_ModuloUsuarios);
        }
    }
}
