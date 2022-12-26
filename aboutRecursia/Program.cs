Console.WriteLine("Введите число до 16, иначе будет переполнение. Машина посчитает все факториалы в ряду от 1 до введенного числа.");
int N = Convert.ToInt32(Console.ReadLine());

int Factor(int n)
{
 if (n==0) return 1;
 return n*Factor(n-1);   
}
for (int i=1; i<N+1; i++) Console.WriteLine($"Факториал от {i} равен {Factor(i)}");