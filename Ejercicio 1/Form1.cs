using Ejercicio_1.clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        Dado dad = new Dado();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int resultado1, resultado2, suma=0;

            // For que iguala todo a cero, para evitar conteo acumulado con anterioridad

            for(int i=2; i<=12; i++)
            {
                dad.Limpiar(i);
            }

            // Agrega las opciones de suma a un listbox
            
            for(int i=2; i<=12; i++)
            {
                lbSuma.Items.Add(i);
            }

            // Se usa para agregar las columnas al DataGridView

            for (int i = 2; i <= 12; i++)
            {
                dgSalida.Columns.Add("Columna" + i.ToString(), i.ToString());
            }

            // Clase encargada del método para obtener numeros aleatorios

            Random random = new Random();
            //Bucle encargado de realizar los 36000 lanzamientos de dados
            for (int i = 1; i <= 36; i++)
            {
                resultado1 = random.Next(1, 7);

                resultado2 = random.Next(1, 7);

                suma = resultado1 + resultado2;

                // Suma al conteo de resultados dependiendo del valor obtenido en la suma
                // Se usa el uno como el incremento aprevochando el método de la clase
                switch (suma)
                {
                    case 2:
                        dad.Agregar(2, 1);
                        break;
                    case 3:
                        dad.Agregar(3, 1);
                        break;
                    case 4:
                        dad.Agregar(4, 1);
                        break;
                    case 5:
                        dad.Agregar(5, 1);
                        break;
                    case 6:
                        dad.Agregar(6, 1);
                        break;
                    case 7:
                        dad.Agregar(7, 1);
                        break;
                    case 8:
                        dad.Agregar(8, 1);
                        break;
                    case 9:
                        dad.Agregar(9, 1);
                        break;
                    case 10:
                        dad.Agregar(10, 1);
                        break;
                    case 11:
                        dad.Agregar(11, 1);
                        break;
                    case 12:
                        dad.Agregar(12, 1);
                        break;
                    default:
                        MessageBox.Show("Opción no válida. Selecciona un número entre 1 y 12.");
                        break;

                }
            }
            // Agrega una fila con el conteo de resultados al DataGridView

            for (int i=2; i<=12; i++)
            {
                dgSalida.Rows[0].Cells[i - 2].Value = dad.Devolver()[i];
            }

            lblRazon.Text = " ";

            // Se encarga de evaluar si los resultados son razonables segun las 
            // probabilidades de resultado
            if (dad.Devolver()[7] >= (36 * (1f / 6f)))
            {
                lblRazon.Text = "Los resultados son razonables.";
            }
            else
            {
                lblRazon.Text = "Los resultados no son razonables.";
            }
            
        }

        private void lbSuma_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Segun lo seleccionado en el list box emita el conteo de resultado
            if (lbSuma.SelectedItem != null)
            {
                int num = (int)lbSuma.SelectedItem;

                lblResultado.Text = salida(num);
            }
        }

        // funcion unica para devolver el conteo
        public string salida (int suma)
        {
            return "La suma igual a " + suma + " ha salido un total de " + dad.Devolver()[suma];
        }
    }
}
