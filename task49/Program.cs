// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
const int R = 5;
const int C = 5;
int[,] matr = new int[R,C];

int[,] FillMatr(int[,] matr)
{
    Random rand = new Random();
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for(int j=0; j< matr.GetLength(1); j++)
        {
            matr[i,j] = rand.Next(1,10);
        }
    }
return matr;
}

void PrintMatr(int[,] matr)
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for(int j=0; j< matr.GetLength(1); j++)
        {
            Console.Write(matr[i,j] + " ");// = rand.Next(1,51);
        }
    Console.WriteLine();
    }

}
int[,] RefillWithSquares(int[,] matr)
{
for (int i=0; i<matr.GetLength(0); i++)
    {
        for(int j=0; j< matr.GetLength(1); j++)
        {
           if ((i+1)%2==0 && (j+1)%2==0) matr[i,j] = matr[i,j]*matr[i,j];
        }
    }
return matr;
}

int[,] m = FillMatr(matr);
Console.WriteLine("Исходный массив:");
PrintMatr(matr);
int[,] m2 = RefillWithSquares(matr);
Console.WriteLine("Переработанный массив:");
PrintMatr(m2);