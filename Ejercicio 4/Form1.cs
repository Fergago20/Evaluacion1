using Ejercicio_4.clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_4
{
    public partial class Form1 : Form
    {
        Empresa emp = new Empresa();
        int index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            emp.Suma = 0;
            lblSalida.Text = " ";
            try
            {
                
                emp.Nombre[index]= tbNombre.Text;
                emp.Ventas[index]= double.Parse(tbVenta.Text);
                emp.Salario[index] = 200 + (emp.Ventas[index] * 0.09);
                emp.Suma = emp.Suma + emp.Salario[index];

               

                lblSalida.Text = "El Salario total es de: " + emp.Salario[index];
                lblSuma.Text = "La suma total es de: " + emp.Suma;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            index++;
            tbNombre.Clear();
            tbVenta.Clear();
            tbNombre.Focus();
        }
    }
}
