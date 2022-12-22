// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//собираем из дробной и целой частей

// объявили переменные
double m = 0;
int rand = 0;
double Num = 0;

// метод генерации случайного числа в заданом диапазоне
double GetRealNums(double Num, double m, int rand)
{
m = new Random().NextDouble();
rand = new Random().Next(-10,10);
    if(rand < 0)Num = rand-m;
else Num = rand+m;
return (Math.Round(Num, 1));
}

const int M = 4;
const int N = 4;
double[,] FillArr(int M, int N)
{
    double [,] matrix = new double[M, N];
for (int i=0; i<M; i++)
{
    for (int j=0; j<N; j++)
    {
        matrix[i,j] = GetRealNums(Num, m, rand);
    }
}
return matrix;
}

void PrintMatrix(double [,] matr)
{
for (int i=0; i<matr.GetLength(0); i++)
{
    for (int j=0; j < matr.GetLength(1); j++)
    {
        Console.Write(matr[i,j] + " ");
    }
Console.WriteLine();
}
}

double[,] matr = FillArr(M, N);
PrintMatrix(matr);