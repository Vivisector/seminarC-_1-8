﻿// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int N = 9;

int GetLine(int n)
{
    if (n == 1) return n;
   Console.Write(GetLine(n - 1) + " ");
    return n;
}

Console.WriteLine(GetLine(N));