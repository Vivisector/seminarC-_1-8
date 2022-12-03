// See https://aka.ms/new-console-template for more information
Console.WriteLine("Придумайте число:");
int n0 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Придумано число {n0}");

// определяем колво разрядов деля на 10 до получения нуля
int i = 0;
int n1 = n0 / 10;
while (n1 > 0)
{
    n1 = n1 / 10;
    i++; // количество разрядов 
}
if (i < 2)
{
    Console.WriteLine("Третьей цифры в числе не существует!");
}
else
{
    n1 = n0; // еще раз выставляем начальное значения переменной
    // int ik = 0;
    for (int ik = 0; ik < i - 2; ik++)
    {
        n1 = n1 / 10;
    }
    int nFin = n1 % 10;
    Console.WriteLine($"Третья цифра в числе: {nFin}");
}
Console.WriteLine("Разрядов в числе: " + (i + 1));