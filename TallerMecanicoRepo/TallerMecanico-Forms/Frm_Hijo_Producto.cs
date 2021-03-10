using System.Collections.Generic;
using System.Windows.Forms;

using TallerMecanico.Entidades;
using TallerMecanico.Negocio;

namespace TallerMecanico_Forms
{
    public partial class Frm_Hijo_Producto : Form
    {
        private List<Categoria> _categoriasDisponibles = new List<Categoria>();

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
        }

        private void AgregarOpcionesDeCategoria()
        {
            foreach (Categoria categoria in listadoCategoria)
            {
                cmb_Categoria.Items.Add(categoria.Nombre);
            }
        }
    }
}