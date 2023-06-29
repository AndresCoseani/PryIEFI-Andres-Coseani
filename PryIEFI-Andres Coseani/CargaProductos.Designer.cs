namespace PryIEFI_Andres_Coseani
{
    partial class frmCargaProductos
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
            this.tabVentanaRegistro = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmdListadodeRegistro = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdRegistrar = new System.Windows.Forms.Button();
            this.lblFechaRegistro = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblIDRegistro = new System.Windows.Forms.Label();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIDRegistro = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvCarga = new System.Windows.Forms.DataGridView();
            this.IDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabVentanaRegistro.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarga)).BeginInit();
            this.SuspendLayout();
            // 
            // tabVentanaRegistro
            // 
            this.tabVentanaRegistro.AccessibleDescription = "";
            this.tabVentanaRegistro.AccessibleName = "";
            this.tabVentanaRegistro.Controls.Add(this.tabPage1);
            this.tabVentanaRegistro.Controls.Add(this.tabPage2);
            this.tabVentanaRegistro.Location = new System.Drawing.Point(12, 12);
            this.tabVentanaRegistro.Name = "tabVentanaRegistro";
            this.tabVentanaRegistro.SelectedIndex = 0;
            this.tabVentanaRegistro.Size = new System.Drawing.Size(709, 428);
            this.tabVentanaRegistro.TabIndex = 0;
            this.tabVentanaRegistro.Tag = "Registro";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmdListadodeRegistro);
            this.tabPage1.Controls.Add(this.cmdCancelar);
            this.tabPage1.Controls.Add(this.cmdRegistrar);
            this.tabPage1.Controls.Add(this.lblFechaRegistro);
            this.tabPage1.Controls.Add(this.lblNombre);
            this.tabPage1.Controls.Add(this.lblIDRegistro);
            this.tabPage1.Controls.Add(this.dtpFechaRegistro);
            this.tabPage1.Controls.Add(this.txtNombre);
            this.tabPage1.Controls.Add(this.txtIDRegistro);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(701, 402);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmdListadodeRegistro
            // 
            this.cmdListadodeRegistro.Location = new System.Drawing.Point(361, 320);
            this.cmdListadodeRegistro.Name = "cmdListadodeRegistro";
            this.cmdListadodeRegistro.Size = new System.Drawing.Size(140, 49);
            this.cmdListadodeRegistro.TabIndex = 8;
            this.cmdListadodeRegistro.Text = "Ver Listados";
            this.cmdListadodeRegistro.UseVisualStyleBackColor = true;
            this.cmdListadodeRegistro.Click += new System.EventHandler(this.cmdListadodeRegistro_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(517, 320);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(143, 49);
            this.cmdCancelar.TabIndex = 7;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdRegistrar
            // 
            this.cmdRegistrar.Location = new System.Drawing.Point(198, 320);
            this.cmdRegistrar.Name = "cmdRegistrar";
            this.cmdRegistrar.Size = new System.Drawing.Size(143, 49);
            this.cmdRegistrar.TabIndex = 6;
            this.cmdRegistrar.Text = "Registrar";
            this.cmdRegistrar.UseVisualStyleBackColor = true;
            this.cmdRegistrar.Click += new System.EventHandler(this.cmdRegistrar_Click);
            // 
            // lblFechaRegistro
            // 
            this.lblFechaRegistro.AutoSize = true;
            this.lblFechaRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaRegistro.Location = new System.Drawing.Point(46, 233);
            this.lblFechaRegistro.Name = "lblFechaRegistro";
            this.lblFechaRegistro.Size = new System.Drawing.Size(80, 29);
            this.lblFechaRegistro.TabIndex = 5;
            this.lblFechaRegistro.Text = "Fecha";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(45, 142);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(101, 29);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // lblIDRegistro
            // 
            this.lblIDRegistro.AutoSize = true;
            this.lblIDRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDRegistro.Location = new System.Drawing.Point(46, 55);
            this.lblIDRegistro.Name = "lblIDRegistro";
            this.lblIDRegistro.Size = new System.Drawing.Size(36, 29);
            this.lblIDRegistro.TabIndex = 3;
            this.lblIDRegistro.Text = "ID";
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.Location = new System.Drawing.Point(267, 233);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(360, 30);
            this.dtpFechaRegistro.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(267, 142);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(244, 30);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtIDRegistro
            // 
            this.txtIDRegistro.Location = new System.Drawing.Point(267, 55);
            this.txtIDRegistro.Name = "txtIDRegistro";
            this.txtIDRegistro.Size = new System.Drawing.Size(244, 30);
            this.txtIDRegistro.TabIndex = 0;
            this.txtIDRegistro.TextChanged += new System.EventHandler(this.txtIDRegistro_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvCarga);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(701, 402);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvCarga
            // 
            this.dgvCarga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarga.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDProducto,
            this.NombreProducto,
            this.FechaRegistro});
            this.dgvCarga.Location = new System.Drawing.Point(121, 62);
            this.dgvCarga.Name = "dgvCarga";
            this.dgvCarga.Size = new System.Drawing.Size(444, 293);
            this.dgvCarga.TabIndex = 1;
            this.dgvCarga.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // IDProducto
            // 
            this.IDProducto.HeaderText = "ID";
            this.IDProducto.Name = "IDProducto";
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Nombre";
            this.NombreProducto.Name = "NombreProducto";
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "FechadeRegistro";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.Width = 200;
            // 
            // frmCargaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 450);
            this.Controls.Add(this.tabVentanaRegistro);
            this.Name = "frmCargaProductos";
            this.Text = "Carga de Productos";
            this.Load += new System.EventHandler(this.frmCargaProductos_Load);
            this.tabVentanaRegistro.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarga)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabVentanaRegistro;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistro;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIDRegistro;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button cmdListadodeRegistro;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdRegistrar;
        private System.Windows.Forms.Label lblFechaRegistro;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblIDRegistro;
        private System.Windows.Forms.DataGridView dgvCarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
    }
}