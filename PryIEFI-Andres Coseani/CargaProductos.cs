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
    public partial class frmCargaProductos : Form
    {
        public frmCargaProductos()
        {
            InitializeComponent();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void limpiar()
        {
            dtpFechaRegistro.Value = DateTime.Today;
            txtIDRegistro.Text = "";
            txtNombre.Text = "";
            

        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            if (txtIDRegistro.Text != "")
            {
                if (txtNombre.Text != "")
                {
                    if (dtpFechaRegistro.Value >= DateTime.Today)
                    {
                        //cargar datos de matriz
                        //tengo que hacer la matriz publica
                        //y crear las filas


                    }
                    else
                    {
                        MessageBox.Show("La fecha ingresada debe ser actual o una fecha futura", "cargar tarea", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dtpFechaRegistro.Value= DateTime.Today;
                        dtpFechaRegistro.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Falta completar Nombre");
                    txtNombre.Focus();
                }
                
            }
            else
            {
                MessageBox.Show("Falta completar ID");
                txtIDRegistro.Focus();
            }
            limpiar();
        }

        private void cmdListadodeRegistro_Click(object sender, EventArgs e)
        {
            
            frmListados frmlistados = new frmListados();
            frmlistados.ShowDialog();
            this.Close();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.ShowDialog();
            this.Close();
        }
    }
}
