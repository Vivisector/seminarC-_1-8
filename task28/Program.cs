// считается произведение от 1 до введенного числа
int N = ReadNum("Введите число:");

int ReadNum(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int GetMulti(int n)
{
    int Mult = 1;
    for (int i = 1; i <= n; i++)
        Mult = Mult * i;
    return Mult;
}

Console.WriteLine($"Произведение чисел от 1 до {N} будет равно {GetMulti(N)} ");
