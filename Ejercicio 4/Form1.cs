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
            lblSalida.Text = " ";
            try
            {
                
                emp.Nombre[index]= tbNombre.Text;
                emp.Ventas[index]= double.Parse(tbVenta.Text);
                emp.Salario[index] = 200 + (emp.Ventas[index] * 0.09);
                emp.Suma = emp.Suma + emp.Salario[index];
                Contar(emp.Salario[index]);

               

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

        void Contar(double salario)
        {

            if (salario >= 200 && salario < 300)
            {
                Agregar(0);
            }
            else if (salario >= 300 && salario < 400)
            {
                Agregar(1);
            }
            else if (salario >= 400 && salario < 500)
            {
                Agregar(2);
            }
            else if (salario >= 500 && salario < 600)
            {
                Agregar(3);
            }
            else if (salario >= 600 && salario < 700)
            {
                Agregar(4);
            }
            else if (salario >= 700 && salario < 800)
            {
                Agregar(5);
            }
            else if (salario >= 800 && salario < 900)
            {
                Agregar(6);
            }
            else if (salario >= 900 && salario < 1000)
            {
                Agregar(7);
            }
            else if (salario >= 1000)
            {
                Agregar(8);
            }
            else
            {
                MessageBox.Show("Salario fuera del rango");
            }
        }
        void Agregar(int j)
        {
            emp.conteo[j] = emp.conteo[j] + 1;
        }

        void Mostrar()
        {
            lbTabla.Items.Clear();
            lbTabla.Items.Add("$200-$299");
            lbTabla.Items.Add("$300-$399");
            lbTabla.Items.Add("$$400-$499");
            lbTabla.Items.Add("$500-$599");
            lbTabla.Items.Add("$600-$699");
            lbTabla.Items.Add("$700-$799");
            lbTabla.Items.Add("$800-$899");
            lbTabla.Items.Add("$900-$999");
            lbTabla.Items.Add("$$1000 o superior");
        }

        private void lbTabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
