// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
const int R = 3;
const int C = 5;
int[,] FillArr(int r, int c)
{
    Random rand = new Random();
    int[,] matr = new int[r,c];
    for (int i=0; i<matr.GetLength(0); i++){
        for (int j=0; j<matr.GetLength(1); j++)
        {
            matr[i,j]= rand.Next(0,10);
        }
    }return matr;
}

void ShowArr(int[,] matr)
{
    for (int i=0; i<matr.GetLength(0); i++){
        for (int j=0; j<matr.GetLength(1); j++)
        {
            Console.Write(matr[i,j] + " ");
        }Console.WriteLine();
    }
}

int[,] TransponedArr(int [,] matr)
{
    int[,] matrEx = new int [matr.GetLength(1), matr.GetLength(0)];
    for (int i=0; i<matr.GetLength(0); i++){
        for (int j=0; j<matr.GetLength(1); j++) matrEx[j,i] = matr[i,j];
    }return matrEx;
}

int[,] m = FillArr(R,C);
int[,] mTr = TransponedArr(m);
Console.WriteLine("\nИсходная матрица:");
ShowArr(m);
Console.WriteLine();
Console.WriteLine("Транспонированная матрица:");
ShowArr(mTr);
Console.WriteLine();