// Из трёхзначного числа показывается вторая цифра

Console.WriteLine("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = (n / 10) % 10;
// int n2 = n1 % 10;
Console.WriteLine($"Средняя цифра из числа {n} будет {n1}");


