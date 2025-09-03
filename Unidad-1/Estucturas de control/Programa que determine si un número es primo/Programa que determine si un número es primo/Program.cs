
int Numero;
bool NumeroPrimo = true;

Console.Write("Ingresa un numero: ");
Numero = int.Parse(Console.ReadLine());

if (Numero <= 1)
{
    NumeroPrimo = false;
}
else
{
    for (int i = 2; i <= Math.Sqrt(Numero); i++)
    {
        if (Numero % i == 0)
        {
            NumeroPrimo = false;
            break;
        }
    }
}
if (NumeroPrimo == true)
{
    Console.WriteLine("Es un numero primo");
}
else
{
    Console.WriteLine("No es un numero primo");
}
Console.ReadKey();
