using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico_2
{
    class Persona
    {
        public string nombre;
        public int edad;
        public string ciudad;

        public Persona(string nombre, int edad, string ciudad)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.ciudad = ciudad;
        }
    }
}
