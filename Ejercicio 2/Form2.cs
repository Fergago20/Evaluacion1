using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class Form2 : Form
    {
        int lugar;
        public Form2(int puesto)
        {
            lugar = puesto;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (lugar < 7)
            {
                lblAsiento.Text += " " + lugar.ToString();
                lblEspacio.Text += " Fumadores";
                lblPago.Text += " $200";
            }
            else
            {
                lblAsiento.Text += " " + lugar.ToString();
                lblEspacio.Text += " No Fumadores";
                lblPago.Text += " $150";

            }
        }
    }
}
