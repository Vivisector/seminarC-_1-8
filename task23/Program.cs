Console.WriteLine("Придумайте число");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Составляющие числа (в скобках указан куб каждого числа):");
for (int i = 1; i <= N; i++)
{
    if (i==N){
        Console.Write($"{i}({Math.Pow(i, 3)})."); //обработка последней цифры: с точкой в конце
    }
        else{
        Console.Write($"{i}({Math.Pow(i, 3)}), ");
    }
}

