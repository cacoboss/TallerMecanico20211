
namespace TallerMecanico_Forms
{
    partial class Frm_Hijo_Cliente
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
            this.grp_Botones = new System.Windows.Forms.GroupBox();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.dgv_Cliente = new System.Windows.Forms.DataGridView();
            this.ID_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.txt_Nombres = new System.Windows.Forms.TextBox();
            this.lbl_Categoria = new System.Windows.Forms.Label();
            this.lbl_Venta = new System.Windows.Forms.Label();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.lbl_Marca = new System.Windows.Forms.Label();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Apellidos = new System.Windows.Forms.TextBox();
            this.grp_Controles = new System.Windows.Forms.GroupBox();
            this.grp_Botones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cliente)).BeginInit();
            this.grp_Controles.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_Botones
            // 
            this.grp_Botones.Controls.Add(this.btn_Cerrar);
            this.grp_Botones.Controls.Add(this.btn_Eliminar);
            this.grp_Botones.Controls.Add(this.btn_Guardar);
            this.grp_Botones.Controls.Add(this.btn_Editar);
            this.grp_Botones.Controls.Add(this.btn_Nuevo);
            this.grp_Botones.Location = new System.Drawing.Point(377, 13);
            this.grp_Botones.Margin = new System.Windows.Forms.Padding(4);
            this.grp_Botones.Name = "grp_Botones";
            this.grp_Botones.Padding = new System.Windows.Forms.Padding(4);
            this.grp_Botones.Size = new System.Drawing.Size(208, 316);
            this.grp_Botones.TabIndex = 3;
            this.grp_Botones.TabStop = false;
            this.grp_Botones.Text = "Botones de Control";
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.Location = new System.Drawing.Point(15, 274);
            this.btn_Cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(177, 31);
            this.btn_Cerrar.TabIndex = 4;
            this.btn_Cerrar.Text = "Cerrar Formulario";
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminar.Location = new System.Drawing.Point(15, 214);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(177, 31);
            this.btn_Eliminar.TabIndex = 3;
            this.btn_Eliminar.Text = "Eliminar Producto";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Guardar.FlatAppearance.BorderSize = 0;
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guardar.Location = new System.Drawing.Point(13, 150);
            this.btn_Guardar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(177, 31);
            this.btn_Guardar.TabIndex = 2;
            this.btn_Guardar.Text = "Guardar Cambios";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Editar.FlatAppearance.BorderSize = 0;
            this.btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Editar.Location = new System.Drawing.Point(15, 95);
            this.btn_Editar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(177, 31);
            this.btn_Editar.TabIndex = 1;
            this.btn_Editar.Text = "Editar Producto";
            this.btn_Editar.UseVisualStyleBackColor = false;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Nuevo.FlatAppearance.BorderSize = 0;
            this.btn_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Nuevo.Location = new System.Drawing.Point(15, 32);
            this.btn_Nuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(177, 31);
            this.btn_Nuevo.TabIndex = 0;
            this.btn_Nuevo.Text = "Crear Nuevo Producto";
            this.btn_Nuevo.UseVisualStyleBackColor = false;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // dgv_Cliente
            // 
            this.dgv_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Cliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Producto,
            this.Nombres,
            this.Apellidos,
            this.Direccion,
            this.Telefono,
            this.Email});
            this.dgv_Cliente.Location = new System.Drawing.Point(13, 337);
            this.dgv_Cliente.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Cliente.Name = "dgv_Cliente";
            this.dgv_Cliente.RowTemplate.Height = 24;
            this.dgv_Cliente.Size = new System.Drawing.Size(655, 124);
            this.dgv_Cliente.TabIndex = 4;
            // 
            // ID_Producto
            // 
            this.ID_Producto.HeaderText = "ID";
            this.ID_Producto.Name = "ID_Producto";
            this.ID_Producto.ReadOnly = true;
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
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.Location = new System.Drawing.Point(19, 58);
            this.lbl_Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(56, 20);
            this.lbl_Nombre.TabIndex = 0;
            this.lbl_Nombre.Text = "Nombres";
            // 
            // txt_Nombres
            // 
            this.txt_Nombres.Location = new System.Drawing.Point(124, 55);
            this.txt_Nombres.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Nombres.Name = "txt_Nombres";
            this.txt_Nombres.Size = new System.Drawing.Size(203, 20);
            this.txt_Nombres.TabIndex = 1;
            // 
            // lbl_Categoria
            // 
            this.lbl_Categoria.Location = new System.Drawing.Point(19, 109);
            this.lbl_Categoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Categoria.Name = "lbl_Categoria";
            this.lbl_Categoria.Size = new System.Drawing.Size(56, 17);
            this.lbl_Categoria.TabIndex = 2;
            this.lbl_Categoria.Text = "Appellidos";
            // 
            // lbl_Venta
            // 
            this.lbl_Venta.Location = new System.Drawing.Point(19, 164);
            this.lbl_Venta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Venta.Name = "lbl_Venta";
            this.lbl_Venta.Size = new System.Drawing.Size(56, 20);
            this.lbl_Venta.TabIndex = 4;
            this.lbl_Venta.Text = "Direccion";
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Location = new System.Drawing.Point(124, 161);
            this.txt_Direccion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(203, 20);
            this.txt_Direccion.TabIndex = 5;
            // 
            // lbl_Marca
            // 
            this.lbl_Marca.Location = new System.Drawing.Point(19, 217);
            this.lbl_Marca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Marca.Name = "lbl_Marca";
            this.lbl_Marca.Size = new System.Drawing.Size(56, 20);
            this.lbl_Marca.TabIndex = 8;
            this.lbl_Marca.Text = "Telefono";
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Location = new System.Drawing.Point(124, 214);
            this.txt_Telefono.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(203, 20);
            this.txt_Telefono.TabIndex = 9;
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.Location = new System.Drawing.Point(19, 261);
            this.lbl_Descripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(56, 21);
            this.lbl_Descripcion.TabIndex = 10;
            this.lbl_Descripcion.Text = "Email";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(124, 258);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Email.Multiline = true;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(203, 21);
            this.txt_Email.TabIndex = 11;
            // 
            // txt_Apellidos
            // 
            this.txt_Apellidos.Location = new System.Drawing.Point(124, 106);
            this.txt_Apellidos.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Apellidos.Name = "txt_Apellidos";
            this.txt_Apellidos.Size = new System.Drawing.Size(203, 20);
            this.txt_Apellidos.TabIndex = 12;
            // 
            // grp_Controles
            // 
            this.grp_Controles.Controls.Add(this.txt_Apellidos);
            this.grp_Controles.Controls.Add(this.txt_Email);
            this.grp_Controles.Controls.Add(this.lbl_Descripcion);
            this.grp_Controles.Controls.Add(this.txt_Telefono);
            this.grp_Controles.Controls.Add(this.lbl_Marca);
            this.grp_Controles.Controls.Add(this.txt_Direccion);
            this.grp_Controles.Controls.Add(this.lbl_Venta);
            this.grp_Controles.Controls.Add(this.lbl_Categoria);
            this.grp_Controles.Controls.Add(this.txt_Nombres);
            this.grp_Controles.Controls.Add(this.lbl_Nombre);
            this.grp_Controles.Location = new System.Drawing.Point(13, 13);
            this.grp_Controles.Margin = new System.Windows.Forms.Padding(4);
            this.grp_Controles.Name = "grp_Controles";
            this.grp_Controles.Padding = new System.Windows.Forms.Padding(4);
            this.grp_Controles.Size = new System.Drawing.Size(356, 316);
            this.grp_Controles.TabIndex = 2;
            this.grp_Controles.TabStop = false;
            this.grp_Controles.Text = "Bloqueado";
            // 
            // Frm_Hijo_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 565);
            this.Controls.Add(this.dgv_Cliente);
            this.Controls.Add(this.grp_Botones);
            this.Controls.Add(this.grp_Controles);
            this.Name = "Frm_Hijo_Cliente";
            this.Text = "Frm_Hijo_Cliente";
            this.grp_Botones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cliente)).EndInit();
            this.grp_Controles.ResumeLayout(false);
            this.grp_Controles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grp_Botones;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.DataGridView dgv_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Producto;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.TextBox txt_Nombres;
        private System.Windows.Forms.Label lbl_Categoria;
        private System.Windows.Forms.Label lbl_Venta;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.Label lbl_Marca;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Apellidos;
        private System.Windows.Forms.GroupBox grp_Controles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}