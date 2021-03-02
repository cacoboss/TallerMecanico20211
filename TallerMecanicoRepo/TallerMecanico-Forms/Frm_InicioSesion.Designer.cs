
namespace TallerMecanico_Forms
{
    partial class Frm_InicioSesion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Inicio = new System.Windows.Forms.Label();
            this.lbl_Clave = new System.Windows.Forms.Label();
            this.lbl_Correo = new System.Windows.Forms.Label();
            this.lbl_Verificacion = new System.Windows.Forms.Label();
            this.txt_Correo = new System.Windows.Forms.TextBox();
            this.txt__Clave = new System.Windows.Forms.TextBox();
            this.btn_Iniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Inicio
            // 
            this.lbl_Inicio.AutoSize = true;
            this.lbl_Inicio.Location = new System.Drawing.Point(25, 38);
            this.lbl_Inicio.Name = "lbl_Inicio";
            this.lbl_Inicio.Size = new System.Drawing.Size(185, 17);
            this.lbl_Inicio.TabIndex = 0;
            this.lbl_Inicio.Text = "Inicie con correo electrónico";
            // 
            // lbl_Clave
            // 
            this.lbl_Clave.AutoSize = true;
            this.lbl_Clave.Location = new System.Drawing.Point(25, 188);
            this.lbl_Clave.Name = "lbl_Clave";
            this.lbl_Clave.Size = new System.Drawing.Size(81, 17);
            this.lbl_Clave.TabIndex = 1;
            this.lbl_Clave.Text = "Contraseña";
            // 
            // lbl_Correo
            // 
            this.lbl_Correo.AutoSize = true;
            this.lbl_Correo.Location = new System.Drawing.Point(25, 88);
            this.lbl_Correo.Name = "lbl_Correo";
            this.lbl_Correo.Size = new System.Drawing.Size(125, 17);
            this.lbl_Correo.TabIndex = 2;
            this.lbl_Correo.Text = "Correo Electrónico";
            // 
            // lbl_Verificacion
            // 
            this.lbl_Verificacion.AutoSize = true;
            this.lbl_Verificacion.Location = new System.Drawing.Point(25, 9);
            this.lbl_Verificacion.Name = "lbl_Verificacion";
            this.lbl_Verificacion.Size = new System.Drawing.Size(185, 17);
            this.lbl_Verificacion.TabIndex = 3;
            this.lbl_Verificacion.Text = "Inicie con correo electrónico";
            // 
            // txt_Correo
            // 
            this.txt_Correo.Location = new System.Drawing.Point(28, 109);
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.Size = new System.Drawing.Size(303, 22);
            this.txt_Correo.TabIndex = 4;
            // 
            // txt__Clave
            // 
            this.txt__Clave.Location = new System.Drawing.Point(28, 208);
            this.txt__Clave.Name = "txt__Clave";
            this.txt__Clave.Size = new System.Drawing.Size(303, 22);
            this.txt__Clave.TabIndex = 5;
            // 
            // btn_Iniciar
            // 
            this.btn_Iniciar.Location = new System.Drawing.Point(28, 262);
            this.btn_Iniciar.Name = "btn_Iniciar";
            this.btn_Iniciar.Size = new System.Drawing.Size(122, 23);
            this.btn_Iniciar.TabIndex = 6;
            this.btn_Iniciar.Text = "Iniciar Sesión";
            this.btn_Iniciar.UseVisualStyleBackColor = true;
            this.btn_Iniciar.Click += new System.EventHandler(this.btn_Iniciar_Click);
            // 
            // Frm_InicioSesion
            // 
            this.ClientSize = new System.Drawing.Size(419, 335);
            this.Controls.Add(this.btn_Iniciar);
            this.Controls.Add(this.txt__Clave);
            this.Controls.Add(this.txt_Correo);
            this.Controls.Add(this.lbl_Verificacion);
            this.Controls.Add(this.lbl_Correo);
            this.Controls.Add(this.lbl_Clave);
            this.Controls.Add(this.lbl_Inicio);
            this.Name = "Frm_InicioSesion";
            this.Text = "Inicio de Sesión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_Bienvenida;
        private System.Windows.Forms.Label txt_Usuario;
        private System.Windows.Forms.TextBox tbx_Usuario;
        private System.Windows.Forms.Label txt_Clave;

        private System.Windows.Forms.Button btn_IniciarSesion;
        private System.Windows.Forms.Label txt_Verificacion;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Label lbl_Inicio;
        private System.Windows.Forms.Label lbl_Clave;
        private System.Windows.Forms.Label lbl_Correo;
        private System.Windows.Forms.Label lbl_Verificacion;
        private System.Windows.Forms.TextBox txt_Correo;
        private System.Windows.Forms.TextBox txt__Clave;
        private System.Windows.Forms.Button btn_Iniciar;
    }
}