Console.WriteLine("Введите радиус окружности");

double r = Convert.ToDouble(Console.ReadLine());
double s = Math.PI * (Math.Pow(r, 2));
double с = (Math.PI * 2) * r;
Console.WriteLine($"Площадь круга {s}");
Console.WriteLine($"Длину окружности {с}");