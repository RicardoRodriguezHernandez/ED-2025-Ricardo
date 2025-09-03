
double GradosCelsius, GradosFahrenheit;

Console.Write("introduzca los grados celsius que desea convertir: ");
GradosCelsius = double.Parse(Console.ReadLine());

GradosFahrenheit = (GradosCelsius * 9 / 5) + 32;

Console.WriteLine("Los Grados Fahrenheit: " + GradosFahrenheit);