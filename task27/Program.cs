// Программа принимает на вход число и выдаёт сумму цифр этого числа


int ReadNum(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
int N = ReadNum("Введите число: ");
int counter = razryadCounter(N);

// измеритель количества цифр
int razryadCounter(int n)
{
    int cnt = 0;
    while (n > 0)
    {
        n = n / 10;
        cnt++;
    }
    return cnt;
}

// сумматор цифр
int summator(int N, int counter)
{
    int result = 0;
    int restFig = N;
    int lastFig = N;
    for (int i = 1; i <= counter; i++)
    {
        lastFig = restFig % 10; // правая цифра
        restFig = restFig / 10; // без правой цифры
        result = result + lastFig;
    }
    return result;
}

Console.Write("Сумма цифр данного числа равна " + summator(N, counter));