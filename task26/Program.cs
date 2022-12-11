// принимаем число и выдаем кол-во цифр
// 456 - 3
// 78 - 2
// 89126 - 5
int ReadNum(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}
int A = ReadNum("Введите число:");
//подчсчет колва цифр
int FigCounter(int A)
{
    int cnt = 0;
    while (A > 0)
    {
        A = A / 10;
        cnt++;
    }
    return cnt;
}

Console.Write($"Число состоит из {FigCounter(A)} цифр");
