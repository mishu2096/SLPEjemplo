using System;
using System.Collections.Generic;
using System.Text;

namespace SLPEjemploR.Refactorizacion
{
    public class ContratoEmpleado : IEmpleado
    {
        public int ID { get; set; }

        public string Nombre { get; set; }
        public ContratoEmpleado()
        { }

        public ContratoEmpleado(int id, string nombre)
        {
            this.ID = id;
            this.Nombre = nombre;
        }

        public decimal GetMinimoSalario()
        {
            return 300;
        }

        public override string ToString()
        {
            return string.Format("ID : {0} Nombre : {1}", this.ID, this.Nombre);
        }
    }
}
