namespace Negocio.ui.Invetario_screen
{
    partial class InsertarForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.margenBeneficio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMargenBenificio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtNombreArticulo = new System.Windows.Forms.TextBox();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.txtUnidadMedida = new System.Windows.Forms.TextBox();
            this.txtFamilia = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtCodArticulo = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBuscarArticulo = new System.Windows.Forms.Button();
            this.txtCodigoArticulo = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.insertarMercancia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codArticulo,
            this.nombreArticulo,
            this.Cantidad,
            this.familia,
            this.unidadMedida,
            this.precioCompra,
            this.margenBeneficio,
            this.precioVenta});
            this.dataGridView1.Location = new System.Drawing.Point(45, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1060, 517);
            this.dataGridView1.TabIndex = 0;
            // 
            // codArticulo
            // 
            this.codArticulo.HeaderText = "Codigo Articulo";
            this.codArticulo.Name = "codArticulo";
            this.codArticulo.Width = 135;
            // 
            // nombreArticulo
            // 
            this.nombreArticulo.HeaderText = "Nombre Articulo";
            this.nombreArticulo.Name = "nombreArticulo";
            this.nombreArticulo.Width = 135;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // familia
            // 
            this.familia.HeaderText = "Familia";
            this.familia.Name = "familia";
            // 
            // unidadMedida
            // 
            this.unidadMedida.HeaderText = "Unidad Medida";
            this.unidadMedida.Name = "unidadMedida";
            this.unidadMedida.Width = 135;
            // 
            // precioCompra
            // 
            this.precioCompra.HeaderText = "Precio Compra";
            this.precioCompra.Name = "precioCompra";
            this.precioCompra.Width = 135;
            // 
            // margenBeneficio
            // 
            this.margenBeneficio.HeaderText = "Margen Beneficio";
            this.margenBeneficio.Name = "margenBeneficio";
            this.margenBeneficio.Width = 145;
            // 
            // precioVenta
            // 
            this.precioVenta.HeaderText = "Precio Venta";
            this.precioVenta.Name = "precioVenta";
            this.precioVenta.Width = 135;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(138)))), ((int)(((byte)(71)))));
            this.btnRegresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(49, 745);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(192, 49);
            this.btnRegresar.TabIndex = 13;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtMargenBenificio);
            this.panel1.Controls.Add(this.btnInsertar);
            this.panel1.Controls.Add(this.txtCantidad);
            this.panel1.Controls.Add(this.txtNombreArticulo);
            this.panel1.Controls.Add(this.txtPrecioCompra);
            this.panel1.Controls.Add(this.txtUnidadMedida);
            this.panel1.Controls.Add(this.txtFamilia);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.txtCodArticulo);
            this.panel1.Location = new System.Drawing.Point(1146, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 755);
            this.panel1.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(24, 576);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Margen Beneficio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(35, 490);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Precio Compra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(33, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Unidad Medida";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(55, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Familia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(46, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nombre Articulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Codigo Articulo";
            // 
            // txtMargenBenificio
            // 
            this.txtMargenBenificio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMargenBenificio.Location = new System.Drawing.Point(156, 576);
            this.txtMargenBenificio.Margin = new System.Windows.Forms.Padding(2);
            this.txtMargenBenificio.Name = "txtMargenBenificio";
            this.txtMargenBenificio.Size = new System.Drawing.Size(206, 26);
            this.txtMargenBenificio.TabIndex = 7;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCantidad.Location = new System.Drawing.Point(156, 226);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(206, 26);
            this.txtCantidad.TabIndex = 3;
            // 
            // txtNombreArticulo
            // 
            this.txtNombreArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNombreArticulo.Location = new System.Drawing.Point(156, 135);
            this.txtNombreArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreArticulo.Name = "txtNombreArticulo";
            this.txtNombreArticulo.Size = new System.Drawing.Size(206, 26);
            this.txtNombreArticulo.TabIndex = 2;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPrecioCompra.Location = new System.Drawing.Point(156, 490);
            this.txtPrecioCompra.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(206, 26);
            this.txtPrecioCompra.TabIndex = 6;
            // 
            // txtUnidadMedida
            // 
            this.txtUnidadMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUnidadMedida.Location = new System.Drawing.Point(156, 403);
            this.txtUnidadMedida.Margin = new System.Windows.Forms.Padding(2);
            this.txtUnidadMedida.Name = "txtUnidadMedida";
            this.txtUnidadMedida.Size = new System.Drawing.Size(206, 26);
            this.txtUnidadMedida.TabIndex = 5;
            // 
            // txtFamilia
            // 
            this.txtFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFamilia.Location = new System.Drawing.Point(156, 316);
            this.txtFamilia.Margin = new System.Windows.Forms.Padding(2);
            this.txtFamilia.Name = "txtFamilia";
            this.txtFamilia.Size = new System.Drawing.Size(206, 26);
            this.txtFamilia.TabIndex = 4;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(221, 689);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(141, 47);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // txtCodArticulo
            // 
            this.txtCodArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCodArticulo.Location = new System.Drawing.Point(156, 48);
            this.txtCodArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodArticulo.Name = "txtCodArticulo";
            this.txtCodArticulo.Size = new System.Drawing.Size(206, 26);
            this.txtCodArticulo.TabIndex = 1;
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(171)))), ((int)(((byte)(55)))));
            this.btnInsertar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnInsertar.ForeColor = System.Drawing.Color.White;
            this.btnInsertar.Location = new System.Drawing.Point(38, 689);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(168, 47);
            this.btnInsertar.TabIndex = 8;
            this.btnInsertar.Text = "Insertar Mercancia";
            this.btnInsertar.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(644, 666);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 24);
            this.label8.TabIndex = 31;
            this.label8.Text = "Buscar producto";
            // 
            // btnBuscarArticulo
            // 
            this.btnBuscarArticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(142)))), ((int)(((byte)(202)))));
            this.btnBuscarArticulo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnBuscarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnBuscarArticulo.ForeColor = System.Drawing.Color.White;
            this.btnBuscarArticulo.Location = new System.Drawing.Point(828, 747);
            this.btnBuscarArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarArticulo.Name = "btnBuscarArticulo";
            this.btnBuscarArticulo.Size = new System.Drawing.Size(277, 47);
            this.btnBuscarArticulo.TabIndex = 11;
            this.btnBuscarArticulo.Text = "Buscar articulo";
            this.btnBuscarArticulo.UseVisualStyleBackColor = false;
            // 
            // txtCodigoArticulo
            // 
            this.txtCodigoArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCodigoArticulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtCodigoArticulo.Location = new System.Drawing.Point(828, 666);
            this.txtCodigoArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoArticulo.Name = "txtCodigoArticulo";
            this.txtCodigoArticulo.Size = new System.Drawing.Size(277, 26);
            this.txtCodigoArticulo.TabIndex = 10;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(288, 745);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(192, 49);
            this.btnActualizar.TabIndex = 12;
            this.btnActualizar.Text = "Actualizar tabla";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // insertarMercancia
            // 
            this.insertarMercancia.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold);
            this.insertarMercancia.ForeColor = System.Drawing.Color.White;
            this.insertarMercancia.Location = new System.Drawing.Point(359, 30);
            this.insertarMercancia.Name = "insertarMercancia";
            this.insertarMercancia.Size = new System.Drawing.Size(435, 44);
            this.insertarMercancia.TabIndex = 33;
            this.insertarMercancia.Text = "Insertando Mercancia";
            // 
            // InsertarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1554, 856);
            this.Controls.Add(this.insertarMercancia);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBuscarArticulo);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.txtCodigoArticulo);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InsertarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InsertarForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn familia;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn margenBeneficio;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVenta;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMargenBenificio;
        private System.Windows.Forms.TextBox txtNombreArticulo;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.TextBox txtUnidadMedida;
        private System.Windows.Forms.TextBox txtFamilia;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtCodArticulo;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBuscarArticulo;
        private System.Windows.Forms.TextBox txtCodigoArticulo;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label insertarMercancia;
    }
}