// AB = Корень: (xb-xa)2 + (yb-ya)2
// int a = 25, b = 5;
Console.WriteLine("Введите координаты точки А (x, y) через пробел:");
// надо делать проверку на отсутствие литералов (вроде так называется)
string[] valA = Console.ReadLine().Split();
int xa = Convert.ToInt32(valA[0]);
int ya = Convert.ToInt32(valA[1]);
Console.WriteLine("Введите координаты точки B (x, y) через пробел:");
string[] valB = Console.ReadLine().Split();
int xb = Convert.ToInt32(valB[0]);
int yb = Convert.ToInt32(valB[1]);

Console.WriteLine($"Расстояние между точками A и B (на плоскости) согласно формуле составит: {Math.Sqrt((xb-xa)*(xb-xa) + (yb-ya)*(yb-ya))}");