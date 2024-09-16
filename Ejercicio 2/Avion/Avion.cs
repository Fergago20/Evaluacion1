using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Avion
    {
        public Avion() { }
        bool[] Asiento = new bool[10];

        public void Asignar (bool valor, int i)
        {
            if (valor) { Asiento[i] = valor; }
        }

        public bool[] Devolver()
        {
            return Asiento;
        }
    }
}
