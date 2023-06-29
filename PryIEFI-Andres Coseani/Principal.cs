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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void cmdProductos_Click(object sender, EventArgs e)
        {
            frmCargaProductos frmProductos = new frmCargaProductos();
            frmProductos.ShowDialog();
            frmProductos.Close();
        }

        private void cmdVentas_Click(object sender, EventArgs e)
        {
            frmCargaVentas frmVentas = new frmCargaVentas();
            frmVentas.ShowDialog();
            this.Close();
        }
    }
}
