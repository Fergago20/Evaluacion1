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
        int index = 0;

        Venta ven = new Venta();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Agregar(index);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        void Agregar (int index)
        {
            
            dgMatriz.Columns.Add("Producto ", "Productos");
            if (!string.IsNullOrEmpty(tbVendedor.Text) && !Verificar(tbVendedor.Text, ven.Vendedor))
            {
                ven.Vendedor[index] = tbVendedor.Text;
                dgMatriz.Columns.Add("Vendedor " + (index + 1).ToString(), ven.Vendedor[index]);

            }

            using (Form2 materias = new Form2(index)) materias.ShowDialog();
            Llenar();

            index++;
        }

        bool Verificar (string palabra, string[] valor)
        {
               for (int i = 0; i < valor.Length; i++)
                {
                    if (valor[i]== palabra)
                    {
                        return true;
                    }
                }
            return false;
        }

        void Llenar()
        {
            for(int i = 0; i< index; i++)
            {
                dgMatriz.Rows[index].Cells[i].Value= ven.Ganancia[index, i];
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblVen.Text = lblVen.Text + index + 1;
        }
    }
}
