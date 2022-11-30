// выходе показывает все чётные числа от 1 до введенного N
Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());
int n = 0;
string sN = "";
for (int i = 2; i <= N; i = i + 2)
{
    sN = sN + " " + Convert.ToString(i);
Console.WriteLine(sN);