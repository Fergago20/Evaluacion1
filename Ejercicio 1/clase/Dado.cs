using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.clase
{
    internal class Dado
    {
        // Arreglo que almacena el conteo de datos
        // Es de 13 para almacenar datos de los índices entre el rango 2-12
        // Se hace para evitar complejidad, quedaria los índices 0, 1 y 13 vacios.
        public int[] Resultado = new int[13];

        // Metodo que agrega los elementos al arreglo
        public void Agregar (int i, int contador)
        {
            Resultado[i] = Resultado[i]+ contador;
        }
        
        //Metodo que retorna los valores del arreglo
        public int[] Devolver()
        {
            return Resultado;
        }

        // Metodo que limpia los valores del arreglo
        public void Limpiar ( int i)
        {
            Resultado[i] = 0;
        }
    }
}
