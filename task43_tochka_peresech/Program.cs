// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//проверим, какие генерируеются игреки по каждой из формул
Console.WriteLine("Введите коэффициенты k1, b1 и  k2, b2 в уравнения двух прямых:");
Console.WriteLine("Введите k1:");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b1:");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2:");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2:");
int b2 = Convert.ToInt32(Console.ReadLine());

// k1 = 5; b1 = 2; b2 = 4; k2 = 9;

double y = 0;
double m = b2 - b1;
double n = k1 - k2;
double x = m/n;
// x = (b2 - b1) / (k1 - k2); //получается ноль почему-то
y = k1 * x + b1;

Console.WriteLine($"Точка пересечения двух полученных прямых имеет координаты Х:{Math.Round(x, 2)}, по Y:{Math.Round(y, 2)}");