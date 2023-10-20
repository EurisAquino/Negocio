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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.insertarMercancia = new System.Windows.Forms.Label();
            this.dataGridCotizacion = new System.Windows.Forms.DataGridView();
            this.nombreCotizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedularncCotizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codCotizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articuloCotizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadCotizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioventaCotizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuentoCotizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itbisCotizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codcotizacionCotizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCotizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtcedularnc = new System.Windows.Forms.TextBox();
            this.txtCotizacion = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.txtfechaCotizacion = new System.Windows.Forms.TextBox();
            this.txtITBIS = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtprecioVenta = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbcedularnc = new System.Windows.Forms.Label();
            this.lbArticulo = new System.Windows.Forms.Label();
            this.lbcotizacion = new System.Windows.Forms.Label();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.lbfechaCotizacion = new System.Windows.Forms.Label();
            this.lbITBIS = new System.Windows.Forms.Label();
            this.lbDescuento = new System.Windows.Forms.Label();
            this.lbbprecioVenta = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCotizacion)).BeginInit();
            this.SuspendLayout();
            // 
            // insertarMercancia
            // 
            this.insertarMercancia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.insertarMercancia.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold);
            this.insertarMercancia.ForeColor = System.Drawing.Color.White;
            this.insertarMercancia.Location = new System.Drawing.Point(657, 19);
            this.insertarMercancia.Name = "insertarMercancia";
            this.insertarMercancia.Size = new System.Drawing.Size(435, 44);
            this.insertarMercancia.TabIndex = 35;
            this.insertarMercancia.Text = "Cotizaciones";
            // 
            // dataGridCotizacion
            // 
            this.dataGridCotizacion.AllowUserToAddRows = false;
            this.dataGridCotizacion.AllowUserToDeleteRows = false;
            this.dataGridCotizacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridCotizacion.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCotizacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridCotizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCotizacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreCotizacion,
            this.cedularncCotizacion,
            this.codCotizacion,
            this.articuloCotizacion,
            this.cantidadCotizacion,
            this.precioventaCotizacion,
            this.descuentoCotizacion,
            this.itbisCotizacion,
            this.codcotizacionCotizacion,
            this.fechaCotizacion});
            this.dataGridCotizacion.Location = new System.Drawing.Point(133, 70);
            this.dataGridCotizacion.Name = "dataGridCotizacion";
            this.dataGridCotizacion.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCotizacion.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridCotizacion.Size = new System.Drawing.Size(1219, 377);
            this.dataGridCotizacion.TabIndex = 36;
            // 
            // nombreCotizacion
            // 
            this.nombreCotizacion.HeaderText = "Nombre";
            this.nombreCotizacion.Name = "nombreCotizacion";
            this.nombreCotizacion.ReadOnly = true;
            // 
            // cedularncCotizacion
            // 
            this.cedularncCotizacion.HeaderText = "Cedula/RNC";
            this.cedularncCotizacion.Name = "cedularncCotizacion";
            this.cedularncCotizacion.ReadOnly = true;
            // 
            // codCotizacion
            // 
            this.codCotizacion.HeaderText = "Cotizacion";
            this.codCotizacion.Name = "codCotizacion";
            this.codCotizacion.ReadOnly = true;
            // 
            // articuloCotizacion
            // 
            this.articuloCotizacion.HeaderText = "Articulo";
            this.articuloCotizacion.Name = "articuloCotizacion";
            this.articuloCotizacion.ReadOnly = true;
            // 
            // cantidadCotizacion
            // 
            this.cantidadCotizacion.HeaderText = "Cantidad";
            this.cantidadCotizacion.Name = "cantidadCotizacion";
            this.cantidadCotizacion.ReadOnly = true;
            // 
            // precioventaCotizacion
            // 
            this.precioventaCotizacion.HeaderText = "Precio de Venta";
            this.precioventaCotizacion.Name = "precioventaCotizacion";
            this.precioventaCotizacion.ReadOnly = true;
            this.precioventaCotizacion.Width = 150;
            // 
            // descuentoCotizacion
            // 
            this.descuentoCotizacion.HeaderText = "Descuento";
            this.descuentoCotizacion.Name = "descuentoCotizacion";
            this.descuentoCotizacion.ReadOnly = true;
            // 
            // itbisCotizacion
            // 
            this.itbisCotizacion.HeaderText = "ITBIS";
            this.itbisCotizacion.Name = "itbisCotizacion";
            this.itbisCotizacion.ReadOnly = true;
            // 
            // codcotizacionCotizacion
            // 
            this.codcotizacionCotizacion.HeaderText = "Codigo de cotizacion";
            this.codcotizacionCotizacion.Name = "codcotizacionCotizacion";
            this.codcotizacionCotizacion.ReadOnly = true;
            this.codcotizacionCotizacion.Width = 165;
            // 
            // fechaCotizacion
            // 
            this.fechaCotizacion.HeaderText = "Fecha de cotizacion";
            this.fechaCotizacion.Name = "fechaCotizacion";
            this.fechaCotizacion.ReadOnly = true;
            this.fechaCotizacion.Width = 160;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNombre.Location = new System.Drawing.Point(565, 477);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(170, 26);
            this.txtNombre.TabIndex = 37;
            // 
            // txtcedularnc
            // 
            this.txtcedularnc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcedularnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtcedularnc.Location = new System.Drawing.Point(565, 527);
            this.txtcedularnc.Margin = new System.Windows.Forms.Padding(2);
            this.txtcedularnc.Name = "txtcedularnc";
            this.txtcedularnc.Size = new System.Drawing.Size(170, 26);
            this.txtcedularnc.TabIndex = 38;
            // 
            // txtCotizacion
            // 
            this.txtCotizacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCotizacion.Location = new System.Drawing.Point(565, 577);
            this.txtCotizacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtCotizacion.Name = "txtCotizacion";
            this.txtCotizacion.Size = new System.Drawing.Size(170, 26);
            this.txtCotizacion.TabIndex = 39;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCantidad.Location = new System.Drawing.Point(565, 677);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(170, 26);
            this.txtCantidad.TabIndex = 44;
            // 
            // txtArticulo
            // 
            this.txtArticulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtArticulo.Location = new System.Drawing.Point(565, 627);
            this.txtArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(170, 26);
            this.txtArticulo.TabIndex = 43;
            // 
            // txtfechaCotizacion
            // 
            this.txtfechaCotizacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtfechaCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtfechaCotizacion.Location = new System.Drawing.Point(939, 627);
            this.txtfechaCotizacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtfechaCotizacion.Name = "txtfechaCotizacion";
            this.txtfechaCotizacion.Size = new System.Drawing.Size(170, 26);
            this.txtfechaCotizacion.TabIndex = 49;
            // 
            // txtITBIS
            // 
            this.txtITBIS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtITBIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtITBIS.Location = new System.Drawing.Point(939, 577);
            this.txtITBIS.Margin = new System.Windows.Forms.Padding(2);
            this.txtITBIS.Name = "txtITBIS";
            this.txtITBIS.Size = new System.Drawing.Size(170, 26);
            this.txtITBIS.TabIndex = 47;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDescuento.Location = new System.Drawing.Point(939, 527);
            this.txtDescuento.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(170, 26);
            this.txtDescuento.TabIndex = 46;
            // 
            // txtprecioVenta
            // 
            this.txtprecioVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtprecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtprecioVenta.Location = new System.Drawing.Point(939, 477);
            this.txtprecioVenta.Margin = new System.Windows.Forms.Padding(2);
            this.txtprecioVenta.Name = "txtprecioVenta";
            this.txtprecioVenta.Size = new System.Drawing.Size(170, 26);
            this.txtprecioVenta.TabIndex = 45;
            // 
            // lbNombre
            // 
            this.lbNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbNombre.ForeColor = System.Drawing.Color.White;
            this.lbNombre.Location = new System.Drawing.Point(462, 481);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(58, 17);
            this.lbNombre.TabIndex = 50;
            this.lbNombre.Text = "Nombre";
            // 
            // lbcedularnc
            // 
            this.lbcedularnc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbcedularnc.AutoSize = true;
            this.lbcedularnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbcedularnc.ForeColor = System.Drawing.Color.White;
            this.lbcedularnc.Location = new System.Drawing.Point(444, 533);
            this.lbcedularnc.Name = "lbcedularnc";
            this.lbcedularnc.Size = new System.Drawing.Size(85, 17);
            this.lbcedularnc.TabIndex = 51;
            this.lbcedularnc.Text = "Cedula/RNC";
            // 
            // lbArticulo
            // 
            this.lbArticulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbArticulo.AutoSize = true;
            this.lbArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbArticulo.ForeColor = System.Drawing.Color.White;
            this.lbArticulo.Location = new System.Drawing.Point(465, 633);
            this.lbArticulo.Name = "lbArticulo";
            this.lbArticulo.Size = new System.Drawing.Size(55, 17);
            this.lbArticulo.TabIndex = 53;
            this.lbArticulo.Text = "Articulo";
            // 
            // lbcotizacion
            // 
            this.lbcotizacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbcotizacion.AutoSize = true;
            this.lbcotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbcotizacion.ForeColor = System.Drawing.Color.White;
            this.lbcotizacion.Location = new System.Drawing.Point(456, 583);
            this.lbcotizacion.Name = "lbcotizacion";
            this.lbcotizacion.Size = new System.Drawing.Size(73, 17);
            this.lbcotizacion.TabIndex = 52;
            this.lbcotizacion.Text = "Cotizacion";
            // 
            // lbCantidad
            // 
            this.lbCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCantidad.ForeColor = System.Drawing.Color.White;
            this.lbCantidad.Location = new System.Drawing.Point(460, 683);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(64, 17);
            this.lbCantidad.TabIndex = 54;
            this.lbCantidad.Text = "Cantidad";
            // 
            // lbfechaCotizacion
            // 
            this.lbfechaCotizacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbfechaCotizacion.AutoSize = true;
            this.lbfechaCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbfechaCotizacion.ForeColor = System.Drawing.Color.White;
            this.lbfechaCotizacion.Location = new System.Drawing.Point(780, 632);
            this.lbfechaCotizacion.Name = "lbfechaCotizacion";
            this.lbfechaCotizacion.Size = new System.Drawing.Size(136, 17);
            this.lbfechaCotizacion.TabIndex = 59;
            this.lbfechaCotizacion.Text = "Fecha de Cotizacion";
            // 
            // lbITBIS
            // 
            this.lbITBIS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbITBIS.AutoSize = true;
            this.lbITBIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbITBIS.ForeColor = System.Drawing.Color.White;
            this.lbITBIS.Location = new System.Drawing.Point(826, 583);
            this.lbITBIS.Name = "lbITBIS";
            this.lbITBIS.Size = new System.Drawing.Size(41, 17);
            this.lbITBIS.TabIndex = 57;
            this.lbITBIS.Text = "ITBIS";
            // 
            // lbDescuento
            // 
            this.lbDescuento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbDescuento.AutoSize = true;
            this.lbDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbDescuento.ForeColor = System.Drawing.Color.White;
            this.lbDescuento.Location = new System.Drawing.Point(814, 533);
            this.lbDescuento.Name = "lbDescuento";
            this.lbDescuento.Size = new System.Drawing.Size(76, 17);
            this.lbDescuento.TabIndex = 56;
            this.lbDescuento.Text = "Descuento";
            // 
            // lbbprecioVenta
            // 
            this.lbbprecioVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbbprecioVenta.AutoSize = true;
            this.lbbprecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbbprecioVenta.ForeColor = System.Drawing.Color.White;
            this.lbbprecioVenta.Location = new System.Drawing.Point(797, 481);
            this.lbbprecioVenta.Name = "lbbprecioVenta";
            this.lbbprecioVenta.Size = new System.Drawing.Size(109, 17);
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
            this.btnLimpiar.Location = new System.Drawing.Point(1163, 617);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(175, 44);
            this.btnLimpiar.TabIndex = 61;
            this.btnLimpiar.Text = "Vaciar Campos";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnCrear
            // 
            this.btnCrear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(171)))), ((int)(((byte)(55)))));
            this.btnCrear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCrear.ForeColor = System.Drawing.Color.White;
            this.btnCrear.Location = new System.Drawing.Point(1163, 506);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(175, 44);
            this.btnCrear.TabIndex = 60;
            this.btnCrear.Text = "Crear Cotizacion";
            this.btnCrear.UseVisualStyleBackColor = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(138)))), ((int)(((byte)(71)))));
            this.btnRegresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(133, 618);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(159, 44);
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
            this.btnActualizar.Location = new System.Drawing.Point(133, 506);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(159, 47);
            this.btnActualizar.TabIndex = 63;
            this.btnActualizar.Text = "Actualizar tabla";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // cotizacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(1526, 733);
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
            this.Controls.Add(this.lbcotizacion);
            this.Controls.Add(this.lbcedularnc);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.txtfechaCotizacion);
            this.Controls.Add(this.txtITBIS);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtprecioVenta);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtArticulo);
            this.Controls.Add(this.txtCotizacion);
            this.Controls.Add(this.txtcedularnc);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dataGridCotizacion);
            this.Controls.Add(this.insertarMercancia);
            this.Name = "cotizacionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cotizacionForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCotizacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label insertarMercancia;
        private System.Windows.Forms.DataGridView dataGridCotizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCotizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedularncCotizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn codCotizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn articuloCotizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadCotizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioventaCotizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuentoCotizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn itbisCotizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn codcotizacionCotizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCotizacion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtcedularnc;
        private System.Windows.Forms.TextBox txtCotizacion;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.TextBox txtfechaCotizacion;
        private System.Windows.Forms.TextBox txtITBIS;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtprecioVenta;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbcedularnc;
        private System.Windows.Forms.Label lbArticulo;
        private System.Windows.Forms.Label lbcotizacion;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.Label lbfechaCotizacion;
        private System.Windows.Forms.Label lbITBIS;
        private System.Windows.Forms.Label lbDescuento;
        private System.Windows.Forms.Label lbbprecioVenta;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnActualizar;
    }
}