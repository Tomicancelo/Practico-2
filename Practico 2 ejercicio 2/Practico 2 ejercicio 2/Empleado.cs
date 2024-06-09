using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico_2_ejercicio_2
{
    class Empleado
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string cargo { get; set; }
        public int salario { get; set; }
        public int empredaId { get; set; }

        public Empleado (int id, string nombre, string cargo, int salario, int empresaId)
        {
            this.id = id;
            this.nombre = nombre;
            this.cargo = cargo;
            this.salario = salario;
            this.empredaId = empredaId;

        }

        public void getDatosEmpleado()
        {
            Console.WriteLine("Empleado: " + nombre + "\nId: " + id + "\nCargo: " + cargo + "\nSalariio: " + salario + "\n Pertenece a la empresa: " + empredaId );
        }


    }
}
