using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico_2_Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una letra minusculra (desde a hasta f) para saber cual es la siguiente letra del abecedario ");
            string letra = Console.ReadLine();

            if (letra == "a")
            {
                Console.WriteLine("La siguiente letra es B !!");
            }
            if (letra == "b")
            {
                Console.WriteLine("La siguiente letra es C !!");
            }
            if (letra == "c")
            {
                Console.WriteLine("La siguiente letra es D !!");
            }

            if (letra == "d")
            {
                Console.WriteLine("La siguiente letra es E !!");
            }
            if (letra == "e")
            {
                Console.WriteLine("La siguiente letra es F !!");
            }
            if (letra == "f")
            {
                Console.WriteLine("La siguiente letra es G !!");
            }
            if (letra == "g")
            {
                Console.WriteLine("La siguiente letra es H !!");
            }
            if (letra == "h")
            {
                Console.WriteLine("La siguiente letra es I !!");
            }
            if (letra == "i")
            {
                Console.WriteLine("La siguiente letra es J !!");
            }

            Console.WriteLine("Ingrese una letra minuscula (desde a hasta f) para saber cual es la siguiente letra del abecedario ");

            // Verifica si la entrada es válida
            if (letra.Length == 1 && letra[0] >= 'a' && letra[0] < 'z')
            {
                // Calcula y muestra la siguiente letra
                char siguiente = (char)(letra[0] + 1);
                Console.WriteLine($"La siguiente letra es {siguiente} !!");
            }
            
            else
            {
                Console.WriteLine("La letra ingresada no está en el rango especificado.");
            }


        }


    }


}

