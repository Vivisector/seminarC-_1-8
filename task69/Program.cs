// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int A = 2; int B = 3;
int MyPow(int a, int b)
{
if (b==0) return 1;
return a * MyPow(a, b-1);
}

Console.WriteLine(MyPow(A, B));