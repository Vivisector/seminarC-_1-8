// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число для вывода квадратов всех чисел");
int n = Convert.ToInt32(Console.ReadLine());
int a = 0;
// int s = 0;
Console.WriteLine("Квадраты входящих чисел:");
for (int i=1; i<=n; i++){
a = i;
a = a*a;
    if (i==n){
    Console.Write($"{i}^2 = {a}.");
    }
    else{
    Console.Write($"{i}^2 = {a}, ");
    }
}
// Console.WriteLine(s);