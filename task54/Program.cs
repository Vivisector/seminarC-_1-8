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
        for (int j = 0; j < matr.GetLength(1); j++){
        int minPosition = j;    
            for (int k=j+1; k<matr.GetLength(1); k++)
            {if (matr[i,k]<matr[i,minPosition]) minPosition = k;}
                int temp = matr[i,j];
                matr[i,j] = matr[i,minPosition];
                matr[i,minPosition] = temp;
        }
    } 
}

int[,] m = FillArr(R, C);
Console.WriteLine("\nИсходная матрица:");
ShowArr(m);
Console.WriteLine("Матрица с упорядоченными строками:");
SortingMatr(m);
ShowArr(m);
