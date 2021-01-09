using System;
using System.Collections.Generic;
using System.Text;

namespace SLPEjemploR.Refactorizacion
{
    public class PermanenteEmpleado : Empleado
    {
        public PermanenteEmpleado()
        { }

        public PermanenteEmpleado(int id, string nombre) : base(id, nombre)
        { }

        public override decimal CalcularBono(decimal salario)
        {
            return (salario + 700);
        }

        public override decimal GetMinimoSalario()
        {
            return 500;
        }
    }
}
