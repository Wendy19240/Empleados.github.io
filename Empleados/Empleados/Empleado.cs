public class Empleado : IMostrarInformacion
{
    public string Nombre { get; set; }
    public double Salario { get; set; }

    public double CalcularSalarioAnual()
    {
        return Salario * 12;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine("Empleado: " + Nombre + ", Salario: " + Salario.ToString("F2") + ", Salario Anual: " + CalcularSalarioAnual().ToString("F2"));
    }
}
