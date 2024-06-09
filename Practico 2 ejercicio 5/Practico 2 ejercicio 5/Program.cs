using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico_2_ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> valores = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int sumaTotalValoresParesMayorAOcho = 0;
            int sumaTotalValoresParesMenoresAOcho = 0;

            foreach (var valor in valores)
            {
                if (valor % 2 == 0)
                {
                    if (valor > 8)
                    {
                        sumaTotalValoresParesMayorAOcho += valor;
                    }
                    else
                    {
                        sumaTotalValoresParesMenoresAOcho += valor;
                    }
                }



            }
            Console.WriteLine("NORMAL SIN LINQ: ");
            Console.WriteLine("La suma totalde valores mayores a 8 es: " + sumaTotalValoresParesMayorAOcho);
            Console.WriteLine("La suma totalde valores menores a 8 es: " + sumaTotalValoresParesMenoresAOcho);



            Console.WriteLine("CON LINQ: ");
            Console.WriteLine("La suma total de valores mayores a 8 es: " + Enumerable.Range(1, 20).Where(x=>x % 2 == 0 && x > 8).Sum());
            Console.WriteLine("La suma total de valores menores a 8 es: " + Enumerable.Range(1, 20).Where(x => x % 2 == 0 && x <= 8).Sum());

        }


    }
}
