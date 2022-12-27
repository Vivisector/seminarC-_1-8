// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int number = 5;

string LineBack(int n)
{
if (n >= 1) return $"{n} " + LineBack(n-1);
else return string.Empty;
}

Console.WriteLine(LineBack(number));