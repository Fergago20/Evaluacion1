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
    public partial class Form2 : Form
    {Venta ven = new Venta();
        int index = 0;
        int num;
        public Form2(int vendedor)
        {
            num = vendedor;
            InitializeComponent();
            lblPro.Text = lblPro.Text + (index + 1);
            lblPro.Text = lblPro.Text + (index + 1);
        }
        bool Verificar(string palabra, string[] valor)
        {
            return valor.Contains(palabra);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbCosto.Clear();
            tbProducto.Clear();
            if (index < 6)
            {
                if ((!string.IsNullOrEmpty(tbProducto.Text)) && (!string.IsNullOrEmpty(tbCosto.Text)))
                {
                    // Verificar si el producto ya está en la lista, pero también considerar si el índice actual ya tiene un producto
                    if (Verificar(tbProducto.Text, ven.Producto) || ven.Producto[index] == tbProducto.Text)
                    {
                        ven.Producto[index] = tbProducto.Text;
                        try
                        {
                            ven.Ganancia[num, index] = int.Parse(tbCosto.Text);
                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message); }
                    }
                    else
                    {
                        MessageBox.Show("Error de entrada, producto ya agregado.");
                    }
                }
                else { MessageBox.Show(" agregado."); }

                index++; 
                tbProducto.Focus();
                tbCosto.Focus();
            }else this.Close();
        }

        void Tabla()
        {

        }
    }
    }