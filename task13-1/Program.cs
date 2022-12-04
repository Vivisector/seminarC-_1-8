Console.WriteLine("Придумайте число:");
int n0 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Это число {n0}");

while (n0 < 100) {
    Console.WriteLine("Оно содержит меньше трех разрядов, введите другое число:");
    n0 = Convert.ToInt32(Console.ReadLine());
}

int i = 0;
int n1 = n0;
while (n1 > 999)
{
    n1 = n1 / 10;
    i++;
}

    Console.WriteLine($"Третья цифра {n1 % 10}");
