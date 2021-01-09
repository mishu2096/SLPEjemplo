using System;
using System.Collections.Generic;
using SLPEjemploR.Refactorizacion;

namespace SLPEjemploR
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> empleados = new List<Empleado>();
            empleados.Add(new PermanenteEmpleado(1, "John"));
            empleados.Add(new TemporalEmpleado(2, "Jason"));
            //Un Comment to see the error
            //employees.Add(new ContractEmployee(3, "Mike"));
            foreach (var empleado in empleados)
            {
                Console.WriteLine(string.Format("Empleado {0} Bono: {1} MinSalario: {2}",
                empleado.ToString(),
                empleado.CalcularBono(100000).ToString(),
                empleado.GetMinimoSalario().ToString()));
            }

            Console.WriteLine();

            List<IEmpleado> empleadosTodos = new List<IEmpleado>();

            empleadosTodos.Add(new PermanenteEmpleado(1, "John"));
            empleadosTodos.Add(new TemporalEmpleado(2, "Jason"));
            empleadosTodos.Add(new ContratoEmpleado(3, "Mike"));

            foreach (var empleado in empleadosTodos)
            {
                Console.WriteLine(string.Format("Empleado {0}  MinSalario: {1}",
                empleado.ToString(),
                empleado.GetMinimoSalario().ToString()));
            }
            Console.ReadLine();
        }
    }
}
