using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4.clase
{
    internal class Empresa
    {
        public Empresa() { }
        public string[] Nombre = new string[10];
        public double[] Ventas = new double[10];
        public double[] Salario = new double[10];
        public double Suma {  get; set; }
        public int[] conteo = new int[10];
    }
}
