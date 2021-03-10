using System.ComponentModel;

namespace TallerMecanico_Forms
{
    partial class Frm_Hijo_Producto
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grp_Controles = new System.Windows.Forms.GroupBox();
            this.cmb_Categoria = new System.Windows.Forms.ComboBox();
            this.lbl_Categoria = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.grp_Botones = new System.Windows.Forms.GroupBox();
            this.lbl_Venta = new System.Windows.Forms.Label();
            this.txt_Venta = new System.Windows.Forms.TextBox();
            this.lbl_Compra = new System.Windows.Forms.Label();
            this.txt_Compra = new System.Windows.Forms.TextBox();
            this.lbl_Marca = new System.Windows.Forms.Label();
            this.txt_Marca = new System.Windows.Forms.TextBox();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.grp_Controles.SuspendLayout();
            this.grp_Botones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 345);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(970, 202);
            this.dataGridView1.TabIndex = 0;
            // 
            // grp_Controles
            // 
            this.grp_Controles.Controls.Add(this.txt_Descripcion);
            this.grp_Controles.Controls.Add(this.lbl_Descripcion);
            this.grp_Controles.Controls.Add(this.txt_Marca);
            this.grp_Controles.Controls.Add(this.lbl_Marca);
            this.grp_Controles.Controls.Add(this.txt_Compra);
            this.grp_Controles.Controls.Add(this.lbl_Compra);
            this.grp_Controles.Controls.Add(this.txt_Venta);
            this.grp_Controles.Controls.Add(this.lbl_Venta);
            this.grp_Controles.Controls.Add(this.cmb_Categoria);
            this.grp_Controles.Controls.Add(this.lbl_Categoria);
            this.grp_Controles.Controls.Add(this.textBox1);
            this.grp_Controles.Controls.Add(this.lbl_Nombre);
            this.grp_Controles.Location = new System.Drawing.Point(15, 19);
            this.grp_Controles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grp_Controles.Name = "grp_Controles";
            this.grp_Controles.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grp_Controles.Size = new System.Drawing.Size(674, 319);
            this.grp_Controles.TabIndex = 1;
            this.grp_Controles.TabStop = false;
            this.grp_Controles.Text = "Bloqueado";
            // 
            // cmb_Categoria
            // 
            this.cmb_Categoria.FormattingEnabled = true;
            this.cmb_Categoria.Location = new System.Drawing.Point(189, 70);
            this.cmb_Categoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_Categoria.Name = "cmb_Categoria";
            this.cmb_Categoria.Size = new System.Drawing.Size(475, 28);
            this.cmb_Categoria.TabIndex = 3;
            // 
            // lbl_Categoria
            // 
            this.lbl_Categoria.Location = new System.Drawing.Point(19, 74);
            this.lbl_Categoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Categoria.Name = "lbl_Categoria";
            this.lbl_Categoria.Size = new System.Drawing.Size(121, 24);
            this.lbl_Categoria.TabIndex = 2;
            this.lbl_Categoria.Text = "Categoria";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(189, 34);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(476, 26);
            this.textBox1.TabIndex = 1;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.Location = new System.Drawing.Point(19, 34);
            this.lbl_Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(126, 28);
            this.lbl_Nombre.TabIndex = 0;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // grp_Botones
            // 
            this.grp_Botones.Controls.Add(this.btn_Cerrar);
            this.grp_Botones.Controls.Add(this.btn_Eliminar);
            this.grp_Botones.Controls.Add(this.btn_Guardar);
            this.grp_Botones.Controls.Add(this.btn_Editar);
            this.grp_Botones.Controls.Add(this.btn_Nuevo);
            this.grp_Botones.Location = new System.Drawing.Point(716, 19);
            this.grp_Botones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grp_Botones.Name = "grp_Botones";
            this.grp_Botones.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grp_Botones.Size = new System.Drawing.Size(268, 318);
            this.grp_Botones.TabIndex = 2;
            this.grp_Botones.TabStop = false;
            this.grp_Botones.Text = "Botones de Control";
            // 
            // lbl_Venta
            // 
            this.lbl_Venta.Location = new System.Drawing.Point(19, 116);
            this.lbl_Venta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Venta.Name = "lbl_Venta";
            this.lbl_Venta.Size = new System.Drawing.Size(140, 35);
            this.lbl_Venta.TabIndex = 4;
            this.lbl_Venta.Text = "V.Venta";
            // 
            // txt_Venta
            // 
            this.txt_Venta.Location = new System.Drawing.Point(189, 116);
            this.txt_Venta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Venta.Name = "txt_Venta";
            this.txt_Venta.Size = new System.Drawing.Size(159, 26);
            this.txt_Venta.TabIndex = 5;
            // 
            // lbl_Compra
            // 
            this.lbl_Compra.Location = new System.Drawing.Point(369, 116);
            this.lbl_Compra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Compra.Name = "lbl_Compra";
            this.lbl_Compra.Size = new System.Drawing.Size(140, 35);
            this.lbl_Compra.TabIndex = 6;
            this.lbl_Compra.Text = "V.Compra";
            // 
            // txt_Compra
            // 
            this.txt_Compra.Location = new System.Drawing.Point(505, 116);
            this.txt_Compra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Compra.Name = "txt_Compra";
            this.txt_Compra.Size = new System.Drawing.Size(159, 26);
            this.txt_Compra.TabIndex = 7;
            // 
            // lbl_Marca
            // 
            this.lbl_Marca.Location = new System.Drawing.Point(19, 168);
            this.lbl_Marca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Marca.Name = "lbl_Marca";
            this.lbl_Marca.Size = new System.Drawing.Size(109, 35);
            this.lbl_Marca.TabIndex = 8;
            this.lbl_Marca.Text = "Marca";
            // 
            // txt_Marca
            // 
            this.txt_Marca.Location = new System.Drawing.Point(189, 168);
            this.txt_Marca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Marca.Name = "txt_Marca";
            this.txt_Marca.Size = new System.Drawing.Size(476, 26);
            this.txt_Marca.TabIndex = 9;
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.Location = new System.Drawing.Point(19, 214);
            this.lbl_Descripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(109, 35);
            this.lbl_Descripcion.TabIndex = 10;
            this.lbl_Descripcion.Text = "Descripcion";
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(189, 214);
            this.txt_Descripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Descripcion.Multiline = true;
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(476, 96);
            this.txt_Descripcion.TabIndex = 11;
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Nuevo.FlatAppearance.BorderSize = 0;
            this.btn_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Nuevo.Location = new System.Drawing.Point(15, 32);
            this.btn_Nuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(240, 41);
            this.btn_Nuevo.TabIndex = 0;
            this.btn_Nuevo.Text = "Crear Nuevo Producto";
            this.btn_Nuevo.UseVisualStyleBackColor = false;
            // 
            // btn_Editar
            // 
            this.btn_Editar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Editar.FlatAppearance.BorderSize = 0;
            this.btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Editar.Location = new System.Drawing.Point(15, 81);
            this.btn_Editar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(240, 41);
            this.btn_Editar.TabIndex = 1;
            this.btn_Editar.Text = "Editar Producto";
            this.btn_Editar.UseVisualStyleBackColor = false;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Guardar.FlatAppearance.BorderSize = 0;
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guardar.Location = new System.Drawing.Point(15, 130);
            this.btn_Guardar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(240, 41);
            this.btn_Guardar.TabIndex = 2;
            this.btn_Guardar.Text = "Guardar Cambios";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminar.Location = new System.Drawing.Point(15, 179);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(240, 41);
            this.btn_Eliminar.TabIndex = 3;
            this.btn_Eliminar.Text = "Eliminar Producto";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.Location = new System.Drawing.Point(15, 228);
            this.btn_Cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(240, 41);
            this.btn_Cerrar.TabIndex = 4;
            this.btn_Cerrar.Text = "Cerrar Formulario";
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            // 
            // Frm_Hijo_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.grp_Botones);
            this.Controls.Add(this.grp_Controles);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_Hijo_Producto";
            this.Text = "Frm_Hijo_Producto";
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.grp_Controles.ResumeLayout(false);
            this.grp_Controles.PerformLayout();
            this.grp_Botones.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Guardar;

        private System.Windows.Forms.Button btn_Nuevo;

        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.Label lbl_Marca;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.TextBox txt_Marca;

        private System.Windows.Forms.Label lbl_Compra;
        private System.Windows.Forms.Label lbl_Venta;
        private System.Windows.Forms.TextBox txt_Compra;
        private System.Windows.Forms.TextBox txt_Venta;

        private System.Windows.Forms.ComboBox cmb_Categoria;

        private System.Windows.Forms.Label lbl_Categoria;

        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.GroupBox grp_Controles;
        private System.Windows.Forms.GroupBox grp_Botones;

        private System.Windows.Forms.DataGridView dataGridView1;

        #endregion
    }
}