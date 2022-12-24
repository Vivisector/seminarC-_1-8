// Задача 53:
// Программа меняет местами первую и послед. строку массива.
const int R = 4;
const int C = 4;
int[,] FillArr(int r, int c)
{
    Random rand = new Random();
    int[,] matr = new int[r, c];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(0, 5);
        }
    }
    return matr;
}

void ShowArr(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] FillExchange(int[,] matr)
{
int tmp=0;
        for (int j = 0; j < matr.GetLength(1); j++) //
        {            
            tmp = matr[matr.GetLength(0)-1, j]; 
            matr[matr.GetLength(0)-1, j] = matr[0,j];
            matr[0,j] = tmp;
        }
    return matr;
}

int[,] m = FillArr(R, C);
Console.WriteLine("Исходный массив:");
ShowArr(m);
Console.WriteLine("Первая строка стала последней:");
int [,] mEx = FillExchange(m);
ShowArr(mEx);