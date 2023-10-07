namespace Negocio.ui.Invetario_screen
{
    partial class AgregarForm
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtFamilia = new System.Windows.Forms.TextBox();
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.numPrecioCompra = new System.Windows.Forms.NumericUpDown();
            this.numMargen = new System.Windows.Forms.NumericUpDown();
            this.numPrecioVenta = new System.Windows.Forms.NumericUpDown();
            this.dateFecha = new System.Windows.Forms.DateTimePicker();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMargen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(28, 43);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 22);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(30, 115);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // txtFamilia
            // 
            this.txtFamilia.Location = new System.Drawing.Point(203, 43);
            this.txtFamilia.Name = "txtFamilia";
            this.txtFamilia.Size = new System.Drawing.Size(100, 22);
            this.txtFamilia.TabIndex = 3;
            // 
            // txtUnidad
            // 
            this.txtUnidad.Location = new System.Drawing.Point(203, 115);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(100, 22);
            this.txtUnidad.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dateFecha);
            this.panel1.Controls.Add(this.numPrecioVenta);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.numMargen);
            this.panel1.Controls.Add(this.numPrecioCompra);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.numCantidad);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtFamilia);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtUnidad);
            this.panel1.Location = new System.Drawing.Point(70, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 256);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Codigo del articulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre del articulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Familia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Unidad de medida";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(205, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Precio de compra";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(357, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Margen de beneficio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(367, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Precio de venta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(361, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Fecha de creacion";
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(24, 181);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(120, 22);
            this.numCantidad.TabIndex = 19;
            // 
            // numPrecioCompra
            // 
            this.numPrecioCompra.Location = new System.Drawing.Point(199, 181);
            this.numPrecioCompra.Name = "numPrecioCompra";
            this.numPrecioCompra.Size = new System.Drawing.Size(120, 22);
            this.numPrecioCompra.TabIndex = 19;
            // 
            // numMargen
            // 
            this.numMargen.Location = new System.Drawing.Point(360, 44);
            this.numMargen.Name = "numMargen";
            this.numMargen.Size = new System.Drawing.Size(120, 22);
            this.numMargen.TabIndex = 20;
            // 
            // numPrecioVenta
            // 
            this.numPrecioVenta.Location = new System.Drawing.Point(360, 115);
            this.numPrecioVenta.Name = "numPrecioVenta";
            this.numPrecioVenta.Size = new System.Drawing.Size(120, 22);
            this.numPrecioVenta.TabIndex = 21;
            // 
            // dateFecha
            // 
            this.dateFecha.Location = new System.Drawing.Point(360, 181);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Size = new System.Drawing.Size(288, 22);
            this.dateFecha.TabIndex = 22;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Image = global::Negocio.Properties.Resources._return;
            this.btnRegresar.Location = new System.Drawing.Point(196, 367);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(107, 87);
            this.btnRegresar.TabIndex = 11;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::Negocio.Properties.Resources.plus;
            this.btnAgregar.Location = new System.Drawing.Point(70, 367);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(108, 87);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // AgregarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 550);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.panel1);
            this.Name = "AgregarForm";
            this.Text = "AgregarForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMargen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtFamilia;
        private System.Windows.Forms.TextBox txtUnidad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateFecha;
        private System.Windows.Forms.NumericUpDown numPrecioVenta;
        private System.Windows.Forms.NumericUpDown numMargen;
        private System.Windows.Forms.NumericUpDown numPrecioCompra;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnRegresar;
    }
}