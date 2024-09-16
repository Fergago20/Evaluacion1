using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio_2;

namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        Avion av = new Avion();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Esto verifica si todos los asientos están ocupados
            if(Validacion(0, 5) && Validacion(5, 10))
            {
                MessageBox.Show("El próximo vuelo sale en 3 horas.");
                for(int i =0; i < 10; i++)
                {
                    av.Asignar(false, i);
                }
                this.Close();
            }
            //Try-Catch para evitar errores de entrada y de programa
            int opcion;
            try
            {
                opcion = int.Parse(tbEleccion.Text);
                if (opcion < 1 || opcion > 2)
                    MessageBox.Show("Error de entrada");
                TomaDecisiones(opcion);
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        // Verifica las opciones disponibles, los asientos y da opciones si están llenos
        void TomaDecisiones(int opcion)
        {
            
            if ((opcion == 1 && !Validacion(0, 5)) || (opcion == 2 && !Validacion(5, 10)))
            {
                lblDuda.Text = " ";
                Disponibilidad(opcion);
            }
            else if (opcion == 1 && Validacion(0, 5))
            {
                DialogResult respuesta=MessageBox.Show( "Desea buscar en la otra opcion?", "Seccion ocupada",
                    MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes)
                    Disponibilidad(2);
                else MessageBox.Show("Proximo vuelo en tres horas");
            }
            else if(opcion == 2 && Validacion(5, 10))
            {
                DialogResult respuesta = MessageBox.Show("Desea buscar en la otra opcion?", "Seccion ocupada",
                    MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes)
                    Disponibilidad(1);
                else MessageBox.Show("Proximo vuelo en tres horas");
            }
        }
      
        //Muestra en un list box los asientos disponibles

        void Disponibilidad(int opcion)
        {
            lbAsientos.Items.Clear();
            if (opcion == 1)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (!av.Devolver()[i])
                    {
                        lbAsientos.Items.Add(i+1);
                    }
                }
            }
            if (opcion == 2)
            {
                for (int i = 5; i < 10; i++)
                {
                    if (!av.Devolver()[i])
                    {
                        lbAsientos.Items.Add(i+1);
                    }
                }
            }
        }

        //Funcion empleada para verificar si hay asientos disponibles
        bool Validacion(int contador, int tope)
        {
            
            for ( int i= contador ; i < tope; i++)
            {
                if (!av.Devolver()[i])
                {
                    return false;
                }
            }
            return true;
        }

        //Funcion que selecciona un item del listbox y emitir un recibo de pago
        private void lbAsientos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAsientos.SelectedItem != null)
            {
                int puesto = (int)lbAsientos.SelectedItem;
                av.Asignar(true, puesto - 1);
                //Abre otro formulario de salida
                using (Form2 pase = new Form2(puesto)) pase.ShowDialog();
                lbAsientos.Items.Clear();
                lblDuda.Text = " ";
                tbEleccion.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un asiento.");
            }

        }

      
        //Funcion empleada para tocar una tecla enter para introducir datos
        private void tbEleccion_KeyPress(object sender, KeyPressEventArgs e)
        {if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    int opcion;
                    opcion = int.Parse(tbEleccion.Text);
                    if (opcion < 1 || opcion > 2)
                        MessageBox.Show("Error de entrada");
                    else TomaDecisiones(opcion);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
