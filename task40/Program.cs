// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
//  Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("Введите три числа через пробел, завершите ввод клавишей Enter:");
string[] valA = Console.ReadLine().Split();
int a = Convert.ToInt32(valA[0]);
int b = Convert.ToInt32(valA[1]);
int c = Convert.ToInt32(valA[2]);

// проверяем сумму по каждому сочетанию
bool aB = a < (b + c);
bool bB = b < (c + a);
bool cB = c < (b + a);
if (aB && bB && cB) Console.WriteLine("Треугольник с такими сторонами может существовать");
else Console.Write("Такой треугольник невозможен");
