using System.ComponentModel;

namespace TallerMecanico_Forms {
    partial class Frm_Hijo_CompraProductos {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            this.grp_BuscarXNombre = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_BuscarXNombre = new System.Windows.Forms.ComboBox();
            this.btn_BuscarXNombre = new System.Windows.Forms.Button();
            this.txt_BuscarXNombre = new System.Windows.Forms.TextBox();
            this.grp_ProductosEnCola = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.dgv_ProductosAComprar = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.grp_Precios = new System.Windows.Forms.GroupBox();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grp_BuscarXNombre.SuspendLayout();
            this.grp_ProductosEnCola.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgv_ProductosAComprar)).BeginInit();
            this.grp_Precios.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_BuscarXNombre
            // 
            this.grp_BuscarXNombre.Controls.Add(this.label2);
            this.grp_BuscarXNombre.Controls.Add(this.label1);
            this.grp_BuscarXNombre.Controls.Add(this.cmb_BuscarXNombre);
            this.grp_BuscarXNombre.Controls.Add(this.btn_BuscarXNombre);
            this.grp_BuscarXNombre.Controls.Add(this.txt_BuscarXNombre);
            this.grp_BuscarXNombre.Location = new System.Drawing.Point(24, 21);
            this.grp_BuscarXNombre.Margin = new System.Windows.Forms.Padding(4);
            this.grp_BuscarXNombre.Name = "grp_BuscarXNombre";
            this.grp_BuscarXNombre.Padding = new System.Windows.Forms.Padding(4);
            this.grp_BuscarXNombre.Size = new System.Drawing.Size(625, 110);
            this.grp_BuscarXNombre.TabIndex = 0;
            this.grp_BuscarXNombre.TabStop = false;
            this.grp_BuscarXNombre.Text = "Buscar Producto por Nombre";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Resultados:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Busqueda:";
            // 
            // cmb_BuscarXNombre
            // 
            this.cmb_BuscarXNombre.FormattingEnabled = true;
            this.cmb_BuscarXNombre.Location = new System.Drawing.Point(181, 69);
            this.cmb_BuscarXNombre.Name = "cmb_BuscarXNombre";
            this.cmb_BuscarXNombre.Size = new System.Drawing.Size(434, 28);
            this.cmb_BuscarXNombre.TabIndex = 2;
            // 
            // btn_BuscarXNombre
            // 
            this.btn_BuscarXNombre.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_BuscarXNombre.FlatAppearance.BorderSize = 0;
            this.btn_BuscarXNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BuscarXNombre.Location = new System.Drawing.Point(528, 37);
            this.btn_BuscarXNombre.Name = "btn_BuscarXNombre";
            this.btn_BuscarXNombre.Size = new System.Drawing.Size(87, 26);
            this.btn_BuscarXNombre.TabIndex = 1;
            this.btn_BuscarXNombre.Text = "Buscar";
            this.btn_BuscarXNombre.UseVisualStyleBackColor = false;
            this.btn_BuscarXNombre.Click += new System.EventHandler(this.btn_BuscarXNombre_Click);
            // 
            // txt_BuscarXNombre
            // 
            this.txt_BuscarXNombre.Location = new System.Drawing.Point(181, 37);
            this.txt_BuscarXNombre.Name = "txt_BuscarXNombre";
            this.txt_BuscarXNombre.Size = new System.Drawing.Size(341, 26);
            this.txt_BuscarXNombre.TabIndex = 0;
            // 
            // grp_ProductosEnCola
            // 
            this.grp_ProductosEnCola.Controls.Add(this.button1);
            this.grp_ProductosEnCola.Controls.Add(this.btn_Limpiar);
            this.grp_ProductosEnCola.Controls.Add(this.dgv_ProductosAComprar);
            this.grp_ProductosEnCola.Location = new System.Drawing.Point(24, 254);
            this.grp_ProductosEnCola.Name = "grp_ProductosEnCola";
            this.grp_ProductosEnCola.Size = new System.Drawing.Size(625, 296);
            this.grp_ProductosEnCola.TabIndex = 1;
            this.grp_ProductosEnCola.TabStop = false;
            this.grp_ProductosEnCola.Text = "Productos a Comprar";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(463, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "Comprar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Limpiar.FlatAppearance.BorderSize = 0;
            this.btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Limpiar.Location = new System.Drawing.Point(6, 264);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(152, 26);
            this.btn_Limpiar.TabIndex = 5;
            this.btn_Limpiar.Text = "Limpiar Compras";
            this.btn_Limpiar.UseVisualStyleBackColor = false;
            // 
            // dgv_ProductosAComprar
            // 
            this.dgv_ProductosAComprar.AllowUserToDeleteRows = false;
            this.dgv_ProductosAComprar.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_ProductosAComprar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ProductosAComprar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ProductosAComprar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.IdProducto, this.Nombre, this.Cantidad, this.Valor});
            this.dgv_ProductosAComprar.Location = new System.Drawing.Point(7, 24);
            this.dgv_ProductosAComprar.Name = "dgv_ProductosAComprar";
            this.dgv_ProductosAComprar.ReadOnly = true;
            this.dgv_ProductosAComprar.RowTemplate.Height = 24;
            this.dgv_ProductosAComprar.Size = new System.Drawing.Size(605, 234);
            this.dgv_ProductosAComprar.TabIndex = 0;
            // 
            // IdProducto
            // 
            this.IdProducto.Frozen = true;
            this.IdProducto.HeaderText = "Código de Producto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.Frozen = true;
            this.Nombre.HeaderText = "Nombre del Producto";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.Frozen = true;
            this.Cantidad.HeaderText = "Cantidad a Comprar";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.Frozen = true;
            this.Valor.HeaderText = "Valor Unitario";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Agregar.FlatAppearance.BorderSize = 0;
            this.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Agregar.Location = new System.Drawing.Point(322, 56);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(293, 26);
            this.btn_Agregar.TabIndex = 5;
            this.btn_Agregar.Text = "Agregar a Posibilidad de Compra";
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // grp_Precios
            // 
            this.grp_Precios.Controls.Add(this.txt_Precio);
            this.grp_Precios.Controls.Add(this.label4);
            this.grp_Precios.Controls.Add(this.txt_Cantidad);
            this.grp_Precios.Controls.Add(this.label3);
            this.grp_Precios.Controls.Add(this.btn_Agregar);
            this.grp_Precios.Location = new System.Drawing.Point(24, 138);
            this.grp_Precios.Name = "grp_Precios";
            this.grp_Precios.Size = new System.Drawing.Size(625, 100);
            this.grp_Precios.TabIndex = 2;
            this.grp_Precios.TabStop = false;
            this.grp_Precios.Text = "Cantidades y Precios";
            // 
            // txt_Precio
            // 
            this.txt_Precio.Location = new System.Drawing.Point(455, 19);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(160, 26);
            this.txt_Precio.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(322, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Precio Unitario:";
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(107, 21);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(160, 26);
            this.txt_Cantidad.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(14, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cantidad:";
            // 
            // Frm_Hijo_CompraProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 562);
            this.Controls.Add(this.grp_Precios);
            this.Controls.Add(this.grp_ProductosEnCola);
            this.Controls.Add(this.grp_BuscarXNombre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Hijo_CompraProductos";
            this.Text = "Frm_Hijo_CompraProductos";
            this.grp_BuscarXNombre.ResumeLayout(false);
            this.grp_BuscarXNombre.PerformLayout();
            this.grp_ProductosEnCola.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgv_ProductosAComprar)).EndInit();
            this.grp_Precios.ResumeLayout(false);
            this.grp_Precios.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;

        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;

        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.GroupBox grp_Precios;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.TextBox txt_Precio;

        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.DataGridView dgv_ProductosAComprar;

        private System.Windows.Forms.GroupBox grp_ProductosEnCola;

        private System.Windows.Forms.ComboBox cmb_BuscarXNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button btn_BuscarXNombre;
        private System.Windows.Forms.TextBox txt_BuscarXNombre;

        private System.Windows.Forms.GroupBox grp_BuscarXNombre;

        #endregion
    }
}