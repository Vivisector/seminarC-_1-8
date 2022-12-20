// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

const int M = 5;
const int N = 8;
int[,] matr = new int[M, N];

int[,] FillMatrix(int rows, int cols, int[,] matr) //, int L = 0, int R = 10)
{
    for(int i=0; i< matr.GetLength(0); i++)
    {
        for (int j = 0; j< matr.GetLength(1); j++)
        {
            matr[i,j]=i+j;
        }
    }
return matr;
}
// метод печати двумерного массива
void PrintMatrix(int[,] matr)
{
for (int i = 0; i<matr.GetLength(0); i++)
{
    for (int j=0; j< matr.GetLength(1); j++)
    {
        Console.Write(matr[i,j] + " ");
    }
    Console.WriteLine();
}
}
int [,] m = FillMatrix(M, N, matr);
PrintMatrix(m);
// int rowsCount = ReadInt("Введите число строк");
// int colsCount = ReadInt("Введите число колонок");
// int[,] matrix = FetRandomMatrix(rowsCount, colsCount);
