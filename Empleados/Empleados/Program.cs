class Program
{
    static void Main()
    {
        Empleado empleado = new Empleado { Nombre = "Juan", Salario = 3000 };
        Gerente gerente = new Gerente { Nombre = "María", Salario = 5000, Departamento = "Ventas" };

        empleado.MostrarInformacion();
        gerente.MostrarInformacion();
    }
}