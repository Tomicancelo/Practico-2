using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico_2_ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //A)
            Console.WriteLine("La suma total es: " + Enumerable.Range(1, 9).Sum());
            //B)
            Console.WriteLine("La suma de valores pares es: " + Enumerable.Range(1, 9).Where(x => x % 2 == 0).Sum());

        }
    }
}
