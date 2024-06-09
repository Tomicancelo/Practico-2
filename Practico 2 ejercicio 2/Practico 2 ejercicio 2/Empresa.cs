using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico_2_ejercicio_2
{
    class Empresa
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public Empresa (int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
        public void getDatosEmpresa()
        {
            Console.WriteLine("Empresa {0} con Id{1}", nombre, id);
        }
    }
}
