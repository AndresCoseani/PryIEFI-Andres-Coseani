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
    public partial class frmCargaVentas : Form
    {
        string[,] MatrizVentas = new string[5,3];
        int Indicefilas;
        int Indicecolumnas;

        public frmCargaVentas()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        void limpiar()
        {
            dtpFechaVentas.Value = DateTime.Today;
            txtIDVentas.Text = "";
            txtNombreVentas.Text = "";

        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            if (txtIDVentas.Text != "")
            {
                if (txtNombreVentas.Text != "")
                {
                    if (dtpFechaVentas.Value >= DateTime.Today)
                    {
                        
                        MatrizVentas[Indicefilas, 0] = txtIDVentas.Text;
                        MatrizVentas[Indicefilas, 1] = txtNombreVentas.Text;
                        MatrizVentas[Indicefilas, 2] = dtpFechaVentas.Value.ToString();

                        while (Indicefilas< MatrizVentas.GetLength(0))
                        {
                            cmdRegistrarVentas.Enabled = false;
                        }


                    }
                    else
                    {
                        MessageBox.Show("La fecha ingresada debe ser actual o una fecha futura", "cargar tarea", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dtpFechaVentas.Value = DateTime.Today;
                        dtpFechaVentas.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Falta completar Nombre");
                    txtNombreVentas.Focus();
                }

            }
            else
            {
                MessageBox.Show("Falta completar ID");
                txtIDVentas.Focus();
            }
            limpiar();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void frmCargaVentas_Load(object sender, EventArgs e)
        {
            Indicecolumnas = 0;
            Indicefilas = 0;

            while (Indicefilas < MatrizVentas.GetLength(0))
            {

                dgvVentas.Rows.Add(MatrizVentas[Indicefilas, 0],
                 MatrizVentas[Indicefilas, 1],
                 MatrizVentas[Indicefilas, 2],
                 MatrizVentas[Indicefilas, 3],
                 MatrizVentas[Indicefilas, 4]);
                Indicefilas++;

            }
        }

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabConsultaVentas_Click(object sender, EventArgs e)
        {

        }
    }
}
