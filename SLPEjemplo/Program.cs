using System;

namespace SLPEjemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empJohn = new PermanenteEmpleado(1, "John");
            Empleado empJason = new TemporalEmpleado(2, "Jason");
            Empleado empMike = new ContratoEmpleado(3, "Mike");


            Console.WriteLine(string.Format("Empleado {0} Bono: {1}",
                empJohn.ToString(),
                empJohn.CalcularBono(100).ToString()));
            Console.WriteLine(string.Format("Empleado {0} Bono: {1}",
              empJason.ToString(),
              empJason.CalcularBono(50).ToString()));
            Console.WriteLine(string.Format("Empleado {0} Bono: {1}",
              empMike.ToString(),
              empMike.CalcularBono(30).ToString()));

            Console.ReadLine();
        }
    }
}
