// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

const int R=2;
const int C=2;
const int H=2;
int[,,] FillArr(int r, int c, int h)
{
    Random rand = new Random();
    int[,,] matr = new int[r,c,h];
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++)
        {
            for (int k=0; k<matr.GetLength(2); k++)
            {
                matr[i,j,k]= rand.Next(0,10);
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

int[,,] m= FillArr(R,C,H);
Console.WriteLine($"\nТрехмерная матрица размером {R} на {C} на {H} (в скобках указаны индексы элементов):");
ShowArr(m);
Console.WriteLine();