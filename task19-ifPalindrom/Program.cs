// проверяем пятизначное число, является ли оно палиндромом.
// 
Console.WriteLine("Введите пятизначное число");
int s = Convert.ToInt32(Console.ReadLine());
// проверка валидности введенных данных
if (s < 10000 || s > 99999)
{
    Console.WriteLine("неверное число разрядов, повторите ввод:");
    s = Convert.ToInt32(Console.ReadLine());
}
// Console.WriteLine($"первая цифра {s/10000}");
// Console.WriteLine($"пятая цифра {s%10}");
// Console.WriteLine($"вторая цифра {s/1000%10}");
// Console.WriteLine($"четвертая цифра {s%100/10}");

if (s / 10000 != s % 10)
{
    Console.WriteLine($"Число не палиндром");
}
else if (s / 1000 % 10 != s % 100 / 10)
{
    Console.WriteLine($"Число не палиндром");
}
else
{
    Console.WriteLine($"число {s} - палиндром");
}
