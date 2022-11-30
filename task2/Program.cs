// See https://aka.ms/new-console-template for more information
Console.WriteLine("введите первое число:");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число:");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(n2 > n1 ? "Второе число больше" : "Первое число больше");