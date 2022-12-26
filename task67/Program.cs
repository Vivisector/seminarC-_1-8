// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int number = 45;
int Summator(int n)
{
    if (n==0) return 0;
    return n%10 + Summator(n/10);

}
Console.WriteLine(Summator(number));