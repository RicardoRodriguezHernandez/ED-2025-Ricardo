int Numero;
Random random = new Random();
bool continuar = true;
while (continuar)
{
    int NumeroMaquina = random.Next(1, 10);
    Console.WriteLine("==== ADIVINA EL NUMERO ====");
    Console.Write("Introduzca un numero del 1 al 10: ");
    Numero = int.Parse(Console.ReadLine());

    if (Numero > 10)
    {
        Console.WriteLine("Por favor poner un numero del 1 al 10");
    }
    else if (Numero == NumeroMaquina)
    {
        Console.WriteLine("=== FELICIDADES ===");
        Console.WriteLine("Lograste adivinar el numero :)");
        Console.WriteLine("Era el numero: " + NumeroMaquina);
    }
    else
    {
        Console.WriteLine("=== ERRROR ===");
        Console.WriteLine("Ese nos es el numero :(");
        Console.WriteLine("Era el numero: " + NumeroMaquina);
    }

    Console.Write("\n¿Quieres jugar de nuevo? (s/n): ");
    string respuesta = Console.ReadLine().ToLower();

    if (respuesta != "s")
    {
        continuar = false;
        Console.WriteLine("=== Gracias por participar ===");
    }
}
Console.WriteLine();
Console.WriteLine("=== ADIOS ===");
Console.ReadKey();  
