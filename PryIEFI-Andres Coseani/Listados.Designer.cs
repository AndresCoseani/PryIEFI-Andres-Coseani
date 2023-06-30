namespace PryIEFI_Andres_Coseani
{
    partial class frmListados
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
            this.cmdVolveraRegistros = new System.Windows.Forms.Button();
            this.cmdVolverVentas = new System.Windows.Forms.Button();
            this.lstDetallesProductos = new System.Windows.Forms.ListBox();
            this.lstDetallesVentas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdVolveraRegistros
            // 
            this.cmdVolveraRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVolveraRegistros.Location = new System.Drawing.Point(160, 505);
            this.cmdVolveraRegistros.Name = "cmdVolveraRegistros";
            this.cmdVolveraRegistros.Size = new System.Drawing.Size(178, 35);
            this.cmdVolveraRegistros.TabIndex = 0;
            this.cmdVolveraRegistros.Text = "Volver a Registros";
            this.cmdVolveraRegistros.UseVisualStyleBackColor = true;
            this.cmdVolveraRegistros.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdVolverVentas
            // 
            this.cmdVolverVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVolverVentas.Location = new System.Drawing.Point(695, 505);
            this.cmdVolverVentas.Name = "cmdVolverVentas";
            this.cmdVolverVentas.Size = new System.Drawing.Size(178, 35);
            this.cmdVolverVentas.TabIndex = 1;
            this.cmdVolverVentas.Text = "Volver a Ventas";
            this.cmdVolverVentas.UseVisualStyleBackColor = true;
            this.cmdVolverVentas.Click += new System.EventHandler(this.cmdVolverVentas_Click);
            // 
            // lstDetallesProductos
            // 
            this.lstDetallesProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDetallesProductos.FormattingEnabled = true;
            this.lstDetallesProductos.ItemHeight = 25;
            this.lstDetallesProductos.Location = new System.Drawing.Point(9, 35);
            this.lstDetallesProductos.Name = "lstDetallesProductos";
            this.lstDetallesProductos.Size = new System.Drawing.Size(496, 454);
            this.lstDetallesProductos.TabIndex = 6;
            // 
            // lstDetallesVentas
            // 
            this.lstDetallesVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDetallesVentas.FormattingEnabled = true;
            this.lstDetallesVentas.ItemHeight = 25;
            this.lstDetallesVentas.Location = new System.Drawing.Point(511, 35);
            this.lstDetallesVentas.Name = "lstDetallesVentas";
            this.lstDetallesVentas.Size = new System.Drawing.Size(496, 454);
            this.lstDetallesVentas.TabIndex = 8;
            this.lstDetallesVentas.SelectedIndexChanged += new System.EventHandler(this.lstDetallesVentas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Productos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(535, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ventas";
            // 
            // frmListados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 552);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstDetallesVentas);
            this.Controls.Add(this.lstDetallesProductos);
            this.Controls.Add(this.cmdVolverVentas);
            this.Controls.Add(this.cmdVolveraRegistros);
            this.Name = "frmListados";
            this.Text = "Listado";
            this.Load += new System.EventHandler(this.frmListados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdVolveraRegistros;
        private System.Windows.Forms.Button cmdVolverVentas;
        private System.Windows.Forms.ListBox lstDetallesProductos;
        private System.Windows.Forms.ListBox lstDetallesVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}