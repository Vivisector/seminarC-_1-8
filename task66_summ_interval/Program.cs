// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int M = 1; int N = 15;
// int M = 4; int N = 8;

int SumInterval(int m, int n)
{
    if (m == n) return m;
    else return n + SumInterval(m, (n - 1));
}
Console.WriteLine(SumInterval(M, N));