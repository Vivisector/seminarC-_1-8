// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.

// Создается и показывается матрица

const int R = 4;
const int C = 4;
int[,] FillArr(int r, int c)
{
    Random rand = new Random();
    int[,] matr = new int[r, c];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            matr[i, j] = rand.Next(0, 10);
    }
    return matr;
}
void ShowArr(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            Console.Write(matr[i, j] + " "); Console.WriteLine();
    }
}
void SortingMatr(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int[] arrtmp = new int[matr.GetLength(1)];
        for (int j = 0; j < matr.GetLength(1); j++)
        {arrtmp[j] = matr[i, j]; //заполняем временый массив по текущей строке
        } 
        
        // теперь строку сортируем
        for (int k = 0; k < arrtmp.Length; k++)
        {
            int minPosition = k;    
            for (int l = k+1; l < arrtmp.Length; l++)
            { if (arrtmp[l] < arrtmp[minPosition]) minPosition = l; }
            int tmp = arrtmp[k];
            arrtmp[k] = arrtmp[minPosition];
            arrtmp[minPosition] = tmp;
        }
        // теперь заполняем строку матрицы отсортированной строкой
        for (int m = 0; m < matr.GetLength(1); m++)
        {matr[i,m] = arrtmp[m];}
    }
    // return matr;
}

int[,] m = FillArr(R, C);
Console.WriteLine("\nИсходная матрица:");
ShowArr(m);
Console.WriteLine();
Console.WriteLine("Матрица с упорядоченными строками:");
SortingMatr(m);
ShowArr(m);
