// Заполнить двумерный массив случайными числами
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int [,] GetRangeMatrix(int rows, int cols, int L = 0, int R = 10)
{
 Random rand = new Random();
    int[,] matr = new int[rows, cols];
    for(int i=0; i< matr.GetLength(0); i++)
    {
        for (int j = 0; j< matr.GetLength(1); j++)
        {
            matr[i,j]=rand.Next(L,R);
        }
    }
return matr;
}
// метод печати двумерного массива
void PrintMatrix(int [,] matr)
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

int rowsCount = ReadInt("Введите число строк");
int colsCount = ReadInt("Введите число колонок");
int[,] matrix = GetRangeMatrix(rowsCount, colsCount);
Console.WriteLine();
PrintMatrix(matrix);
