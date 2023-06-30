using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PryIEFI_Andres_Coseani
{
    public partial class frmCargaVentas : Form
    {
        public string[,] MatrizVentas = new string[5,4];
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
            frmListados frmListados = new frmListados("Ventas", MatrizVentas);
            frmListados.ShowDialog();
        }
        void limpiar()
        {
            dtpFechaVentas.Value = DateTime.Today;
            txtIDVentas.Text = "";
            txtNombreVentas.Text = "";
            nudCantidad.Text = "";

        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            if (txtIDVentas.Text != "")
            {
                if (txtNombreVentas.Text != "")
                {
                    if (nudCantidad.Value > 0)
                    {


                        if (dtpFechaVentas.Value >= DateTime.Today)
                        {

                            MatrizVentas[Indicefilas, 0] = txtIDVentas.Text;
                            MatrizVentas[Indicefilas, 1] = txtNombreVentas.Text;
                            MatrizVentas[Indicefilas, 2] = nudCantidad.Text;
                            MatrizVentas[Indicefilas, 3] = dtpFechaVentas.Value.ToString();

                            Indicefilas++;

                            if (Indicefilas == MatrizVentas.GetLength(0))
                            {
                                cmdRegistrarVentas.Enabled = false;
                            }

                            limpiar();
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
                        MessageBox.Show("Falta completar Cantidad");
                        nudCantidad.Focus();
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
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void frmCargaVentas_Load(object sender, EventArgs e)
        {
            
        }

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tabConsultaVentas_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdConsultarVentas_Click(object sender, EventArgs e)
        {
            Indicecolumnas = 0;
            Indicefilas = 0;

            for (int Indicefilas = 0; Indicefilas < MatrizVentas.GetLength(0);)
            {
                cboNombreProductos.Items.Add(MatrizVentas[Indicefilas, 1]);

                Indicefilas++;
                
            }
            
            while (Indicefilas < MatrizVentas.GetLength(0))
            {

                dgvVentas.Rows.Add(MatrizVentas[Indicefilas, 0],
                MatrizVentas[Indicefilas, 1],
                MatrizVentas[Indicefilas, 2],
                MatrizVentas[Indicefilas, 3]);
                

                Indicefilas++;

            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void cmdMostrarCantidad_Click(object sender, EventArgs e)
        {
            //tryParse es para identificar/leer el texto q esta en la matriz y con out int valor 
            //saca el valor 
            int CantidadIngresada = (int)nudIngreseCantidad.Value;

            int filas = MatrizVentas.GetLength(0);
            int columnas = MatrizVentas.GetLength(1);

            for (int Indicefilas = 0; Indicefilas < filas; Indicefilas++)
            {
                for (int Indicecolumnas = 0; Indicecolumnas < columnas; Indicecolumnas++)
                {
                    if (int.TryParse(MatrizVentas[Indicefilas, Indicecolumnas], out int valor))
                    {
                        if (valor > CantidadIngresada)
                        {
                            lstResultados.Items.Add(valor);
                        }
                    }
                }
            }
        }

        private void cmdMostrarVentas_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboNombreProductos.Text))
            {
                cmdMostrarVentas.Enabled = false;
            }

            string ComboBox = cboNombreProductos.Text;
            {

                lstVentasRegistradas.Items.Clear();


                int IndiceColumna = cboNombreProductos.SelectedIndex;


                for (int Indicefilas = 0; Indicefilas < MatrizVentas.GetLength(0); Indicefilas++)
                {
                    ComboBox = Indicefilas.ToString();
                    string Matriz = MatrizVentas[Indicefilas, IndiceColumna];
                    lstVentasRegistradas.Items.Add(MatrizVentas[Indicefilas, 1]);
                    lstVentasRegistradas.Items.Add(MatrizVentas[Indicefilas, 0]);
                    lstVentasRegistradas.Items.Add(MatrizVentas[Indicefilas, 2]);
                    lstVentasRegistradas.Items.Add(MatrizVentas[Indicefilas, 3]);
                }
            }

        }

        private void cboNombreProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tabNombres_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
