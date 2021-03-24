using System.ComponentModel;

namespace TallerMecanico_Forms
{
    partial class Frm_Hijo_Proveedor
    {
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
        private void InitializeComponent()
        {
            this.dgv_Datos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp_DatosEntrada = new System.Windows.Forms.GroupBox();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.grp_Botones = new System.Windows.Forms.GroupBox();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Datos)).BeginInit();
            this.grp_DatosEntrada.SuspendLayout();
            this.grp_Botones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Datos
            // 
            this.dgv_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Descripcion});
            this.dgv_Datos.Location = new System.Drawing.Point(39, 190);
            this.dgv_Datos.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Datos.Name = "dgv_Datos";
            this.dgv_Datos.RowTemplate.Height = 24;
            this.dgv_Datos.Size = new System.Drawing.Size(512, 158);
            this.dgv_Datos.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre Proveedor";
            this.Nombre.Name = "Nombre";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion Proveedor";
            this.Descripcion.Name = "Descripcion";
            // 
            // grp_DatosEntrada
            // 
            this.grp_DatosEntrada.Controls.Add(this.txt_Descripcion);
            this.grp_DatosEntrada.Controls.Add(this.txt_Nombre);
            this.grp_DatosEntrada.Controls.Add(this.lbl_Descripcion);
            this.grp_DatosEntrada.Controls.Add(this.lbl_Nombre);
            this.grp_DatosEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_DatosEntrada.Location = new System.Drawing.Point(39, 16);
            this.grp_DatosEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.grp_DatosEntrada.Name = "grp_DatosEntrada";
            this.grp_DatosEntrada.Padding = new System.Windows.Forms.Padding(2);
            this.grp_DatosEntrada.Size = new System.Drawing.Size(340, 152);
            this.grp_DatosEntrada.TabIndex = 1;
            this.grp_DatosEntrada.TabStop = false;
            this.grp_DatosEntrada.Text = "Modo: ";
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(136, 51);
            this.txt_Descripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Descripcion.Multiline = true;
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(200, 91);
            this.txt_Descripcion.TabIndex = 3;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(136, 25);
            this.txt_Nombre.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(201, 21);
            this.txt_Nombre.TabIndex = 2;
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.Location = new System.Drawing.Point(18, 52);
            this.lbl_Descripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(66, 21);
            this.lbl_Descripcion.TabIndex = 1;
            this.lbl_Descripcion.Text = "Descripcion";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.Location = new System.Drawing.Point(18, 28);
            this.lbl_Nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(107, 16);
            this.lbl_Nombre.TabIndex = 0;
            this.lbl_Nombre.Text = "Nombre Proveedor";
            // 
            // grp_Botones
            // 
            this.grp_Botones.Controls.Add(this.btn_Cerrar);
            this.grp_Botones.Controls.Add(this.btn_Eliminar);
            this.grp_Botones.Controls.Add(this.btn_Guardar);
            this.grp_Botones.Controls.Add(this.btn_Nuevo);
            this.grp_Botones.Controls.Add(this.btn_Editar);
            this.grp_Botones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Botones.Location = new System.Drawing.Point(401, 16);
            this.grp_Botones.Margin = new System.Windows.Forms.Padding(2);
            this.grp_Botones.Name = "grp_Botones";
            this.grp_Botones.Padding = new System.Windows.Forms.Padding(2);
            this.grp_Botones.Size = new System.Drawing.Size(149, 151);
            this.grp_Botones.TabIndex = 2;
            this.grp_Botones.TabStop = false;
            this.grp_Botones.Text = "Controles";
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.Location = new System.Drawing.Point(18, 124);
            this.btn_Cerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(107, 22);
            this.btn_Cerrar.TabIndex = 5;
            this.btn_Cerrar.Text = "Cerrar Form";
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminar.Location = new System.Drawing.Point(18, 98);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(107, 22);
            this.btn_Eliminar.TabIndex = 4;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Guardar.FlatAppearance.BorderSize = 0;
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guardar.Location = new System.Drawing.Point(18, 71);
            this.btn_Guardar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(107, 22);
            this.btn_Guardar.TabIndex = 3;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Nuevo.FlatAppearance.BorderSize = 0;
            this.btn_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nuevo.Location = new System.Drawing.Point(18, 17);
            this.btn_Nuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(107, 22);
            this.btn_Nuevo.TabIndex = 2;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = false;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Editar.FlatAppearance.BorderSize = 0;
            this.btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editar.Location = new System.Drawing.Point(18, 44);
            this.btn_Editar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(107, 22);
            this.btn_Editar.TabIndex = 1;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = false;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // Frm_Hijo_Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.grp_Botones);
            this.Controls.Add(this.grp_DatosEntrada);
            this.Controls.Add(this.dgv_Datos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_Hijo_Proveedor";
            this.Text = "Frm_Hijo_Proveedor";
            this.Load += new System.EventHandler(this.Frm_Hijo_Proveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Datos)).EndInit();
            this.grp_DatosEntrada.ResumeLayout(false);
            this.grp_DatosEntrada.PerformLayout();
            this.grp_Botones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;

        private System.Windows.Forms.DataGridViewTextBoxColumn ID;

        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Cerrar;

        private System.Windows.Forms.Button btn_Editar;

        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Descripcion;

        private System.Windows.Forms.GroupBox grp_Botones;
        private System.Windows.Forms.GroupBox grp_DatosEntrada;

        private System.Windows.Forms.DataGridView dgv_Datos;

        #endregion
    }
}