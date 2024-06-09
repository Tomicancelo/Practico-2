using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico_2_ejercicio_2
{
    class ControlEmpresasEmpleados
    {
        public List<Empresa> listaEmpresas;
        public List<Empleado> listaEmpleados;

        public ControlEmpresasEmpleados()
        {
            listaEmpresas = new List<Empresa>();
            listaEmpleados = new List<Empleado>();

            listaEmpresas.Add(new Empresa(1, "IAlpha"));
            listaEmpresas.Add(new Empresa(2, "Udelar"));
            listaEmpresas.Add(new Empresa(3, "SpaceZ"));

            listaEmpleados.Add(new Empleado(1, "Gonzalo", "CEO", 1, 3800));
            listaEmpleados.Add(new Empleado(2, "JuanC", "Desarrollador", 1, 2000));
            listaEmpleados.Add(new Empleado(3, "JuanR", "Desarrollador", 1, 2000));
            listaEmpleados.Add(new Empleado(4, "Daniel", "Desarrollador", 1, 2000));
            listaEmpleados.Add(new Empleado(5, "GonzaloT", "CEO", 2, 2000));
            listaEmpleados.Add(new Empleado(6, "Leandro", "CEO", 2, 3000));
            listaEmpleados.Add(new Empleado(7, "Gonzalo", "CEO", 3, 3000));
            listaEmpleados.Add(new Empleado(8, "Leandro", "CEO", 3, 3000));

        }
        //________________________________________Getters_____________________________________

        public void getCeo(string _Cargo)
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados
                                              where empleado.cargo == _Cargo
                                              select empleado;
            foreach (Empleado elemento in empleados)
            {
                elemento.getDatosEmpleado();
            }

        }

        public void getEmpleadosOrdenados()
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados
                                              orderby empleado.nombre
                                              select empleado;
            foreach (Empleado elemento in empleados)
            {
                elemento.getDatosEmpleado();
            }
        }

        public void getEmpleadosOrdenadosSegun()
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados
                                              orderby empleado.salario
                                              select empleado;
            foreach (Empleado elemento in empleados)
            {
                elemento.getDatosEmpleado();
            }
        }

        public void getEmpleadosEmpresa(int _Empresa)
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados
                                              join empresa in listaEmpresas on empleado.empredaId
                                              equals empresa.id
                                              where empresa.id == _Empresa
                                              select empleado;
            foreach (Empleado elemento in empleados)
            {
                elemento.getDatosEmpleado();
            }
        }

        //Metodos Particulares
        public void promedioSalario()
        {
            var consulta = from e in listaEmpleados
                           group e by e.empredaId into g
                           select new { empresa = g.Key, promedioSalario = g.Average(e => e.salario) };

            foreach (var resultado in consulta)
            {
                switch (resultado.empresa)
                {
                    case 1:
                        Console.WriteLine($"Empresa IAlpha - Promedio de salario : {resultado.promedioSalario}");
                        break;
                    case 2:
                        Console.WriteLine($"Empresa Udelar - Promedio de salario : {resultado.promedioSalario}");
                        break;
                    case 3:
                        Console.WriteLine($"Empresa SpaceZ - Promedio de salario : {resultado.promedioSalario}");
                        break;


                }
            }
        }

    }
}
