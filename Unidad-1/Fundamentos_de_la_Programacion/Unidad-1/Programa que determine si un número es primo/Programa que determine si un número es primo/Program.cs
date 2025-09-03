
int N;
bool NP = true;

Console.Write("Ingresa un número: ");
N = int.Parse(Console.ReadLine());

if (N <= 1)
{
    NP = false;
}
else
{
    for (int i = 2; i <= Math.Sqrt(N); i++)
    {
        if (N % i == 0)
        {
            NP = false;
            break;
        }
    }
}
if (NP == true)
{
    Console.WriteLine("Es un numero primo");
}
else
{
    Console.WriteLine("No es un numero primo");
}
Console.ReadKey();
