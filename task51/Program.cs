// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

const int ROWS = 5;
const int COLS = 8;
int[,] matr = new int[ROWS, COLS];

// создаем массив для хранения списка диагональных чисел
int M = Math.Min(ROWS, COLS); //узнали меньшую размерность
int[] listTmp = new int[M]; // создали массив

int[,] FillMatrix(int[,] matr)
{
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(0, 10);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");

        }
        Console.WriteLine();
    }
    return;
}

int[,] m = FillMatrix(matr); //заполнили
PrintMatrix(m); // распечатали
int mSum = 0;
string mS = string.Empty; // строка для вывода суммированных значений

int[] mlist = GetDiagonalNum(matr, listTmp);
Console.WriteLine($"Сумма диагональных элементов ({string.Join(", ", mlist)}) равна {GetDiagonalSum(matr, mSum)}");

// считаем сумму диагональных элементов
int GetDiagonalSum(int[,] matr, int mSumma)
{
    // int mSumma = 0;
if (matr.GetLength(0)>matr.GetLength(1))
    for (int i = 0; i < matr.GetLength(0); i++) {mSumma = mSumma + matr[i, i];}
    return mSumma;
}

// метод перечисления диагональных элементов
int[] GetDiagonalNum(int[,] matr, int[] list)
{

    for (int k = 0; k < list.Length; k++)
    {
        list[k] = matr[k, k]; // заполнение списка диагональных элементов
    }
    return list;
}