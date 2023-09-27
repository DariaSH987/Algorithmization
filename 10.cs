Console.WriteLine("Введите длину окружности");

double r = Convert.ToDouble(Console.ReadLine());
double s = (Math.PI * 2) * (Math.Pow(r, 2));
Console.WriteLine($"Площадь вписанного круга {s}");