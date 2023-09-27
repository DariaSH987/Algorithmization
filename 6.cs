Console.WriteLine("Введите ×1");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите у1");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите ×2");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите у2");
int y2 = Convert.ToInt32(Console.ReadLine());

double l = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2));
Console.WriteLine($"Расстояние между точками: {l}");