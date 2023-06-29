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
            this.dtpFechaVentas = new System.Windows.Forms.DateTimePicker();
            this.txtNombreVentas = new System.Windows.Forms.TextBox();
            this.txtIDVentas = new System.Windows.Forms.TextBox();
            this.lblFechaVenta = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblIDVenta = new System.Windows.Forms.Label();
            this.tabConsultaVentas = new System.Windows.Forms.TabPage();
            this.cmdRegistrarVentas = new System.Windows.Forms.Button();
            this.cmdVerListadoVentas = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabRegistroVentas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabConsultaVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabRegistroVentas
            // 
            this.tabRegistroVentas.Controls.Add(this.tabPage1);
            this.tabRegistroVentas.Controls.Add(this.tabConsultaVentas);
            this.tabRegistroVentas.Location = new System.Drawing.Point(11, 12);
            this.tabRegistroVentas.Name = "tabRegistroVentas";
            this.tabRegistroVentas.SelectedIndex = 0;
            this.tabRegistroVentas.Size = new System.Drawing.Size(726, 427);
            this.tabRegistroVentas.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmdCancelar);
            this.tabPage1.Controls.Add(this.cmdVerListadoVentas);
            this.tabPage1.Controls.Add(this.cmdRegistrarVentas);
            this.tabPage1.Controls.Add(this.dtpFechaVentas);
            this.tabPage1.Controls.Add(this.txtNombreVentas);
            this.tabPage1.Controls.Add(this.txtIDVentas);
            this.tabPage1.Controls.Add(this.lblFechaVenta);
            this.tabPage1.Controls.Add(this.lblNombre);
            this.tabPage1.Controls.Add(this.lblIDVenta);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(718, 401);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtpFechaVentas
            // 
            this.dtpFechaVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaVentas.Location = new System.Drawing.Point(260, 238);
            this.dtpFechaVentas.Name = "dtpFechaVentas";
            this.dtpFechaVentas.Size = new System.Drawing.Size(356, 30);
            this.dtpFechaVentas.TabIndex = 5;
            this.dtpFechaVentas.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtNombreVentas
            // 
            this.txtNombreVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreVentas.Location = new System.Drawing.Point(260, 141);
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
            this.lblFechaVenta.Location = new System.Drawing.Point(49, 238);
            this.lblFechaVenta.Name = "lblFechaVenta";
            this.lblFechaVenta.Size = new System.Drawing.Size(80, 29);
            this.lblFechaVenta.TabIndex = 2;
            this.lblFechaVenta.Text = "Fecha";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(49, 141);
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
            this.tabConsultaVentas.Controls.Add(this.dgvVentas);
            this.tabConsultaVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabConsultaVentas.Location = new System.Drawing.Point(4, 22);
            this.tabConsultaVentas.Name = "tabConsultaVentas";
            this.tabConsultaVentas.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultaVentas.Size = new System.Drawing.Size(718, 401);
            this.tabConsultaVentas.TabIndex = 1;
            this.tabConsultaVentas.Text = "Consulta";
            this.tabConsultaVentas.UseVisualStyleBackColor = true;
            this.tabConsultaVentas.Click += new System.EventHandler(this.tabConsultaVentas_Click);
            // 
            // cmdRegistrarVentas
            // 
            this.cmdRegistrarVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegistrarVentas.Location = new System.Drawing.Point(204, 325);
            this.cmdRegistrarVentas.Name = "cmdRegistrarVentas";
            this.cmdRegistrarVentas.Size = new System.Drawing.Size(143, 49);
            this.cmdRegistrarVentas.TabIndex = 7;
            this.cmdRegistrarVentas.Text = "Registrar";
            this.cmdRegistrarVentas.UseVisualStyleBackColor = true;
            this.cmdRegistrarVentas.Click += new System.EventHandler(this.cmdRegistrar_Click);
            // 
            // cmdVerListadoVentas
            // 
            this.cmdVerListadoVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVerListadoVentas.Location = new System.Drawing.Point(366, 325);
            this.cmdVerListadoVentas.Name = "cmdVerListadoVentas";
            this.cmdVerListadoVentas.Size = new System.Drawing.Size(143, 49);
            this.cmdVerListadoVentas.TabIndex = 8;
            this.cmdVerListadoVentas.Text = "Ver Listado";
            this.cmdVerListadoVentas.UseVisualStyleBackColor = true;
            this.cmdVerListadoVentas.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Location = new System.Drawing.Point(527, 325);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(143, 49);
            this.cmdCancelar.TabIndex = 9;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            // 
            // dgvVentas
            // 
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Nombre,
            this.Column3});
            this.dgvVentas.Location = new System.Drawing.Point(138, 54);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.Size = new System.Drawing.Size(443, 273);
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
            this.ClientSize = new System.Drawing.Size(749, 450);
            this.Controls.Add(this.tabRegistroVentas);
            this.Name = "frmCargaVentas";
            this.Text = "Carga de Ventas";
            this.Load += new System.EventHandler(this.frmCargaVentas_Load);
            this.tabRegistroVentas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabConsultaVentas.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}