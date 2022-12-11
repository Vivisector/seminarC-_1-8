// Задача 24. Программа принимает на вход числоа (А) и выдает сумму числел от 1 до А
// 7 > 28
// 4 > 10
// 8 > 36

// метод получения данных от пользователя
int ReadInt(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}
int A = ReadInt("Введите число:");

Console.WriteLine(A);
// метод суммирования от 1 до A
int summaToNum(int N)
{
    int sum = 0;
    for (int i = 1; i <= N; i++)
    {
        // sum = sum + i;
        sum += i;
    }
    return sum;
}
Console.Write($"Сумма чисел от 1 до {A} составит {summaToNum(A)}");