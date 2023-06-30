namespace PryIEFI_Andres_Coseani
{
    partial class frmCargaVentas
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
            this.tabRegistroVentas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdVerListadoVentas = new System.Windows.Forms.Button();
            this.cmdRegistrarVentas = new System.Windows.Forms.Button();
            this.dtpFechaVentas = new System.Windows.Forms.DateTimePicker();
            this.txtNombreVentas = new System.Windows.Forms.TextBox();
            this.txtIDVentas = new System.Windows.Forms.TextBox();
            this.lblFechaVenta = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblIDVenta = new System.Windows.Forms.Label();
            this.tabConsultaVentas = new System.Windows.Forms.TabPage();
            this.cmdConsultarVentas = new System.Windows.Forms.Button();
            this.tabDatos = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmdMostrarCantidad = new System.Windows.Forms.Button();
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudIngreseCantidad = new System.Windows.Forms.NumericUpDown();
            this.tabNombres = new System.Windows.Forms.TabPage();
            this.cboNombreProductos = new System.Windows.Forms.ComboBox();
            this.lstVentasRegistradas = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdMostrarVentas = new System.Windows.Forms.Button();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabRegistroVentas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.tabConsultaVentas.SuspendLayout();
            this.tabDatos.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIngreseCantidad)).BeginInit();
            this.tabNombres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabRegistroVentas
            // 
            this.tabRegistroVentas.Controls.Add(this.tabPage1);
            this.tabRegistroVentas.Controls.Add(this.tabConsultaVentas);
            this.tabRegistroVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabRegistroVentas.Location = new System.Drawing.Point(11, 12);
            this.tabRegistroVentas.Name = "tabRegistroVentas";
            this.tabRegistroVentas.SelectedIndex = 0;
            this.tabRegistroVentas.Size = new System.Drawing.Size(726, 585);
            this.tabRegistroVentas.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.nudCantidad);
            this.tabPage1.Controls.Add(this.lblCantidad);
            this.tabPage1.Controls.Add(this.cmdCancelar);
            this.tabPage1.Controls.Add(this.cmdVerListadoVentas);
            this.tabPage1.Controls.Add(this.cmdRegistrarVentas);
            this.tabPage1.Controls.Add(this.dtpFechaVentas);
            this.tabPage1.Controls.Add(this.txtNombreVentas);
            this.tabPage1.Controls.Add(this.txtIDVentas);
            this.tabPage1.Controls.Add(this.lblFechaVenta);
            this.tabPage1.Controls.Add(this.lblNombre);
            this.tabPage1.Controls.Add(this.lblIDVenta);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(718, 547);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(260, 242);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(87, 30);
            this.nudCantidad.TabIndex = 12;
            this.nudCantidad.ValueChanged += new System.EventHandler(this.nudCantidad_ValueChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(49, 243);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(109, 29);
            this.lblCantidad.TabIndex = 11;
            this.lblCantidad.Text = "Cantidad";
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Location = new System.Drawing.Point(532, 441);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(143, 49);
            this.cmdCancelar.TabIndex = 9;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            // 
            // cmdVerListadoVentas
            // 
            this.cmdVerListadoVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVerListadoVentas.Location = new System.Drawing.Point(369, 441);
            this.cmdVerListadoVentas.Name = "cmdVerListadoVentas";
            this.cmdVerListadoVentas.Size = new System.Drawing.Size(143, 49);
            this.cmdVerListadoVentas.TabIndex = 8;
            this.cmdVerListadoVentas.Text = "Ver Listado";
            this.cmdVerListadoVentas.UseVisualStyleBackColor = true;
            this.cmdVerListadoVentas.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cmdRegistrarVentas
            // 
            this.cmdRegistrarVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegistrarVentas.Location = new System.Drawing.Point(204, 441);
            this.cmdRegistrarVentas.Name = "cmdRegistrarVentas";
            this.cmdRegistrarVentas.Size = new System.Drawing.Size(143, 49);
            this.cmdRegistrarVentas.TabIndex = 7;
            this.cmdRegistrarVentas.Text = "Registrar";
            this.cmdRegistrarVentas.UseVisualStyleBackColor = true;
            this.cmdRegistrarVentas.Click += new System.EventHandler(this.cmdRegistrar_Click);
            // 
            // dtpFechaVentas
            // 
            this.dtpFechaVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaVentas.Location = new System.Drawing.Point(260, 332);
            this.dtpFechaVentas.Name = "dtpFechaVentas";
            this.dtpFechaVentas.Size = new System.Drawing.Size(356, 30);
            this.dtpFechaVentas.TabIndex = 5;
            this.dtpFechaVentas.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtNombreVentas
            // 
            this.txtNombreVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreVentas.Location = new System.Drawing.Point(260, 146);
            this.txtNombreVentas.Name = "txtNombreVentas";
            this.txtNombreVentas.Size = new System.Drawing.Size(270, 30);
            this.txtNombreVentas.TabIndex = 4;
            // 
            // txtIDVentas
            // 
            this.txtIDVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDVentas.Location = new System.Drawing.Point(260, 53);
            this.txtIDVentas.Name = "txtIDVentas";
            this.txtIDVentas.Size = new System.Drawing.Size(270, 30);
            this.txtIDVentas.TabIndex = 3;
            // 
            // lblFechaVenta
            // 
            this.lblFechaVenta.AutoSize = true;
            this.lblFechaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVenta.Location = new System.Drawing.Point(49, 334);
            this.lblFechaVenta.Name = "lblFechaVenta";
            this.lblFechaVenta.Size = new System.Drawing.Size(80, 29);
            this.lblFechaVenta.TabIndex = 2;
            this.lblFechaVenta.Text = "Fecha";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(49, 147);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(101, 29);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblIDVenta
            // 
            this.lblIDVenta.AutoSize = true;
            this.lblIDVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDVenta.Location = new System.Drawing.Point(49, 54);
            this.lblIDVenta.Name = "lblIDVenta";
            this.lblIDVenta.Size = new System.Drawing.Size(36, 29);
            this.lblIDVenta.TabIndex = 0;
            this.lblIDVenta.Text = "ID";
            // 
            // tabConsultaVentas
            // 
            this.tabConsultaVentas.Controls.Add(this.cmdConsultarVentas);
            this.tabConsultaVentas.Controls.Add(this.tabDatos);
            this.tabConsultaVentas.Controls.Add(this.dgvVentas);
            this.tabConsultaVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabConsultaVentas.Location = new System.Drawing.Point(4, 34);
            this.tabConsultaVentas.Name = "tabConsultaVentas";
            this.tabConsultaVentas.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultaVentas.Size = new System.Drawing.Size(718, 547);
            this.tabConsultaVentas.TabIndex = 1;
            this.tabConsultaVentas.Text = "Consulta";
            this.tabConsultaVentas.UseVisualStyleBackColor = true;
            this.tabConsultaVentas.Click += new System.EventHandler(this.tabConsultaVentas_Click);
            // 
            // cmdConsultarVentas
            // 
            this.cmdConsultarVentas.Location = new System.Drawing.Point(565, 67);
            this.cmdConsultarVentas.Name = "cmdConsultarVentas";
            this.cmdConsultarVentas.Size = new System.Drawing.Size(133, 66);
            this.cmdConsultarVentas.TabIndex = 3;
            this.cmdConsultarVentas.Text = "Consultar";
            this.cmdConsultarVentas.UseVisualStyleBackColor = true;
            this.cmdConsultarVentas.Click += new System.EventHandler(this.cmdConsultarVentas_Click);
            // 
            // tabDatos
            // 
            this.tabDatos.Controls.Add(this.tabPage2);
            this.tabDatos.Controls.Add(this.tabNombres);
            this.tabDatos.Location = new System.Drawing.Point(42, 209);
            this.tabDatos.Name = "tabDatos";
            this.tabDatos.SelectedIndex = 0;
            this.tabDatos.Size = new System.Drawing.Size(632, 323);
            this.tabDatos.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmdMostrarCantidad);
            this.tabPage2.Controls.Add(this.lstResultados);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.nudIngreseCantidad);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(624, 285);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Cantidad";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // cmdMostrarCantidad
            // 
            this.cmdMostrarCantidad.Location = new System.Drawing.Point(431, 33);
            this.cmdMostrarCantidad.Name = "cmdMostrarCantidad";
            this.cmdMostrarCantidad.Size = new System.Drawing.Size(94, 34);
            this.cmdMostrarCantidad.TabIndex = 3;
            this.cmdMostrarCantidad.Text = "Mostrar";
            this.cmdMostrarCantidad.UseVisualStyleBackColor = true;
            this.cmdMostrarCantidad.Click += new System.EventHandler(this.cmdMostrarCantidad_Click);
            // 
            // lstResultados
            // 
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.ItemHeight = 25;
            this.lstResultados.Location = new System.Drawing.Point(39, 86);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(529, 179);
            this.lstResultados.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese cantidad";
            // 
            // nudIngreseCantidad
            // 
            this.nudIngreseCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudIngreseCantidad.Location = new System.Drawing.Point(92, 36);
            this.nudIngreseCantidad.Name = "nudIngreseCantidad";
            this.nudIngreseCantidad.Size = new System.Drawing.Size(158, 30);
            this.nudIngreseCantidad.TabIndex = 0;
            this.nudIngreseCantidad.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // tabNombres
            // 
            this.tabNombres.Controls.Add(this.cboNombreProductos);
            this.tabNombres.Controls.Add(this.lstVentasRegistradas);
            this.tabNombres.Controls.Add(this.label2);
            this.tabNombres.Controls.Add(this.cmdMostrarVentas);
            this.tabNombres.Location = new System.Drawing.Point(4, 34);
            this.tabNombres.Name = "tabNombres";
            this.tabNombres.Padding = new System.Windows.Forms.Padding(3);
            this.tabNombres.Size = new System.Drawing.Size(624, 285);
            this.tabNombres.TabIndex = 1;
            this.tabNombres.Text = "Vendidos";
            this.tabNombres.UseVisualStyleBackColor = true;
            this.tabNombres.Click += new System.EventHandler(this.tabNombres_Click);
            // 
            // cboNombreProductos
            // 
            this.cboNombreProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNombreProductos.FormattingEnabled = true;
            this.cboNombreProductos.Location = new System.Drawing.Point(98, 47);
            this.cboNombreProductos.Name = "cboNombreProductos";
            this.cboNombreProductos.Size = new System.Drawing.Size(198, 28);
            this.cboNombreProductos.TabIndex = 4;
            this.cboNombreProductos.SelectedIndexChanged += new System.EventHandler(this.cboNombreProductos_SelectedIndexChanged);
            // 
            // lstVentasRegistradas
            // 
            this.lstVentasRegistradas.FormattingEnabled = true;
            this.lstVentasRegistradas.ItemHeight = 25;
            this.lstVentasRegistradas.Location = new System.Drawing.Point(39, 91);
            this.lstVentasRegistradas.Name = "lstVentasRegistradas";
            this.lstVentasRegistradas.Size = new System.Drawing.Size(557, 179);
            this.lstVentasRegistradas.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese nombre del producto";
            // 
            // cmdMostrarVentas
            // 
            this.cmdMostrarVentas.Location = new System.Drawing.Point(409, 39);
            this.cmdMostrarVentas.Name = "cmdMostrarVentas";
            this.cmdMostrarVentas.Size = new System.Drawing.Size(112, 38);
            this.cmdMostrarVentas.TabIndex = 0;
            this.cmdMostrarVentas.Text = "Mostrar";
            this.cmdMostrarVentas.UseVisualStyleBackColor = true;
            this.cmdMostrarVentas.Click += new System.EventHandler(this.cmdMostrarVentas_Click);
            // 
            // dgvVentas
            // 
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Nombre,
            this.Column2,
            this.Column3});
            this.dgvVentas.Location = new System.Drawing.Point(6, 6);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.Size = new System.Drawing.Size(543, 197);
            this.dgvVentas.TabIndex = 1;
            this.dgvVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cantidad";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Fecha de Venta";
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // frmCargaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 601);
            this.Controls.Add(this.tabRegistroVentas);
            this.Name = "frmCargaVentas";
            this.Text = "Carga de Ventas";
            this.Load += new System.EventHandler(this.frmCargaVentas_Load);
            this.tabRegistroVentas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.tabConsultaVentas.ResumeLayout(false);
            this.tabDatos.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIngreseCantidad)).EndInit();
            this.tabNombres.ResumeLayout(false);
            this.tabNombres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabRegistroVentas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblIDVenta;
        private System.Windows.Forms.TabPage tabConsultaVentas;
        private System.Windows.Forms.Label lblFechaVenta;
        private System.Windows.Forms.DateTimePicker dtpFechaVentas;
        private System.Windows.Forms.TextBox txtNombreVentas;
        private System.Windows.Forms.TextBox txtIDVentas;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdVerListadoVentas;
        private System.Windows.Forms.Button cmdRegistrarVentas;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TabControl tabDatos;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabNombres;
        private System.Windows.Forms.Button cmdConsultarVentas;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button cmdMostrarCantidad;
        private System.Windows.Forms.ListBox lstResultados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudIngreseCantidad;
        private System.Windows.Forms.ListBox lstVentasRegistradas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdMostrarVentas;
        private System.Windows.Forms.ComboBox cboNombreProductos;
    }
}