using Ejercicio_3.clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3
{
    public partial class Form1 : Form
    {
        //Lista sin limites establecidos para guardar arreglos de un objeto
        private List<Venta> ventas = new List<Venta>();

       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtiene numero de venddedor, producto y la ganancia
            try
            {
                int vendedor = int.Parse(tbVendedor.Text);
                int producto = int.Parse(tbProducto.Text);
                float valorVenta = float.Parse(tbGanancia.Text);

                
                if (vendedor >= 1 && vendedor <= 4 && producto >= 1 && producto <= 5)
                {
                    // Crea un nuevo objeto
                    Venta nuevaVenta = new Venta(vendedor, producto, valorVenta);
                    ventas.Add(nuevaVenta);

                }
                else
                {
                    MessageBox.Show("Error: Vendedor o producto fuera de rango.");
                }

                // Limpiar campos de texto
                tbVendedor.Clear();
                tbProducto.Clear();
                tbGanancia.Clear();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Matriz para almacenar canancias
            float[,] resumenVentas = new float[5, 4];

            // Suma todo el total de ventas
            for (int i = 0; i < ventas.Count; i++)
            {
                Venta venta = ventas[i]; 
                resumenVentas[venta.Producto - 1, venta.Vendedor - 1] += venta.ValorVenta;
            }

            // Añadir al listbox
            lbTabla.Items.Clear();
            lbTabla.Items.Add("Producto/Vendedor   1       2       3       4   | Total Producto");

            //For exclusivo para las columnas
            for (int producto = 0; producto < 5; producto++)
            {
                float totalProducto = 0;
                string linea = $"Producto {producto + 1}       ";

                //For para las filas
                for (int vendedor = 0; vendedor < 4; vendedor++)
                {
                    linea += $"{resumenVentas[producto, vendedor],8:F2} ";
                    totalProducto += resumenVentas[producto, vendedor];
                }

                linea += $"| {totalProducto,8:F2}";
                lbTabla.Items.Add(linea);
            }

            
            lbTabla.Items.Add("----------------------------------------------------------");
            string lineaTotales = "Total Vendedor     ";
            //For empleado para añadir linea de sumas total de productos
            for (int vendedor = 0; vendedor < 4; vendedor++)
            {
                float totalVendedor = 0;
                for (int producto = 0; producto < 5; producto++)
                {
                    totalVendedor += resumenVentas[producto, vendedor];
                }
                lineaTotales += $"{totalVendedor,8:F2} ";
            }
            lbTabla.Items.Add(lineaTotales);
        }
    }
}
