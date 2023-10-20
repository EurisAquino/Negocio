namespace Negocio.ui.main_window.Cotizacion_screen
{
    partial class cotizacionForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.insertarMercancia = new System.Windows.Forms.Label();
            this.dataGridCotizacion = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtcedularnc = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbcedularnc = new System.Windows.Forms.Label();
            this.lbArticulo = new System.Windows.Forms.Label();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.lbfechaCotizacion = new System.Windows.Forms.Label();
            this.lbITBIS = new System.Windows.Forms.Label();
            this.lbDescuento = new System.Windows.Forms.Label();
            this.lbbprecioVenta = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lbxArticulos = new System.Windows.Forms.ListBox();
            this.txtprecioVenta = new System.Windows.Forms.NumericUpDown();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtITBIS = new System.Windows.Forms.NumericUpDown();
            this.txtDescuento = new System.Windows.Forms.NumericUpDown();
            this.txtfechaCotizacion = new System.Windows.Forms.DateTimePicker();
            this.businessAPPDataSet2 = new Negocio.BusinessAPPDataSet2();
            this.cotizacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cotizacionesTableAdapter = new Negocio.BusinessAPPDataSet2TableAdapters.CotizacionesTableAdapter();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedularncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itbisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCotizacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoCotizacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCotizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtprecioVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtITBIS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessAPPDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cotizacionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // insertarMercancia
            // 
            this.insertarMercancia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.insertarMercancia.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold);
            this.insertarMercancia.ForeColor = System.Drawing.Color.White;
            this.insertarMercancia.Location = new System.Drawing.Point(876, 23);
            this.insertarMercancia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.insertarMercancia.Name = "insertarMercancia";
            this.insertarMercancia.Size = new System.Drawing.Size(580, 54);
            this.insertarMercancia.TabIndex = 35;
            this.insertarMercancia.Text = "Cotizaciones";
            // 
            // dataGridCotizacion
            // 
            this.dataGridCotizacion.AllowUserToAddRows = false;
            this.dataGridCotizacion.AllowUserToDeleteRows = false;
            this.dataGridCotizacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridCotizacion.AutoGenerateColumns = false;
            this.dataGridCotizacion.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCotizacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridCotizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCotizacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.cedularncDataGridViewTextBoxColumn,
            this.articuloDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.precioVentaDataGridViewTextBoxColumn,
            this.descuentoDataGridViewTextBoxColumn,
            this.itbisDataGridViewTextBoxColumn,
            this.fechaCotizacionDataGridViewTextBoxColumn,
            this.codigoCotizacionDataGridViewTextBoxColumn});
            this.dataGridCotizacion.DataSource = this.cotizacionesBindingSource;
            this.dataGridCotizacion.Location = new System.Drawing.Point(100, 86);
            this.dataGridCotizacion.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridCotizacion.Name = "dataGridCotizacion";
            this.dataGridCotizacion.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCotizacion.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridCotizacion.RowHeadersWidth = 51;
            this.dataGridCotizacion.Size = new System.Drawing.Size(1794, 464);
            this.dataGridCotizacion.TabIndex = 36;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNombre.Location = new System.Drawing.Point(753, 587);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(225, 30);
            this.txtNombre.TabIndex = 37;
            // 
            // txtcedularnc
            // 
            this.txtcedularnc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcedularnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtcedularnc.Location = new System.Drawing.Point(753, 649);
            this.txtcedularnc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcedularnc.Name = "txtcedularnc";
            this.txtcedularnc.Size = new System.Drawing.Size(225, 30);
            this.txtcedularnc.TabIndex = 38;
            // 
            // lbNombre
            // 
            this.lbNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbNombre.ForeColor = System.Drawing.Color.White;
            this.lbNombre.Location = new System.Drawing.Point(616, 592);
            this.lbNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(68, 20);
            this.lbNombre.TabIndex = 50;
            this.lbNombre.Text = "Nombre";
            // 
            // lbcedularnc
            // 
            this.lbcedularnc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbcedularnc.AutoSize = true;
            this.lbcedularnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbcedularnc.ForeColor = System.Drawing.Color.White;
            this.lbcedularnc.Location = new System.Drawing.Point(592, 656);
            this.lbcedularnc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbcedularnc.Name = "lbcedularnc";
            this.lbcedularnc.Size = new System.Drawing.Size(102, 20);
            this.lbcedularnc.TabIndex = 51;
            this.lbcedularnc.Text = "Cedula/RNC";
            // 
            // lbArticulo
            // 
            this.lbArticulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbArticulo.AutoSize = true;
            this.lbArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbArticulo.ForeColor = System.Drawing.Color.White;
            this.lbArticulo.Location = new System.Drawing.Point(628, 782);
            this.lbArticulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbArticulo.Name = "lbArticulo";
            this.lbArticulo.Size = new System.Drawing.Size(66, 20);
            this.lbArticulo.TabIndex = 53;
            this.lbArticulo.Text = "Articulo";
            // 
            // lbCantidad
            // 
            this.lbCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCantidad.ForeColor = System.Drawing.Color.White;
            this.lbCantidad.Location = new System.Drawing.Point(613, 720);
            this.lbCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(75, 20);
            this.lbCantidad.TabIndex = 54;
            this.lbCantidad.Text = "Cantidad";
            // 
            // lbfechaCotizacion
            // 
            this.lbfechaCotizacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbfechaCotizacion.AutoSize = true;
            this.lbfechaCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbfechaCotizacion.ForeColor = System.Drawing.Color.White;
            this.lbfechaCotizacion.Location = new System.Drawing.Point(1040, 778);
            this.lbfechaCotizacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbfechaCotizacion.Name = "lbfechaCotizacion";
            this.lbfechaCotizacion.Size = new System.Drawing.Size(162, 20);
            this.lbfechaCotizacion.TabIndex = 59;
            this.lbfechaCotizacion.Text = "Fecha de Cotizacion";
            // 
            // lbITBIS
            // 
            this.lbITBIS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbITBIS.AutoSize = true;
            this.lbITBIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbITBIS.ForeColor = System.Drawing.Color.White;
            this.lbITBIS.Location = new System.Drawing.Point(1101, 718);
            this.lbITBIS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbITBIS.Name = "lbITBIS";
            this.lbITBIS.Size = new System.Drawing.Size(50, 20);
            this.lbITBIS.TabIndex = 57;
            this.lbITBIS.Text = "ITBIS";
            // 
            // lbDescuento
            // 
            this.lbDescuento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbDescuento.AutoSize = true;
            this.lbDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbDescuento.ForeColor = System.Drawing.Color.White;
            this.lbDescuento.Location = new System.Drawing.Point(1085, 656);
            this.lbDescuento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDescuento.Name = "lbDescuento";
            this.lbDescuento.Size = new System.Drawing.Size(90, 20);
            this.lbDescuento.TabIndex = 56;
            this.lbDescuento.Text = "Descuento";
            // 
            // lbbprecioVenta
            // 
            this.lbbprecioVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbbprecioVenta.AutoSize = true;
            this.lbbprecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbbprecioVenta.ForeColor = System.Drawing.Color.White;
            this.lbbprecioVenta.Location = new System.Drawing.Point(1063, 592);
            this.lbbprecioVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbbprecioVenta.Name = "lbbprecioVenta";
            this.lbbprecioVenta.Size = new System.Drawing.Size(128, 20);
            this.lbbprecioVenta.TabIndex = 55;
            this.lbbprecioVenta.Text = "Precio de Venta";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(1551, 759);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(233, 54);
            this.btnLimpiar.TabIndex = 61;
            this.btnLimpiar.Text = "Vaciar Campos";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(171)))), ((int)(((byte)(55)))));
            this.btnCrear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCrear.ForeColor = System.Drawing.Color.White;
            this.btnCrear.Location = new System.Drawing.Point(1551, 623);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(233, 54);
            this.btnCrear.TabIndex = 60;
            this.btnCrear.Text = "Crear Cotizacion";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(138)))), ((int)(((byte)(71)))));
            this.btnRegresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(177, 761);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(212, 54);
            this.btnRegresar.TabIndex = 62;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(177, 623);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(212, 58);
            this.btnActualizar.TabIndex = 63;
            this.btnActualizar.Text = "Refrescar tabla";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lbxArticulos
            // 
            this.lbxArticulos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbxArticulos.FormattingEnabled = true;
            this.lbxArticulos.ItemHeight = 16;
            this.lbxArticulos.Location = new System.Drawing.Point(753, 782);
            this.lbxArticulos.Name = "lbxArticulos";
            this.lbxArticulos.Size = new System.Drawing.Size(225, 100);
            this.lbxArticulos.TabIndex = 64;
            // 
            // txtprecioVenta
            // 
            this.txtprecioVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtprecioVenta.Location = new System.Drawing.Point(1252, 595);
            this.txtprecioVenta.Name = "txtprecioVenta";
            this.txtprecioVenta.Size = new System.Drawing.Size(251, 22);
            this.txtprecioVenta.TabIndex = 65;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCantidad.Location = new System.Drawing.Point(753, 716);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(225, 22);
            this.txtCantidad.TabIndex = 66;
            // 
            // txtITBIS
            // 
            this.txtITBIS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtITBIS.Location = new System.Drawing.Point(1252, 716);
            this.txtITBIS.Name = "txtITBIS";
            this.txtITBIS.Size = new System.Drawing.Size(251, 22);
            this.txtITBIS.TabIndex = 67;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescuento.Location = new System.Drawing.Point(1252, 656);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(251, 22);
            this.txtDescuento.TabIndex = 68;
            // 
            // txtfechaCotizacion
            // 
            this.txtfechaCotizacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtfechaCotizacion.Location = new System.Drawing.Point(1252, 776);
            this.txtfechaCotizacion.Name = "txtfechaCotizacion";
            this.txtfechaCotizacion.Size = new System.Drawing.Size(251, 22);
            this.txtfechaCotizacion.TabIndex = 69;
            // 
            // businessAPPDataSet2
            // 
            this.businessAPPDataSet2.DataSetName = "BusinessAPPDataSet2";
            this.businessAPPDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cotizacionesBindingSource
            // 
            this.cotizacionesBindingSource.DataMember = "Cotizaciones";
            this.cotizacionesBindingSource.DataSource = this.businessAPPDataSet2;
            // 
            // cotizacionesTableAdapter
            // 
            this.cotizacionesTableAdapter.ClearBeforeFill = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // cedularncDataGridViewTextBoxColumn
            // 
            this.cedularncDataGridViewTextBoxColumn.DataPropertyName = "cedularnc";
            this.cedularncDataGridViewTextBoxColumn.HeaderText = "cedularnc";
            this.cedularncDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cedularncDataGridViewTextBoxColumn.Name = "cedularncDataGridViewTextBoxColumn";
            this.cedularncDataGridViewTextBoxColumn.ReadOnly = true;
            this.cedularncDataGridViewTextBoxColumn.Width = 125;
            // 
            // articuloDataGridViewTextBoxColumn
            // 
            this.articuloDataGridViewTextBoxColumn.DataPropertyName = "articulo";
            this.articuloDataGridViewTextBoxColumn.HeaderText = "articulo";
            this.articuloDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.articuloDataGridViewTextBoxColumn.Name = "articuloDataGridViewTextBoxColumn";
            this.articuloDataGridViewTextBoxColumn.ReadOnly = true;
            this.articuloDataGridViewTextBoxColumn.Width = 125;
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
            // precioVentaDataGridViewTextBoxColumn
            // 
            this.precioVentaDataGridViewTextBoxColumn.DataPropertyName = "precioVenta";
            this.precioVentaDataGridViewTextBoxColumn.HeaderText = "precioVenta";
            this.precioVentaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precioVentaDataGridViewTextBoxColumn.Name = "precioVentaDataGridViewTextBoxColumn";
            this.precioVentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioVentaDataGridViewTextBoxColumn.Width = 125;
            // 
            // descuentoDataGridViewTextBoxColumn
            // 
            this.descuentoDataGridViewTextBoxColumn.DataPropertyName = "descuento";
            this.descuentoDataGridViewTextBoxColumn.HeaderText = "descuento";
            this.descuentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descuentoDataGridViewTextBoxColumn.Name = "descuentoDataGridViewTextBoxColumn";
            this.descuentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descuentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // itbisDataGridViewTextBoxColumn
            // 
            this.itbisDataGridViewTextBoxColumn.DataPropertyName = "itbis";
            this.itbisDataGridViewTextBoxColumn.HeaderText = "itbis";
            this.itbisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itbisDataGridViewTextBoxColumn.Name = "itbisDataGridViewTextBoxColumn";
            this.itbisDataGridViewTextBoxColumn.ReadOnly = true;
            this.itbisDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaCotizacionDataGridViewTextBoxColumn
            // 
            this.fechaCotizacionDataGridViewTextBoxColumn.DataPropertyName = "fechaCotizacion";
            this.fechaCotizacionDataGridViewTextBoxColumn.HeaderText = "fechaCotizacion";
            this.fechaCotizacionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaCotizacionDataGridViewTextBoxColumn.Name = "fechaCotizacionDataGridViewTextBoxColumn";
            this.fechaCotizacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaCotizacionDataGridViewTextBoxColumn.Width = 190;
            // 
            // codigoCotizacionDataGridViewTextBoxColumn
            // 
            this.codigoCotizacionDataGridViewTextBoxColumn.DataPropertyName = "codigoCotizacion";
            this.codigoCotizacionDataGridViewTextBoxColumn.HeaderText = "codigoCotizacion";
            this.codigoCotizacionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigoCotizacionDataGridViewTextBoxColumn.Name = "codigoCotizacionDataGridViewTextBoxColumn";
            this.codigoCotizacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoCotizacionDataGridViewTextBoxColumn.Width = 180;
            // 
            // cotizacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(1924, 902);
            this.Controls.Add(this.txtfechaCotizacion);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtITBIS);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtprecioVenta);
            this.Controls.Add(this.lbxArticulos);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.lbfechaCotizacion);
            this.Controls.Add(this.lbITBIS);
            this.Controls.Add(this.lbDescuento);
            this.Controls.Add(this.lbbprecioVenta);
            this.Controls.Add(this.lbCantidad);
            this.Controls.Add(this.lbArticulo);
            this.Controls.Add(this.lbcedularnc);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.txtcedularnc);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dataGridCotizacion);
            this.Controls.Add(this.insertarMercancia);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "cotizacionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cotizacionForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.cotizacionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCotizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtprecioVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtITBIS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessAPPDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cotizacionesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label insertarMercancia;
        private System.Windows.Forms.DataGridView dataGridCotizacion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtcedularnc;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbcedularnc;
        private System.Windows.Forms.Label lbArticulo;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.Label lbfechaCotizacion;
        private System.Windows.Forms.Label lbITBIS;
        private System.Windows.Forms.Label lbDescuento;
        private System.Windows.Forms.Label lbbprecioVenta;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ListBox lbxArticulos;
        private System.Windows.Forms.NumericUpDown txtprecioVenta;
        private System.Windows.Forms.NumericUpDown txtDescuento;
        private System.Windows.Forms.NumericUpDown txtITBIS;
        private System.Windows.Forms.DateTimePicker txtfechaCotizacion;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private BusinessAPPDataSet2 businessAPPDataSet2;
        private System.Windows.Forms.BindingSource cotizacionesBindingSource;
        private BusinessAPPDataSet2TableAdapters.CotizacionesTableAdapter cotizacionesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedularncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn articuloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itbisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCotizacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoCotizacionDataGridViewTextBoxColumn;
    }
}