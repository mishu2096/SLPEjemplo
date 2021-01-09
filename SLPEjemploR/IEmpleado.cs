namespace SLPEjemploR
{
    public interface IEmpleado
    {
        int ID { get; set; }
        string Nombre { get; set; }
        decimal GetMinimoSalario();
    }
}