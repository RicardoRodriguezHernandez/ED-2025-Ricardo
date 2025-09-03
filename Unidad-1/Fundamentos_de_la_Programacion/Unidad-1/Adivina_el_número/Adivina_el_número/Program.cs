int N;
Random random = new Random();
bool continuar = true;
while (continuar)
{
    int NM = random.Next(1, 10);
    Console.WriteLine("==== ADIVINA EL NUMERO ====");
    Console.Write("Introduzca un numero del 1 al 10: ");
    N = int.Parse(Console.ReadLine());

    if (N > 10)
    {
        Console.WriteLine("Por favor poner un numero del 1 al 10");
    }
    else if (N == NM)
    {
        Console.WriteLine("=== FELICIDADES ===");
        Console.WriteLine("Lograste adivinar el numero :)");
        Console.WriteLine("Era el numero: " + NM);
    }
    else
    {
        Console.WriteLine("=== ERRROR ===");
        Console.WriteLine("Ese nos es el numero :(");
        Console.WriteLine("Era el numero: " + NM);
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
