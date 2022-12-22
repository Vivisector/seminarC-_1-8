// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

const int R=4;
const int C=5;
//заполнение массива
int[,] FillArr(int r, int c)
{
    int[,] matr = new int[r,c];
    Random rand = new Random();
    for (int i=0; i<matr.GetLength(0); i++)
    {for (int j=0; j<matr.GetLength(1); j++) matr[i,j]=rand.Next(0,10);}
return matr;
}

void ShowArr(int [,] matr) //демонстрация массива
{
    for (int i=0; i<matr.GetLength(0); i++)
    {for (int j=0; j<matr.GetLength(1); j++) {Console.Write(matr[i,j] + " ");}
    Console.WriteLine();
    }
}
void GetSredneeArifmet(int [,] matr)
{
    double S = 0;
    for (int i=0; i<matr.GetLength(1); i++)// просмотр столбца
    {
        S=0;
        for (int j=0; j<matr.GetLength(0); j++) 
        {
            S = S + matr[j,i];
        }
        Console.Write(Math.Round(S/matr.GetLength(0), 1) + "; ");
    }
// return;
}

int[,] matrix = FillArr(R, C);
Console.WriteLine("\nСгенерирован массив:");
ShowArr(matrix);
Console.WriteLine("среднее арифметическое по каждому столбцу следующее:");
GetSredneeArifmet(matrix);
Console.WriteLine();
Console.WriteLine();
