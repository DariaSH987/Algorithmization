Console.WriteLine("Введите внутренний радиус");
double r1 = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Введите внешний радиус");
double r2 = Convert.ToInt32(Console.ReadLine());
double s = Math.PI * (Math.Pow(r2, 2) - Math.Pow(r1, 2));
Console.WriteLine($"Площадь кольца: {s}");