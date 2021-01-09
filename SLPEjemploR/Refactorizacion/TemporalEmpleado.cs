using System;
using System.Collections.Generic;
using System.Text;

namespace SLPEjemploR.Refactorizacion
{
    public class TemporalEmpleado : Empleado
    {
        public TemporalEmpleado()
        { }

        public TemporalEmpleado(int id, string nombre) : base(id, nombre)
        { }

        public override decimal CalcularBono(decimal salario)
        {
            return (salario + 500);
        }

        public override decimal GetMinimoSalario()
        {
            return  300;
        }
    }
}
