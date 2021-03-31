namespace TallerMecanico_Forms
{
    partial class Frm_ProductoProveedor
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
            this.grp_Controles = new System.Windows.Forms.GroupBox();
            this.PROVEEDOR = new System.Windows.Forms.Label();
            this.cmb_Proveedor = new System.Windows.Forms.ComboBox();
            this.cmb_Producto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grp_Botones = new System.Windows.Forms.GroupBox();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.dgv_ProductosProveedores = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp_Controles.SuspendLayout();
            this.grp_Botones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductosProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_Controles
            // 
            this.grp_Controles.Controls.Add(this.PROVEEDOR);
            this.grp_Controles.Controls.Add(this.cmb_Proveedor);
            this.grp_Controles.Controls.Add(this.cmb_Producto);
            this.grp_Controles.Controls.Add(this.label1);
            this.grp_Controles.Location = new System.Drawing.Point(13, 13);
            this.grp_Controles.Margin = new System.Windows.Forms.Padding(4);
            this.grp_Controles.Name = "grp_Controles";
            this.grp_Controles.Padding = new System.Windows.Forms.Padding(4);
            this.grp_Controles.Size = new System.Drawing.Size(301, 167);
            this.grp_Controles.TabIndex = 2;
            this.grp_Controles.TabStop = false;
            this.grp_Controles.Text = "Bloqueado";
            // 
            // PROVEEDOR
            // 
            this.PROVEEDOR.Location = new System.Drawing.Point(19, 119);
            this.PROVEEDOR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PROVEEDOR.Name = "PROVEEDOR";
            this.PROVEEDOR.Size = new System.Drawing.Size(79, 24);
            this.PROVEEDOR.TabIndex = 5;
            this.PROVEEDOR.Text = "PROVEEDOR";
            this.PROVEEDOR.Click += new System.EventHandler(this.PROVEEDOR_Click);
            // 
            // cmb_Proveedor
            // 
            this.cmb_Proveedor.FormattingEnabled = true;
            this.cmb_Proveedor.Location = new System.Drawing.Point(106, 119);
            this.cmb_Proveedor.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Proveedor.Name = "cmb_Proveedor";
            this.cmb_Proveedor.Size = new System.Drawing.Size(171, 21);
            this.cmb_Proveedor.TabIndex = 4;
            // 
            // cmb_Producto
            // 
            this.cmb_Producto.FormattingEnabled = true;
            this.cmb_Producto.Location = new System.Drawing.Point(106, 67);
            this.cmb_Producto.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Producto.Name = "cmb_Producto";
            this.cmb_Producto.Size = new System.Drawing.Size(171, 21);
            this.cmb_Producto.TabIndex = 3;
            this.cmb_Producto.SelectedIndexChanged += new System.EventHandler(this.cmb_Producto_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(19, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "PRODUCTO";
            // 
            // grp_Botones
            // 
            this.grp_Botones.Controls.Add(this.btn_Cerrar);
            this.grp_Botones.Controls.Add(this.btn_Eliminar);
            this.grp_Botones.Controls.Add(this.btn_Guardar);
            this.grp_Botones.Controls.Add(this.btn_Editar);
            this.grp_Botones.Controls.Add(this.btn_Nuevo);
            this.grp_Botones.Location = new System.Drawing.Point(322, 4);
            this.grp_Botones.Margin = new System.Windows.Forms.Padding(4);
            this.grp_Botones.Name = "grp_Botones";
            this.grp_Botones.Padding = new System.Windows.Forms.Padding(4);
            this.grp_Botones.Size = new System.Drawing.Size(182, 176);
            this.grp_Botones.TabIndex = 5;
            this.grp_Botones.TabStop = false;
            this.grp_Botones.Text = "Botones de Control";
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.Location = new System.Drawing.Point(15, 144);
            this.btn_Cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(140, 20);
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
            this.btn_Eliminar.Location = new System.Drawing.Point(15, 116);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(140, 20);
            this.btn_Eliminar.TabIndex = 3;
            this.btn_Eliminar.Text = "Eliminar Relacion";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Guardar.FlatAppearance.BorderSize = 0;
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guardar.Location = new System.Drawing.Point(15, 88);
            this.btn_Guardar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(140, 20);
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
            this.btn_Editar.Location = new System.Drawing.Point(15, 60);
            this.btn_Editar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(140, 20);
            this.btn_Editar.TabIndex = 1;
            this.btn_Editar.Text = "Editar";
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
            this.btn_Nuevo.Size = new System.Drawing.Size(140, 20);
            this.btn_Nuevo.TabIndex = 0;
            this.btn_Nuevo.Text = "Nuva Relacion PP";
            this.btn_Nuevo.UseVisualStyleBackColor = false;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // dgv_ProductosProveedores
            // 
            this.dgv_ProductosProveedores.AllowUserToOrderColumns = true;
            this.dgv_ProductosProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ProductosProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.provee,
            this.Producto});
            this.dgv_ProductosProveedores.Location = new System.Drawing.Point(13, 216);
            this.dgv_ProductosProveedores.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_ProductosProveedores.Name = "dgv_ProductosProveedores";
            this.dgv_ProductosProveedores.RowTemplate.Height = 24;
            this.dgv_ProductosProveedores.Size = new System.Drawing.Size(491, 124);
            this.dgv_ProductosProveedores.TabIndex = 4;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // provee
            // 
            this.provee.HeaderText = "Proveedor";
            this.provee.Name = "provee";
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            // 
            // Frm_ProductoProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 359);
            this.Controls.Add(this.grp_Botones);
            this.Controls.Add(this.dgv_ProductosProveedores);
            this.Controls.Add(this.grp_Controles);
            this.Name = "Frm_ProductoProveedor";
            this.Text = "Frm_ProductoProveedor";
            this.grp_Controles.ResumeLayout(false);
            this.grp_Botones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductosProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_Controles;
        private System.Windows.Forms.ComboBox cmb_Producto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PROVEEDOR;
        private System.Windows.Forms.ComboBox cmb_Proveedor;
        private System.Windows.Forms.GroupBox grp_Botones;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.DataGridView dgv_ProductosProveedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn provee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
    }
}