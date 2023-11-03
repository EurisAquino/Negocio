namespace Negocio.ui.Invetario_screen
{
    partial class EditarForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCodigoArticulo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigoArticuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreArticuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadMedidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.margenBeneficioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.businessAPPDataSet1 = new Negocio.BusinessAPPDataSet1();
            this.articulosTableAdapter = new Negocio.BusinessAPPDataSet1TableAdapters.ArticulosTableAdapter();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCodArticulo = new System.Windows.Forms.TextBox();
            this.txtNombreArticulo = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbfechaCreacion = new System.Windows.Forms.Label();
            this.txtFechaCreacion = new System.Windows.Forms.TextBox();
            this.lbprecioVenta = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.lbmargenBeneficio = new System.Windows.Forms.Label();
            this.lbprecioCompra = new System.Windows.Forms.Label();
            this.lbunidadMedida = new System.Windows.Forms.Label();
            this.lbFamilia = new System.Windows.Forms.Label();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.lbnomArticulo = new System.Windows.Forms.Label();
            this.lbcodArticulo = new System.Windows.Forms.Label();
            this.txtMargenBenificio = new System.Windows.Forms.TextBox();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.txtUnidadMedida = new System.Windows.Forms.TextBox();
            this.txtFamilia = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.insertarMercancia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessAPPDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigoArticulo
            // 
            this.txtCodigoArticulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodigoArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCodigoArticulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtCodigoArticulo.Location = new System.Drawing.Point(813, 59);
            this.txtCodigoArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoArticulo.Name = "txtCodigoArticulo";
            this.txtCodigoArticulo.Size = new System.Drawing.Size(277, 26);
            this.txtCodigoArticulo.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
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
            this.dataGridView1.DataSource = this.articulosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(19, 96);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1170, 520);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // codigoArticuloDataGridViewTextBoxColumn
            // 
            this.codigoArticuloDataGridViewTextBoxColumn.DataPropertyName = "codigoArticulo";
            this.codigoArticuloDataGridViewTextBoxColumn.HeaderText = "codigoArticulo";
            this.codigoArticuloDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigoArticuloDataGridViewTextBoxColumn.Name = "codigoArticuloDataGridViewTextBoxColumn";
            this.codigoArticuloDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoArticuloDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreArticuloDataGridViewTextBoxColumn
            // 
            this.nombreArticuloDataGridViewTextBoxColumn.DataPropertyName = "nombreArticulo";
            this.nombreArticuloDataGridViewTextBoxColumn.HeaderText = "nombreArticulo";
            this.nombreArticuloDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreArticuloDataGridViewTextBoxColumn.Name = "nombreArticuloDataGridViewTextBoxColumn";
            this.nombreArticuloDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreArticuloDataGridViewTextBoxColumn.Width = 125;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadDataGridViewTextBoxColumn.Width = 125;
            // 
            // familiaDataGridViewTextBoxColumn
            // 
            this.familiaDataGridViewTextBoxColumn.DataPropertyName = "familia";
            this.familiaDataGridViewTextBoxColumn.HeaderText = "familia";
            this.familiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.familiaDataGridViewTextBoxColumn.Name = "familiaDataGridViewTextBoxColumn";
            this.familiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.familiaDataGridViewTextBoxColumn.Width = 125;
            // 
            // unidadMedidaDataGridViewTextBoxColumn
            // 
            this.unidadMedidaDataGridViewTextBoxColumn.DataPropertyName = "unidadMedida";
            this.unidadMedidaDataGridViewTextBoxColumn.HeaderText = "unidadMedida";
            this.unidadMedidaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unidadMedidaDataGridViewTextBoxColumn.Name = "unidadMedidaDataGridViewTextBoxColumn";
            this.unidadMedidaDataGridViewTextBoxColumn.ReadOnly = true;
            this.unidadMedidaDataGridViewTextBoxColumn.Width = 125;
            // 
            // precioCompraDataGridViewTextBoxColumn
            // 
            this.precioCompraDataGridViewTextBoxColumn.DataPropertyName = "precioCompra";
            this.precioCompraDataGridViewTextBoxColumn.HeaderText = "precioCompra";
            this.precioCompraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precioCompraDataGridViewTextBoxColumn.Name = "precioCompraDataGridViewTextBoxColumn";
            this.precioCompraDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioCompraDataGridViewTextBoxColumn.Width = 125;
            // 
            // margenBeneficioDataGridViewTextBoxColumn
            // 
            this.margenBeneficioDataGridViewTextBoxColumn.DataPropertyName = "margenBeneficio";
            this.margenBeneficioDataGridViewTextBoxColumn.HeaderText = "margenBeneficio";
            this.margenBeneficioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.margenBeneficioDataGridViewTextBoxColumn.Name = "margenBeneficioDataGridViewTextBoxColumn";
            this.margenBeneficioDataGridViewTextBoxColumn.ReadOnly = true;
            this.margenBeneficioDataGridViewTextBoxColumn.Width = 125;
            // 
            // precioVentaDataGridViewTextBoxColumn
            // 
            this.precioVentaDataGridViewTextBoxColumn.DataPropertyName = "precioVenta";
            this.precioVentaDataGridViewTextBoxColumn.HeaderText = "precioVenta";
            this.precioVentaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precioVentaDataGridViewTextBoxColumn.Name = "precioVentaDataGridViewTextBoxColumn";
            this.precioVentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioVentaDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaCreacionDataGridViewTextBoxColumn
            // 
            this.fechaCreacionDataGridViewTextBoxColumn.DataPropertyName = "fechaCreacion";
            this.fechaCreacionDataGridViewTextBoxColumn.HeaderText = "fechaCreacion";
            this.fechaCreacionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaCreacionDataGridViewTextBoxColumn.Name = "fechaCreacionDataGridViewTextBoxColumn";
            this.fechaCreacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaCreacionDataGridViewTextBoxColumn.Width = 125;
            // 
            // articulosBindingSource
            // 
            this.articulosBindingSource.DataMember = "Articulos";
            this.articulosBindingSource.DataSource = this.businessAPPDataSet1;
            // 
            // businessAPPDataSet1
            // 
            this.businessAPPDataSet1.DataSetName = "BusinessAPPDataSet1";
            this.businessAPPDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // articulosTableAdapter
            // 
            this.articulosTableAdapter.ClearBeforeFill = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(142)))), ((int)(((byte)(202)))));
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(813, 117);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(277, 47);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar articulo";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCodArticulo
            // 
            this.txtCodArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtCodArticulo.Location = new System.Drawing.Point(151, 81);
            this.txtCodArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodArticulo.Name = "txtCodArticulo";
            this.txtCodArticulo.Size = new System.Drawing.Size(168, 24);
            this.txtCodArticulo.TabIndex = 1;
            // 
            // txtNombreArticulo
            // 
            this.txtNombreArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtNombreArticulo.Location = new System.Drawing.Point(153, 137);
            this.txtNombreArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreArticulo.Name = "txtNombreArticulo";
            this.txtNombreArticulo.Size = new System.Drawing.Size(166, 24);
            this.txtNombreArticulo.TabIndex = 2;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCantidad.Location = new System.Drawing.Point(153, 199);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(166, 26);
            this.txtCantidad.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(138)))), ((int)(((byte)(71)))));
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(52, 114);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(192, 49);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Regresar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(171)))), ((int)(((byte)(55)))));
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(12, 732);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(141, 45);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(171, 732);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(148, 45);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.panel1.Controls.Add(this.lbfechaCreacion);
            this.panel1.Controls.Add(this.txtFechaCreacion);
            this.panel1.Controls.Add(this.lbprecioVenta);
            this.panel1.Controls.Add(this.txtPrecioVenta);
            this.panel1.Controls.Add(this.lbmargenBeneficio);
            this.panel1.Controls.Add(this.lbprecioCompra);
            this.panel1.Controls.Add(this.lbunidadMedida);
            this.panel1.Controls.Add(this.lbFamilia);
            this.panel1.Controls.Add(this.lbCantidad);
            this.panel1.Controls.Add(this.lbnomArticulo);
            this.panel1.Controls.Add(this.lbcodArticulo);
            this.panel1.Controls.Add(this.txtMargenBenificio);
            this.panel1.Controls.Add(this.txtNombreArticulo);
            this.panel1.Controls.Add(this.txtPrecioCompra);
            this.panel1.Controls.Add(this.txtUnidadMedida);
            this.panel1.Controls.Add(this.txtFamilia);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.txtCantidad);
            this.panel1.Controls.Add(this.txtCodArticulo);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Location = new System.Drawing.Point(1198, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 899);
            this.panel1.TabIndex = 17;
            // 
            // lbfechaCreacion
            // 
            this.lbfechaCreacion.AutoSize = true;
            this.lbfechaCreacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbfechaCreacion.ForeColor = System.Drawing.Color.White;
            this.lbfechaCreacion.Location = new System.Drawing.Point(22, 593);
            this.lbfechaCreacion.Name = "lbfechaCreacion";
            this.lbfechaCreacion.Size = new System.Drawing.Size(127, 17);
            this.lbfechaCreacion.TabIndex = 31;
            this.lbfechaCreacion.Text = "Fecha de Creacion";
            // 
            // txtFechaCreacion
            // 
            this.txtFechaCreacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtFechaCreacion.Location = new System.Drawing.Point(154, 588);
            this.txtFechaCreacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtFechaCreacion.Name = "txtFechaCreacion";
            this.txtFechaCreacion.Size = new System.Drawing.Size(170, 24);
            this.txtFechaCreacion.TabIndex = 9;
            // 
            // lbprecioVenta
            // 
            this.lbprecioVenta.AutoSize = true;
            this.lbprecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbprecioVenta.ForeColor = System.Drawing.Color.White;
            this.lbprecioVenta.Location = new System.Drawing.Point(29, 527);
            this.lbprecioVenta.Name = "lbprecioVenta";
            this.lbprecioVenta.Size = new System.Drawing.Size(89, 17);
            this.lbprecioVenta.TabIndex = 29;
            this.lbprecioVenta.Text = "Precio Venta";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPrecioVenta.Location = new System.Drawing.Point(154, 518);
            this.txtPrecioVenta.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(170, 26);
            this.txtPrecioVenta.TabIndex = 8;
            // 
            // lbmargenBeneficio
            // 
            this.lbmargenBeneficio.AutoSize = true;
            this.lbmargenBeneficio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbmargenBeneficio.ForeColor = System.Drawing.Color.White;
            this.lbmargenBeneficio.Location = new System.Drawing.Point(22, 398);
            this.lbmargenBeneficio.Name = "lbmargenBeneficio";
            this.lbmargenBeneficio.Size = new System.Drawing.Size(118, 17);
            this.lbmargenBeneficio.TabIndex = 27;
            this.lbmargenBeneficio.Text = "Margen Beneficio";
            // 
            // lbprecioCompra
            // 
            this.lbprecioCompra.AutoSize = true;
            this.lbprecioCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbprecioCompra.ForeColor = System.Drawing.Color.White;
            this.lbprecioCompra.Location = new System.Drawing.Point(29, 464);
            this.lbprecioCompra.Name = "lbprecioCompra";
            this.lbprecioCompra.Size = new System.Drawing.Size(101, 17);
            this.lbprecioCompra.TabIndex = 26;
            this.lbprecioCompra.Text = "Precio Compra";
            // 
            // lbunidadMedida
            // 
            this.lbunidadMedida.AutoSize = true;
            this.lbunidadMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbunidadMedida.ForeColor = System.Drawing.Color.White;
            this.lbunidadMedida.Location = new System.Drawing.Point(27, 329);
            this.lbunidadMedida.Name = "lbunidadMedida";
            this.lbunidadMedida.Size = new System.Drawing.Size(103, 17);
            this.lbunidadMedida.TabIndex = 25;
            this.lbunidadMedida.Text = "Unidad Medida";
            // 
            // lbFamilia
            // 
            this.lbFamilia.AutoSize = true;
            this.lbFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbFamilia.ForeColor = System.Drawing.Color.White;
            this.lbFamilia.Location = new System.Drawing.Point(54, 265);
            this.lbFamilia.Name = "lbFamilia";
            this.lbFamilia.Size = new System.Drawing.Size(52, 17);
            this.lbFamilia.TabIndex = 24;
            this.lbFamilia.Text = "Familia";
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCantidad.ForeColor = System.Drawing.Color.White;
            this.lbCantidad.Location = new System.Drawing.Point(49, 202);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(64, 17);
            this.lbCantidad.TabIndex = 23;
            this.lbCantidad.Text = "Cantidad";
            // 
            // lbnomArticulo
            // 
            this.lbnomArticulo.AutoSize = true;
            this.lbnomArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbnomArticulo.ForeColor = System.Drawing.Color.White;
            this.lbnomArticulo.Location = new System.Drawing.Point(22, 143);
            this.lbnomArticulo.Name = "lbnomArticulo";
            this.lbnomArticulo.Size = new System.Drawing.Size(109, 17);
            this.lbnomArticulo.TabIndex = 22;
            this.lbnomArticulo.Text = "Nombre Articulo";
            // 
            // lbcodArticulo
            // 
            this.lbcodArticulo.AutoSize = true;
            this.lbcodArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbcodArticulo.ForeColor = System.Drawing.Color.White;
            this.lbcodArticulo.Location = new System.Drawing.Point(29, 87);
            this.lbcodArticulo.Name = "lbcodArticulo";
            this.lbcodArticulo.Size = new System.Drawing.Size(103, 17);
            this.lbcodArticulo.TabIndex = 21;
            this.lbcodArticulo.Text = "Codigo Articulo";
            // 
            // txtMargenBenificio
            // 
            this.txtMargenBenificio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMargenBenificio.Location = new System.Drawing.Point(154, 389);
            this.txtMargenBenificio.Margin = new System.Windows.Forms.Padding(2);
            this.txtMargenBenificio.Name = "txtMargenBenificio";
            this.txtMargenBenificio.Size = new System.Drawing.Size(170, 26);
            this.txtMargenBenificio.TabIndex = 6;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPrecioCompra.Location = new System.Drawing.Point(154, 455);
            this.txtPrecioCompra.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(170, 26);
            this.txtPrecioCompra.TabIndex = 7;
            // 
            // txtUnidadMedida
            // 
            this.txtUnidadMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUnidadMedida.Location = new System.Drawing.Point(154, 329);
            this.txtUnidadMedida.Margin = new System.Windows.Forms.Padding(2);
            this.txtUnidadMedida.Name = "txtUnidadMedida";
            this.txtUnidadMedida.Size = new System.Drawing.Size(170, 26);
            this.txtUnidadMedida.TabIndex = 5;
            // 
            // txtFamilia
            // 
            this.txtFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFamilia.Location = new System.Drawing.Point(154, 264);
            this.txtFamilia.Margin = new System.Windows.Forms.Padding(2);
            this.txtFamilia.Name = "txtFamilia";
            this.txtFamilia.Size = new System.Drawing.Size(168, 26);
            this.txtFamilia.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.panel2.Controls.Add(this.btnActualizar);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.txtCodigoArticulo);
            this.panel2.Location = new System.Drawing.Point(-4, 613);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1207, 287);
            this.panel2.TabIndex = 18;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(275, 115);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(192, 49);
            this.btnActualizar.TabIndex = 12;
            this.btnActualizar.Text = "Actualizar tabla";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(535, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(252, 24);
            this.label8.TabIndex = 28;
            this.label8.Text = "Ingrese el codigo del articulo";
            // 
            // insertarMercancia
            // 
            this.insertarMercancia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.insertarMercancia.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold);
            this.insertarMercancia.ForeColor = System.Drawing.Color.White;
            this.insertarMercancia.Location = new System.Drawing.Point(468, 25);
            this.insertarMercancia.Name = "insertarMercancia";
            this.insertarMercancia.Size = new System.Drawing.Size(435, 44);
            this.insertarMercancia.TabIndex = 34;
            this.insertarMercancia.Text = "Editando Articulo";
            // 
            // EditarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(1542, 897);
            this.Controls.Add(this.insertarMercancia);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EditarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessAPPDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigoArticulo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BusinessAPPDataSet1 businessAPPDataSet1;
        private System.Windows.Forms.BindingSource articulosBindingSource;
        private BusinessAPPDataSet1TableAdapters.ArticulosTableAdapter articulosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoArticuloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreArticuloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadMedidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn margenBeneficioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCodArticulo;
        private System.Windows.Forms.TextBox txtNombreArticulo;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbprecioCompra;
        private System.Windows.Forms.Label lbunidadMedida;
        private System.Windows.Forms.Label lbFamilia;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.Label lbnomArticulo;
        private System.Windows.Forms.Label lbcodArticulo;
        private System.Windows.Forms.TextBox txtMargenBenificio;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.TextBox txtUnidadMedida;
        private System.Windows.Forms.TextBox txtFamilia;
        private System.Windows.Forms.Label lbmargenBeneficio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label insertarMercancia;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lbfechaCreacion;
        private System.Windows.Forms.TextBox txtFechaCreacion;
        private System.Windows.Forms.Label lbprecioVenta;
        private System.Windows.Forms.TextBox txtPrecioVenta;
    }
}