using System.ComponentModel;

namespace TallerMecanico_Forms {
    partial class Frm_Hijo_Trabajadores {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
        private void InitializeComponent() {
            this.dgv_Trabajadores = new System.Windows.Forms.DataGridView();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Permisos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp_Controles = new System.Windows.Forms.GroupBox();
            this.cmb_Tipo = new System.Windows.Forms.ComboBox();
            this.txt_Clave = new System.Windows.Forms.TextBox();
            this.txt_Correo = new System.Windows.Forms.TextBox();
            this.txt_Celular = new System.Windows.Forms.TextBox();
            this.txt_Cedula = new System.Windows.Forms.TextBox();
            this.txt_Apellidos = new System.Windows.Forms.TextBox();
            this.txt_Nombres = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grp_Botones = new System.Windows.Forms.GroupBox();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.dgv_Trabajadores)).BeginInit();
            this.grp_Controles.SuspendLayout();
            this.grp_Botones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Trabajadores
            // 
            this.dgv_Trabajadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Trabajadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.Cedula, this.Nombres, this.Apellidos, this.Correo, this.Permisos});
            this.dgv_Trabajadores.Location = new System.Drawing.Point(15, 310);
            this.dgv_Trabajadores.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Trabajadores.Name = "dgv_Trabajadores";
            this.dgv_Trabajadores.RowTemplate.Height = 24;
            this.dgv_Trabajadores.Size = new System.Drawing.Size(969, 238);
            this.dgv_Trabajadores.TabIndex = 0;
            // 
            // Cedula
            // 
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.Name = "Cedula";
            // 
            // Nombres
            // 
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            // 
            // Permisos
            // 
            this.Permisos.HeaderText = "Permisos de Usuario";
            this.Permisos.Name = "Permisos";
            // 
            // grp_Controles
            // 
            this.grp_Controles.Controls.Add(this.cmb_Tipo);
            this.grp_Controles.Controls.Add(this.txt_Clave);
            this.grp_Controles.Controls.Add(this.txt_Correo);
            this.grp_Controles.Controls.Add(this.txt_Celular);
            this.grp_Controles.Controls.Add(this.txt_Cedula);
            this.grp_Controles.Controls.Add(this.txt_Apellidos);
            this.grp_Controles.Controls.Add(this.txt_Nombres);
            this.grp_Controles.Controls.Add(this.label7);
            this.grp_Controles.Controls.Add(this.label6);
            this.grp_Controles.Controls.Add(this.label5);
            this.grp_Controles.Controls.Add(this.label4);
            this.grp_Controles.Controls.Add(this.label3);
            this.grp_Controles.Controls.Add(this.label2);
            this.grp_Controles.Controls.Add(this.label1);
            this.grp_Controles.Location = new System.Drawing.Point(15, 14);
            this.grp_Controles.Margin = new System.Windows.Forms.Padding(4);
            this.grp_Controles.Name = "grp_Controles";
            this.grp_Controles.Padding = new System.Windows.Forms.Padding(4);
            this.grp_Controles.Size = new System.Drawing.Size(671, 288);
            this.grp_Controles.TabIndex = 1;
            this.grp_Controles.TabStop = false;
            this.grp_Controles.Text = "groupBox1";
            // 
            // cmb_Tipo
            // 
            this.cmb_Tipo.FormattingEnabled = true;
            this.cmb_Tipo.Location = new System.Drawing.Point(191, 225);
            this.cmb_Tipo.Name = "cmb_Tipo";
            this.cmb_Tipo.Size = new System.Drawing.Size(473, 28);
            this.cmb_Tipo.TabIndex = 14;
            // 
            // txt_Clave
            // 
            this.txt_Clave.Location = new System.Drawing.Point(191, 191);
            this.txt_Clave.Name = "txt_Clave";
            this.txt_Clave.Size = new System.Drawing.Size(473, 26);
            this.txt_Clave.TabIndex = 12;
            // 
            // txt_Correo
            // 
            this.txt_Correo.Location = new System.Drawing.Point(191, 156);
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.Size = new System.Drawing.Size(473, 26);
            this.txt_Correo.TabIndex = 11;
            // 
            // txt_Celular
            // 
            this.txt_Celular.Location = new System.Drawing.Point(517, 108);
            this.txt_Celular.Name = "txt_Celular";
            this.txt_Celular.Size = new System.Drawing.Size(147, 26);
            this.txt_Celular.TabIndex = 10;
            // 
            // txt_Cedula
            // 
            this.txt_Cedula.Location = new System.Drawing.Point(191, 109);
            this.txt_Cedula.Name = "txt_Cedula";
            this.txt_Cedula.Size = new System.Drawing.Size(147, 26);
            this.txt_Cedula.TabIndex = 9;
            // 
            // txt_Apellidos
            // 
            this.txt_Apellidos.Location = new System.Drawing.Point(191, 65);
            this.txt_Apellidos.Name = "txt_Apellidos";
            this.txt_Apellidos.Size = new System.Drawing.Size(473, 26);
            this.txt_Apellidos.TabIndex = 8;
            // 
            // txt_Nombres
            // 
            this.txt_Nombres.Location = new System.Drawing.Point(191, 29);
            this.txt_Nombres.Name = "txt_Nombres";
            this.txt_Nombres.Size = new System.Drawing.Size(473, 26);
            this.txt_Nombres.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(73, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 27);
            this.label7.TabIndex = 6;
            this.label7.Text = "Clave Usada";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(67, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "Correo Usado";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(15, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Permisos Asociados";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(359, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Celular Trabajador";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(33, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cédula Trabajador";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(15, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos Trabajador";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres Trabajador";
            // 
            // grp_Botones
            // 
            this.grp_Botones.Controls.Add(this.btn_Eliminar);
            this.grp_Botones.Controls.Add(this.btn_Guardar);
            this.grp_Botones.Controls.Add(this.btn_Editar);
            this.grp_Botones.Controls.Add(this.btn_Nuevo);
            this.grp_Botones.Location = new System.Drawing.Point(698, 14);
            this.grp_Botones.Margin = new System.Windows.Forms.Padding(4);
            this.grp_Botones.Name = "grp_Botones";
            this.grp_Botones.Padding = new System.Windows.Forms.Padding(4);
            this.grp_Botones.Size = new System.Drawing.Size(285, 288);
            this.grp_Botones.TabIndex = 2;
            this.grp_Botones.TabStop = false;
            this.grp_Botones.Text = "Botones";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_Eliminar.Location = new System.Drawing.Point(16, 225);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(256, 58);
            this.btn_Eliminar.TabIndex = 3;
            this.btn_Eliminar.Text = "Eliminar Trabajador Seleccionado";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_Guardar.Location = new System.Drawing.Point(16, 159);
            this.btn_Guardar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(256, 58);
            this.btn_Guardar.TabIndex = 2;
            this.btn_Guardar.Text = "Guardar Cambios Realizados";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_Editar.Location = new System.Drawing.Point(16, 93);
            this.btn_Editar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(256, 58);
            this.btn_Editar.TabIndex = 1;
            this.btn_Editar.Text = "Modificar Trabajador Existente";
            this.btn_Editar.UseVisualStyleBackColor = false;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_Nuevo.Location = new System.Drawing.Point(16, 27);
            this.btn_Nuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(256, 58);
            this.btn_Nuevo.TabIndex = 0;
            this.btn_Nuevo.Text = "Crear Nuevo Trabajador";
            this.btn_Nuevo.UseVisualStyleBackColor = false;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // Frm_Hijo_Trabajadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.grp_Botones);
            this.Controls.Add(this.grp_Controles);
            this.Controls.Add(this.dgv_Trabajadores);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Hijo_Trabajadores";
            this.Text = "Frm_Hijo_Trabajadores";
            ((System.ComponentModel.ISupportInitialize) (this.dgv_Trabajadores)).EndInit();
            this.grp_Controles.ResumeLayout(false);
            this.grp_Controles.PerformLayout();
            this.grp_Botones.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Permisos;

        private System.Windows.Forms.ComboBox cmb_Tipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Apellidos;
        private System.Windows.Forms.TextBox txt_Cedula;
        private System.Windows.Forms.TextBox txt_Celular;
        private System.Windows.Forms.TextBox txt_Clave;
        private System.Windows.Forms.TextBox txt_Correo;
        private System.Windows.Forms.TextBox txt_Nombres;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.GroupBox grp_Controles;
        private System.Windows.Forms.GroupBox grp_Botones;

        private System.Windows.Forms.DataGridView dgv_Trabajadores;

        #endregion
    }
}