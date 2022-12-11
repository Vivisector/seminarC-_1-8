// цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B (проверяется, что число В не меньше единицы)
int ReadNum(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}
int A = ReadNum("Введите первое число:");
int B = ReadNum("Введите второе число:");
if (B < 1) {
    Console.WriteLine("Второе число должно быть не меньше единицы!");
B = ReadNum("Введите второе число еще раз:");
}

int MultiPlyer(int a, int b)
{
    int result = a;
    for (int i = 1; i < b; i++)
    {
        result = result * a;
    }
    return result;
}

Console.WriteLine($"Число {A} в степени {B} будет равно {MultiPlyer(A, B)}");