
double Radio, Area;

Console.Write("Introduzca el radio del circulo: ");
Radio = double.Parse(Console.ReadLine());

Area = Math.PI * (Math.Pow(Radio,2));

Console.WriteLine("El area del circulo es: " +  Area.ToString("F2"));