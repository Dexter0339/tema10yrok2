Console.WriteLine("Введите значение катета: ");
double a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение гипотенузы: ");
double c = int.Parse(Console.ReadLine());
double b = Math.Sqrt((c * c) - (a * a));
Console.WriteLine("Значение второго катета: " + b);
