using System;
using System.Collections.Generic;
using System.Windows.Forms;

using TallerMecanico.Entidades;
using TallerMecanico.Negocio;

namespace TallerMecanico_Forms {
    
    public partial class Frm_Hijo_Trabajadores : Form {
        
        //  --> Campos
        private List<TipoTrabajador> _listaTipo;
        
        //  --> Propiedades
        public List<TipoTrabajador> tipo {
            get {
                if (_listaTipo == null) {
                    _listaTipo = new BL_TipoTrabajador().ListarTipoTrabajador();
                }

                return _listaTipo;
            }
            set {
                _listaTipo = value;
            }
        }
        public bool esNuevo { get; set; }
        public long cedulaTrabajadorSeleccionado { get; set; }
        public Frm_Hijo_Trabajadores()
        {
            InitializeComponent();
            EncenderControlesBotones(new []{true, true, false, true});
            ActivarCajasTexto(grp_Controles, false);
            grp_Controles.Text = "Controles Bloqueados";
            CargarDatos();
            AgregarOpcionesTipoTrabajador(cmb_Tipo);
        }

        // --> Metodos de Control de Interfaz de Usuario
        
        private void EncenderControlesBotones(bool[] controlador) {
            btn_Nuevo.Enabled = controlador[0];
            btn_Editar.Enabled = controlador[1];
            btn_Guardar.Enabled = controlador[2];
            btn_Eliminar.Enabled = controlador[3];
        }
        
        private void ActivarCajasTexto(Control contenedor, bool estado) {
            try {
                foreach (var cajaTexto in contenedor.Controls) {
                    if (cajaTexto.GetType() == typeof(TextBox))
                        ((TextBox) cajaTexto).Enabled = estado;
                    if (cajaTexto.GetType() == typeof(ComboBox))
                        ((ComboBox) cajaTexto).Enabled = estado;
                }
            }
            catch (Exception e) {
                Console.WriteLine(e);
                throw;
            }
        }

        private void CargarDatos() {
            List<Trabajador> trabajadores = new List<Trabajador>();
            trabajadores = new BL_Trabajador().ListarTrabajadores();

            if (trabajadores.Count > 0) {
                dgv_Trabajadores.Rows.Clear();
                for (int i = 0; i < trabajadores.Count; i++) {
                    Trabajador t = trabajadores[i];
                    dgv_Trabajadores.Rows.Add(t.Cedula,
                        t.Nombres,
                        t.Apellidos,
                        t.CorreoElectronico,
                        ObtenerNombreCategoria(t.TipoTrabajador));
                }
            }
        }
        
        private string ObtenerNombreCategoria(int id) {
            string s = "";
            foreach (var tipoTrabajador in tipo) {
                if (tipoTrabajador.CodigoTrabajador == id) {
                    s = tipoTrabajador.NombreCargo;
                    break;
                }
            }

            return s;
        }
        
        private void LimpiarCajaTexto(Control contenedor) {
            try {
                foreach (var cajaTexto in contenedor.Controls) {
                    if (cajaTexto.GetType() == typeof(TextBox))
                        ((TextBox) cajaTexto).Clear();
                }
            }
            catch (Exception e) {
                Console.WriteLine(e);
                throw;
            }
        }

        private void AgregarOpcionesTipoTrabajador(ComboBox cmb) {
            foreach (var tipoTrabajador in tipo) {
                cmb.Items.Add(tipoTrabajador.NombreCargo);
            }
        }

        private int TipoSeleccionado(string s) {
            int id = 0;
            foreach (var tipoTrabajador in tipo)
            {
                if (tipoTrabajador.NombreCargo == s)
                {
                    id = tipoTrabajador.CodigoTrabajador;
                    break;
                }
            }

            return id;
        }
        // --> Metodos de Funcionaminto Botones


        private void btn_Nuevo_Click(object sender, EventArgs e) {
            esNuevo = true;
            EncenderControlesBotones(new []{false, false, true, false});
            ActivarCajasTexto(grp_Controles, true);
            grp_Controles.Text = "Creando Nuevo Trabajador";
            LimpiarCajaTexto(grp_Controles);
            txt_Nombres.Focus();
        }

        private void btn_Editar_Click(object sender, EventArgs e) {
            esNuevo = false;
            EncenderControlesBotones(new []{false, false, true, false});
            ActivarCajasTexto(grp_Controles, true);
            grp_Controles.Text = "Editando Trabajador Existente";
            LimpiarCajaTexto(grp_Controles);
            txt_Nombres.Focus();
            
            cedulaTrabajadorSeleccionado = (long) (dgv_Trabajadores[0, dgv_Trabajadores.CurrentRow.Index].Value);
            Trabajador t = new BL_Trabajador().TraerTrabajadorPorCedula(cedulaTrabajadorSeleccionado);
            
            txt_Apellidos.Text = t.Apellidos;
            txt_Cedula.Text = t.Cedula.ToString();
            txt_Celular.Text = t.Celular.ToString();
            txt_Clave.Text = t.Clave;
            txt_Correo.Text = t.CorreoElectronico;
            txt_Nombres.Text = t.Nombres;
        }


        private void btn_Guardar_Click(object sender, EventArgs e) {
            Trabajador trabajador = new Trabajador();
            
            trabajador.Apellidos = txt_Apellidos.Text;
            trabajador.Cedula = long.Parse(txt_Cedula.Text);
            trabajador.Celular = long.Parse(txt_Celular.Text);
            trabajador.Clave = txt_Clave.Text;
            trabajador.CorreoElectronico = txt_Correo.Text;
            trabajador.Nombres = txt_Nombres.Text;
            trabajador.TipoTrabajador = TipoSeleccionado((string) cmb_Tipo.SelectedItem);
            
            if (esNuevo) {
                new BL_Trabajador().InsertarTrabajador(trabajador);
            }
            else {
                new BL_Trabajador().ActualizarTrabajador(trabajador);
                cedulaTrabajadorSeleccionado = 0;
            }

            esNuevo = false;
            EncenderControlesBotones(new []{true, true, false, true});
            ActivarCajasTexto(grp_Controles, false);
            grp_Controles.Text = "Controles Bloqueados";
            CargarDatos();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e) {
            if (dgv_Trabajadores.RowCount > 0) {
                Trabajador t =
                    new BL_Trabajador().TraerTrabajadorPorCedula(
                        (long) (dgv_Trabajadores[0, dgv_Trabajadores.CurrentRow.Index].Value));
                new BL_Trabajador().EliminarTrabajador(t.Cedula);
                EncenderControlesBotones(new []{true, true, false, true});
                ActivarCajasTexto(grp_Controles, false);
                grp_Controles.Text = "Controles Bloqueados";
                LimpiarCajaTexto(grp_Controles);
                CargarDatos();
            }
        }
    }
}