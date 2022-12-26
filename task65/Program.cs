// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int M = 4; int N = 8;

int LineUp(int m, int n)
{
    if (n == 1) return 1;
    if (n == m) return m;
    Console.Write(LineUp(m, n - 1) + " ");
    return n;
}
Console.WriteLine(LineUp(M, N));