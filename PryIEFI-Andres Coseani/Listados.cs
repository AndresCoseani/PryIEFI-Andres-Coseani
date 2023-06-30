using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryIEFI_Andres_Coseani
{
    public partial class frmListados : Form
    {
        frmCargaProductos VentanaProductos = new frmCargaProductos();
        frmCargaVentas VentanaVentas = new frmCargaVentas();
        string[,] MatrizListados;
        string varOperacion;
        int IndiceFilas, IndiceColumnas;

        public frmListados(string varOperacion, string[,] MatrizListados)
        {
            InitializeComponent();

            if (varOperacion == "Productos")
            {



                for (int f = 0; f < MatrizListados.GetLength(0); f++)
                {
                    if (MatrizListados[f, 0] != null)
                    {
                        lstDetallesProductos.Items.Add("Producto " + (IndiceFilas, +1).ToString());
                        lstDetallesProductos.Items.Add(" ID: " + MatrizListados[IndiceFilas, 0] + " \nNombre: " + MatrizListados[IndiceFilas, 1]
                            + " \nFecha: " + MatrizListados[f, 2]);
                    }
                }
            }
            else
            {

                if (varOperacion == "Ventas")
                {
                    this.Text = "Listado de Ventas";
                    for (int IndiceFilas = 0; IndiceFilas < MatrizListados.GetLength(0); IndiceFilas++)
                    {
                        if (MatrizListados[IndiceFilas, 0] != null)
                        {
                            lstDetallesVentas.Items.Add("Ventas " + (IndiceFilas, +1).ToString());
                            lstDetallesVentas.Items.Add(" ID: " + MatrizListados[IndiceFilas, 0] + " \nProducto: " + MatrizListados[IndiceFilas, 1] + " \nCantidad: " + MatrizListados[IndiceFilas, 2]
                                + " \nFecha:" + MatrizListados[IndiceFilas, 3]);
                        }
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmCargaProductos frmCargaProductos = new frmCargaProductos();
            frmCargaProductos.ShowDialog();
            this.Close();
        }

        private void cmdVolverVentas_Click(object sender, EventArgs e)
        {
            frmCargaVentas frmCargarVentas = new frmCargaVentas();
            frmCargarVentas.ShowDialog();
            this.Close();
        }

        
        private void frmListados_Load(object sender, EventArgs e)
        {
            //int IndiceFilasP = 0;
            //int IndiceColumnasP = 0;

            //for (int IndicefilasP = 0; IndiceFilasP < VentanaProductos.MatrizProductos.GetLength(0); IndiceFilasP++)
            //{
            //    string filaP = "\"" + VentanaProductos.MatrizProductos[IndiceFilasP, IndiceColumnasP] + "\" ";
            //    ;
            //    for (int IndicecolumnasP = 0; IndiceColumnasP < VentanaProductos.MatrizProductos.GetLength(1); IndiceColumnasP++)
            //    {
            //        filaP += VentanaProductos.MatrizProductos[IndiceFilasP, IndiceColumnasP] + " ";
            //    }
            //    lstDetallesProductos.Items.Add(filaP.Trim());



          
            
            

        }
        


        private void lstDetallesVentas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    } 
}

