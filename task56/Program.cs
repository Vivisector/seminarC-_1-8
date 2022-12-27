// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

const int R = 4;
const int C = 5;
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

int GetMinRow(int[,] matr)
{
    int tmpSum = 0;
    
    // получение отправной суммы для сравнения  
    for (int j = 0; j < matr.GetLength(1); j++) tmpSum = tmpSum + matr[0, j];

    int minTmp = tmpSum;
    int minRowPosition = 0;
    
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 1; j < matr.GetLength(1); j++) tmpSum = tmpSum + matr[i, j];
        Console.WriteLine($"Сумма по строке {i}: {tmpSum}");
        if (tmpSum < minTmp)
        {
            minTmp = tmpSum;
            minRowPosition = i;
        }tmpSum = 0;
    }

    return minRowPosition;
}


int[,] m = FillArr(R, C);
Console.WriteLine("\nИсходная матрица:");
ShowArr(m);
Console.WriteLine($"Строка с номером {GetMinRow(m)} имеет наименьшую сумму");