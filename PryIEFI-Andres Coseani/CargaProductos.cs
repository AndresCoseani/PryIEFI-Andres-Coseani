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
        public string[,] MatrizProductos = new string[5,3];
        int Indicefilas;
        int Indicecolumnas;

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
                        MatrizProductos[Indicefilas, 0] = txtIDRegistro.Text;
                        MatrizProductos[Indicefilas, 1] = txtNombre.Text;
                        MatrizProductos[Indicefilas, 2] = dtpFechaRegistro.Value.ToString();


                        Indicefilas++;

                        if (Indicefilas == MatrizProductos.GetLength(0))
                        {
                            cmdRegistrar.Enabled = false;
                        }


                        limpiar();
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
            
        }

        private void cmdListadodeRegistro_Click(object sender, EventArgs e)
        {
            
            frmListados frmlistados = new frmListados("Productos", MatrizProductos);
            frmlistados.ShowDialog();
            this.Close();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.ShowDialog();
            this.Close();
        }

        private void txtIDRegistro_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCargaProductos_Load(object sender, EventArgs e)
        {
            

        }

        private void cmdConsultarCargas_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
                    
        }

        private void cmdConsultarProducto_Click(object sender, EventArgs e)
        {
            Indicecolumnas = 0;
            Indicefilas = 0;

            while (Indicefilas < MatrizProductos.GetLength(0))
            {

                dgvCarga.Rows.Add(MatrizProductos[Indicefilas, 0],
                MatrizProductos[Indicefilas, 1],
                MatrizProductos[Indicefilas, 2]);


                Indicefilas++;
  

            }
        }
    }
}
