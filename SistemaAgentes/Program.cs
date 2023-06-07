// See https://aka.ms/new-console-template for more information
using SistemaAgentes.App;
using SistemaAgentes.Core.Interfaces;

Console.WriteLine("Sistema de Agentes");
Console.WriteLine("Ingrese A,B o C según la funcionalidad que requiera:");
string? r = "";
r = Console.ReadLine();
try
{
    IStrategy agente = AgentFactory.CreateAgent(r);
    Console.WriteLine("Ingrese la cantidad de números de un conjunto para los cuales desea calcular su media");
    int cant = Convert.ToInt32(Console.ReadLine());
    List<double> list = new List<double>();
    for (int i = 0; i < cant; i++)
    {
        Console.WriteLine("Ingrese número para la posición {0} del conjunto", i + 1);
        list.Add(Convert.ToDouble(Console.ReadLine()));
    }
    Console.WriteLine("Ingrese la cantidad de niveles de la escalera:");
    int steps = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("La media es: {0}", agente.GetMedia(list));
    Console.WriteLine(agente.GetStaircase(steps));
    Console.ReadLine();
}
catch (Exception)
{

    Console.WriteLine("Error, Opción inválida");
}

