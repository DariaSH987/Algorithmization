Console.WriteLine("Введите первое число");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int y = Convert.ToInt32(Console.ReadLine());

int summa = x + y;
int diff = x - y;
int multip = x * y;
int quotient = x / y;

double q = Convert.ToDouble(x) / Convert.ToDouble(y);
Console.WriteLine($"Сумма x + y={summa}");
Console.WriteLine($"Разность x - y={diff}");
Console.WriteLine($"Произведение x * y={multip}");
Console.WriteLine($"Частное x / y= {quotient}");
