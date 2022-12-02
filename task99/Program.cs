// случайное число из отрезка и показать наибольшую цифру
int n0 = new Random().Next(10,99);
int n1 = n0 % 10;
int n2 = (n0 - n1)/10;
// Console.WriteLine(n2);
if (n2 > n1){
Console.WriteLine($"Большей цифрой в числе {n0} является цифра {n2}");
}
else
{
    Console.WriteLine($"Большей цифрой в числе {n0} является цифра {n1}");
}

