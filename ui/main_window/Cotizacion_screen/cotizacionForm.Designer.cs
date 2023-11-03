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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCotizacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCotizacion.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridCotizacion.Size = new System.Drawing.Size(1219, 558);
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
            // btnCrear
            // 
            this.btnCrear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(171)))), ((int)(((byte)(55)))));
            this.btnCrear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCrear.ForeColor = System.Drawing.Color.White;
            this.btnCrear.Location = new System.Drawing.Point(1177, 677);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(175, 44);
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
            this.btnRegresar.Location = new System.Drawing.Point(133, 678);
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
            this.btnActualizar.Location = new System.Drawing.Point(328, 678);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(159, 43);
            this.btnActualizar.TabIndex = 63;
            this.btnActualizar.Text = "Actualizar tabla";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // cotizacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(1526, 733);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.dataGridCotizacion);
            this.Controls.Add(this.insertarMercancia);
            this.Name = "cotizacionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cotizacionForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCotizacion)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnActualizar;
    }
}