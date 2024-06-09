using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico_2_ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> valores = new List<int>() { 5, 2, 3, 8, 1, 6, 4, 7, 9 };

            valores.OrderBy(x=>x).ToList().ForEach(x => Console.WriteLine(x));
            
        }

        //el bloque anterior tenia un bulce de for sirve para recorrer la lista valor por valor, dentro del for 
        //hay un if que lo que hace es comparar el valor con el siguiente para ordenarla. 
        //luego tenemos un foreach que imprime la lista.
    }
}
