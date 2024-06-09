using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona("Juan", 25,"Lima"));
            personas.Add(new Persona("Maria", 30,"Bogota"));
            personas.Add(new Persona("Tomas", 27, "Maldonado"));
            personas.Add(new Persona("Messi", 26, "Barcelona"));
            personas.Add(new Persona("Suarez", 29, "Miami"));
            personas.Add(new Persona("Pedro", 35, "Madrid"));
            personas.Add(new Persona("Cavani", 28, "Paris"));
            personas.Add(new Persona("Ana", 20, "Lima"));
            personas.Add(new Persona("Jose", 40, "Buenos Aires"));
            personas.Add(new Persona("Maluma", 45, "Bogota"));
            personas.Add(new Persona("Camilo", 50, "Bogota"));


            personas.Where(x => x.edad > 30 && x.ciudad == "Bogota").ToList().ForEach(x => Console.WriteLine(x.nombre));

            Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////////");

            personas.Where(x => x.edad > 25 && x.edad < 35).ToList().OrderBy(x => x.edad).ToList().ForEach(x => Console.WriteLine(x.nombre + " " + x.edad ));

        }
    }
}
