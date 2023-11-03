namespace Negocio.ui.Invetario_screen
{
    partial class Inventario_Form
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.articulosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.businessAPPDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.businessAPPDataSet1 = new Negocio.BusinessAPPDataSet1();
            this.articulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articulosTableAdapter = new Negocio.BusinessAPPDataSet1TableAdapters.ArticulosTableAdapter();
            this.btnAgregarArticulos = new System.Windows.Forms.Button();
            this.label_inventario = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnInsertarMercancia = new System.Windows.Forms.Button();
            this.btnDesactivar = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.codigoArticuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreArticuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadMedidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.margenBeneficioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessAPPDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessAPPDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoArticuloDataGridViewTextBoxColumn,
            this.nombreArticuloDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.familiaDataGridViewTextBoxColumn,
            this.unidadMedidaDataGridViewTextBoxColumn,
            this.precioCompraDataGridViewTextBoxColumn,
            this.margenBeneficioDataGridViewTextBoxColumn,
            this.precioVentaDataGridViewTextBoxColumn,
            this.fechaCreacionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.articulosBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(156, 113);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1044, 486);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // articulosBindingSource1
            // 
            this.articulosBindingSource1.DataMember = "Articulos";
            this.articulosBindingSource1.DataSource = this.businessAPPDataSet1BindingSource;
            // 
            // businessAPPDataSet1BindingSource
            // 
            this.businessAPPDataSet1BindingSource.DataSource = this.businessAPPDataSet1;
            this.businessAPPDataSet1BindingSource.Position = 0;
            // 
            // businessAPPDataSet1
            // 
            this.businessAPPDataSet1.DataSetName = "BusinessAPPDataSet1";
            this.businessAPPDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // articulosBindingSource
            // 
            this.articulosBindingSource.DataMember = "Articulos";
            this.articulosBindingSource.DataSource = this.businessAPPDataSet1;
            // 
            // articulosTableAdapter
            // 
            this.articulosTableAdapter.ClearBeforeFill = true;
            // 
            // btnAgregarArticulos
            // 
            this.btnAgregarArticulos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarArticulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(138)))), ((int)(((byte)(71)))));
            this.btnAgregarArticulos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarArticulos.FlatAppearance.BorderSize = 2;
            this.btnAgregarArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAgregarArticulos.ForeColor = System.Drawing.Color.White;
            this.btnAgregarArticulos.Location = new System.Drawing.Point(426, 715);
            this.btnAgregarArticulos.Name = "btnAgregarArticulos";
            this.btnAgregarArticulos.Size = new System.Drawing.Size(151, 39);
            this.btnAgregarArticulos.TabIndex = 12;
            this.btnAgregarArticulos.Text = "Agregar Articulo";
            this.btnAgregarArticulos.UseVisualStyleBackColor = false;
            this.btnAgregarArticulos.Click += new System.EventHandler(this.btnAgregarArticulos_Click);
            // 
            // label_inventario
            // 
            this.label_inventario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_inventario.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold);
            this.label_inventario.ForeColor = System.Drawing.Color.White;
            this.label_inventario.Location = new System.Drawing.Point(611, 38);
            this.label_inventario.Name = "label_inventario";
            this.label_inventario.Size = new System.Drawing.Size(224, 44);
            this.label_inventario.TabIndex = 14;
            this.label_inventario.Text = "Inventario";
            this.label_inventario.Click += new System.EventHandler(this.label_inventario_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(138)))), ((int)(((byte)(71)))));
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnActualizar.FlatAppearance.BorderSize = 2;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(632, 715);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(151, 39);
            this.btnActualizar.TabIndex = 15;
            this.btnActualizar.Text = "Modificar Articulo";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click_1);
            // 
            // btnInsertarMercancia
            // 
            this.btnInsertarMercancia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInsertarMercancia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(138)))), ((int)(((byte)(71)))));
            this.btnInsertarMercancia.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnInsertarMercancia.FlatAppearance.BorderSize = 2;
            this.btnInsertarMercancia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertarMercancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnInsertarMercancia.ForeColor = System.Drawing.Color.White;
            this.btnInsertarMercancia.Location = new System.Drawing.Point(830, 715);
            this.btnInsertarMercancia.Name = "btnInsertarMercancia";
            this.btnInsertarMercancia.Size = new System.Drawing.Size(166, 39);
            this.btnInsertarMercancia.TabIndex = 17;
            this.btnInsertarMercancia.Text = "Insertar Mercancia";
            this.btnInsertarMercancia.UseVisualStyleBackColor = false;
            this.btnInsertarMercancia.Click += new System.EventHandler(this.btnInsertarMercancia_Click);
            // 
            // btnDesactivar
            // 
            this.btnDesactivar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDesactivar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(138)))), ((int)(((byte)(71)))));
            this.btnDesactivar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDesactivar.FlatAppearance.BorderSize = 2;
            this.btnDesactivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesactivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDesactivar.ForeColor = System.Drawing.Color.White;
            this.btnDesactivar.Location = new System.Drawing.Point(1035, 715);
            this.btnDesactivar.Name = "btnDesactivar";
            this.btnDesactivar.Size = new System.Drawing.Size(165, 39);
            this.btnDesactivar.TabIndex = 18;
            this.btnDesactivar.Text = "Desactivar Articulo";
            this.btnDesactivar.UseVisualStyleBackColor = false;
            this.btnDesactivar.Click += new System.EventHandler(this.btnDesactivar_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.Image = global::Negocio.Properties.Resources.sugar_free_1428956;
            this.pictureBox4.Location = new System.Drawing.Point(1042, 637);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(149, 70);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = global::Negocio.Properties.Resources.cart_891407;
            this.pictureBox3.Location = new System.Drawing.Point(839, 639);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(144, 68);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::Negocio.Properties.Resources.edit;
            this.pictureBox2.Location = new System.Drawing.Point(639, 639);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(144, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Negocio.Properties.Resources.agregar_producto;
            this.pictureBox1.Location = new System.Drawing.Point(426, 639);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(138)))), ((int)(((byte)(71)))));
            this.btnRegresar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRegresar.FlatAppearance.BorderSize = 2;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(156, 715);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(144, 39);
            this.btnRegresar.TabIndex = 48;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // codigoArticuloDataGridViewTextBoxColumn
            // 
            this.codigoArticuloDataGridViewTextBoxColumn.DataPropertyName = "codigoArticulo";
            this.codigoArticuloDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoArticuloDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigoArticuloDataGridViewTextBoxColumn.Name = "codigoArticuloDataGridViewTextBoxColumn";
            this.codigoArticuloDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoArticuloDataGridViewTextBoxColumn.Width = 77;
            // 
            // nombreArticuloDataGridViewTextBoxColumn
            // 
            this.nombreArticuloDataGridViewTextBoxColumn.DataPropertyName = "nombreArticulo";
            this.nombreArticuloDataGridViewTextBoxColumn.HeaderText = "Nombre Articulo";
            this.nombreArticuloDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreArticuloDataGridViewTextBoxColumn.Name = "nombreArticuloDataGridViewTextBoxColumn";
            this.nombreArticuloDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreArticuloDataGridViewTextBoxColumn.Width = 123;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadDataGridViewTextBoxColumn.Width = 89;
            // 
            // familiaDataGridViewTextBoxColumn
            // 
            this.familiaDataGridViewTextBoxColumn.DataPropertyName = "familia";
            this.familiaDataGridViewTextBoxColumn.HeaderText = "Familia";
            this.familiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.familiaDataGridViewTextBoxColumn.Name = "familiaDataGridViewTextBoxColumn";
            this.familiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.familiaDataGridViewTextBoxColumn.Width = 77;
            // 
            // unidadMedidaDataGridViewTextBoxColumn
            // 
            this.unidadMedidaDataGridViewTextBoxColumn.DataPropertyName = "unidadMedida";
            this.unidadMedidaDataGridViewTextBoxColumn.HeaderText = "Unidad de Medida";
            this.unidadMedidaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unidadMedidaDataGridViewTextBoxColumn.Name = "unidadMedidaDataGridViewTextBoxColumn";
            this.unidadMedidaDataGridViewTextBoxColumn.ReadOnly = true;
            this.unidadMedidaDataGridViewTextBoxColumn.Width = 135;
            // 
            // precioCompraDataGridViewTextBoxColumn
            // 
            this.precioCompraDataGridViewTextBoxColumn.DataPropertyName = "precioCompra";
            this.precioCompraDataGridViewTextBoxColumn.HeaderText = "Precio de Compra";
            this.precioCompraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precioCompraDataGridViewTextBoxColumn.Name = "precioCompraDataGridViewTextBoxColumn";
            this.precioCompraDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioCompraDataGridViewTextBoxColumn.Width = 133;
            // 
            // margenBeneficioDataGridViewTextBoxColumn
            // 
            this.margenBeneficioDataGridViewTextBoxColumn.DataPropertyName = "margenBeneficio";
            this.margenBeneficioDataGridViewTextBoxColumn.HeaderText = "Margen Beneficio";
            this.margenBeneficioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.margenBeneficioDataGridViewTextBoxColumn.Name = "margenBeneficioDataGridViewTextBoxColumn";
            this.margenBeneficioDataGridViewTextBoxColumn.ReadOnly = true;
            this.margenBeneficioDataGridViewTextBoxColumn.Width = 131;
            // 
            // precioVentaDataGridViewTextBoxColumn
            // 
            this.precioVentaDataGridViewTextBoxColumn.DataPropertyName = "precioVenta";
            this.precioVentaDataGridViewTextBoxColumn.HeaderText = "Precio de venta";
            this.precioVentaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precioVentaDataGridViewTextBoxColumn.Name = "precioVentaDataGridViewTextBoxColumn";
            this.precioVentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioVentaDataGridViewTextBoxColumn.Width = 89;
            // 
            // fechaCreacionDataGridViewTextBoxColumn
            // 
            this.fechaCreacionDataGridViewTextBoxColumn.DataPropertyName = "fechaCreacion";
            this.fechaCreacionDataGridViewTextBoxColumn.HeaderText = "Fecha de creacion";
            this.fechaCreacionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaCreacionDataGridViewTextBoxColumn.Name = "fechaCreacionDataGridViewTextBoxColumn";
            this.fechaCreacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaCreacionDataGridViewTextBoxColumn.Width = 137;
            // 
            // Inventario_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1443, 818);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnDesactivar);
            this.Controls.Add(this.btnInsertarMercancia);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.label_inventario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAgregarArticulos);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Inventario_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Inventario_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessAPPDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessAPPDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource businessAPPDataSet1BindingSource;
        private BusinessAPPDataSet1 businessAPPDataSet1;
        private System.Windows.Forms.BindingSource articulosBindingSource;
        private BusinessAPPDataSet1TableAdapters.ArticulosTableAdapter articulosTableAdapter;
        private System.Windows.Forms.BindingSource articulosBindingSource1;
        private System.Windows.Forms.Button btnAgregarArticulos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_inventario;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnInsertarMercancia;
        private System.Windows.Forms.Button btnDesactivar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoArticuloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreArticuloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadMedidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn margenBeneficioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacionDataGridViewTextBoxColumn;
    }
}