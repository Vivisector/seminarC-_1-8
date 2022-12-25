// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

const int DIM=2;
int[,,] FillArr(int d)
{
    Random rand = new Random();
    int[,,] matr = new int[d,d,d];
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++)
        {
            for (int k=0; k<matr.GetLength(2); k++)
            {
                matr[i,j,k]= rand.Next(0,100);
            }
        }
    }return matr;
}
void ShowArr(int[,,] matr)
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++)
        {
            for (int k=0; k<matr.GetLength(2); k++)
            {Console.Write($"{matr[i,j,k]}({i},{j},{k}) ");}Console.WriteLine();
        }
    }
}

int[,,] m= FillArr(DIM);
Console.WriteLine($"\nТрехмерная матрица размером {DIM} на {DIM} на {DIM} (в скобках указаны индексы элементов):");
ShowArr(m);
Console.WriteLine();