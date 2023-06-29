using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryIEFI_Andres_Coseani
{
    public partial class frmListados : Form
    {
        public frmListados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCargaProductos frmCargaProductos = new frmCargaProductos();
            frmCargaProductos.ShowDialog();
            this.Close();
        }

        private void cmdVolverVentas_Click(object sender, EventArgs e)
        {
            frmCargaVentas frmCargarVentas =    new frmCargaVentas();
            frmCargarVentas.ShowDialog();
            this.Close();
        }
    }
}
