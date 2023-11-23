public class Gerente : Empleado, IMostrarInformacion
{
    public string Departamento { get; set; }

    public void MostrarInformacion()
    {
        Console.WriteLine("Gerente: " + Nombre + ", Salario: " + Salario.ToString("F2") + ", Salario Anual: " + CalcularSalarioAnual().ToString("F2") + ", Departamento: " + Departamento);
    }
}