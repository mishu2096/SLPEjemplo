using System;
using System.Collections.Generic;
using System.Text;

namespace SLPEjemplo
{
    public abstract class Empleado    {
        public int ID { get; set; }
        public string Nombre { get; set; }

        public Empleado()
        {
        }

        public Empleado(int id, string nombre)
        {
            this.ID = id; this.Nombre = nombre;
        }

        public abstract decimal CalcularBono(decimal salary);

        public override string ToString()
        {
            return string.Format("ID : {0} Name : {1}", this.ID, this.Nombre);
        }
    }

    public class PermanenteEmpleado : Empleado
    {
        public PermanenteEmpleado()
        { }

        public PermanenteEmpleado(int id, string nombre) : base(id, nombre)
        { }
        public override decimal CalcularBono(decimal salario)
        {
            return salario + 700;
        }
    }

    public class TemporalEmpleado : Empleado
    {
        public TemporalEmpleado()
        { }

        public TemporalEmpleado(int id, string nombre) : base(id, nombre)
        { }
        public override decimal CalcularBono(decimal salario)
        {
            return salario + 500;
        }
    }

    public class ContratoEmpleado : Empleado
    {
        public ContratoEmpleado()
        { }

        public ContratoEmpleado(int id, string nombre) : base(id, nombre)
        { }
        public override decimal CalcularBono(decimal salario)
        {
            return salario + 400;
        }
    }
}
