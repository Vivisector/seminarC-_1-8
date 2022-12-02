// проверка квадрата двух чисел
Console.WriteLine("Введите первое число:");
int n1 = Convert.ToInt32(Console.ReadLine());
// int a = Convert.ToInt32(sa);
Console.WriteLine("Введите второе число:");
int n2 = Convert.ToInt32(Console.ReadLine());

if (n2 > n1)
{
    if (n1 * n1 == n2 || n2 * n2 == n1)
    {
        Console.WriteLine("Второе число является квадратом первого");
    }
    else
    {
        Console.WriteLine("Второе число не квадрат первого!");
    }
}
else if (n1 > n2)
{
    if (n1 * n1 == n2 || n2 * n2 == n1)
    {
        Console.WriteLine("Первое число является квадратом второго");
    }
    else
    {
        Console.WriteLine("Первре число не квадрат второго!");
    }
}
