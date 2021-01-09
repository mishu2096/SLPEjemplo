namespace SLPEjemploR
{
    public abstract class Empleado : IEmpleado, IEmpleadoBono
    {
        public int ID { get; set; }

        public string Nombre { get; set; }

        public Empleado()
        { }

        public Empleado(int id, string nombre)
        {
            this.ID = id;
            this.Nombre = nombre;

        }

        public abstract decimal CalcularBono(decimal salario);

        public override string ToString()
        {
            return string.Format("ID : {0} Nombre : {1}", this.ID, this.Nombre);
        }

        public abstract decimal GetMinimoSalario();
    }
}