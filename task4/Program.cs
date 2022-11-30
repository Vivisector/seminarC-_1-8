// программа принимает на вход (раздельно) три числа и показывает максимальное
Console.WriteLine("введите первое число");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int a2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите третье число");
int a3 = Convert.ToInt32(Console.ReadLine());
int max = a1;
if (a2>max){
    max = a2;
}
if (a3>max) {
    max = a3;
}

Console.WriteLine(max);
