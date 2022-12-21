// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
int r = new Random().Next(4, 6); //колво строк
int c = new Random().Next(4, 6); // колво столбцов

//вызовы
int[,] matrix = FillArr(r, c);
Console.WriteLine("Имеется массив:");
ReadArr(matrix); // для контроля
Console.WriteLine("Введите через пробел номер строки и номер столбца:");
string[] mline = Console.ReadLine().Split();
int rManual = Convert.ToInt32(mline[0]);
int cManual = Convert.ToInt32(mline[1]);
int Num = 0; //сюда будем класть содержимое искомого элемента
// Num = GetElement(matrix, rManual, cManual);
int GetElement(int[,] matrix, int rM, int cM)
    {
    int N = matrix[rManual-1, cManual-1];
    return N;
    }
if (rManual>matrix.GetLength(0) || cManual>matrix.GetLength(1))
Console.WriteLine("Такого элемента не существует((");
else Console.WriteLine($"Элемент в строке {rManual} и столбце {cManual} равен {GetElement(matrix, rManual, cManual)}");
// Console.WriteLine($"{rManual}, {cManual}");



//генератор массива
int[,] FillArr(int r, int c)
{
    int[,] matr = new int[r, c];
    Random rand = new Random();
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
            matr[i, j] = rand.Next(-5, 5);
    }
    return matr;
}

void ReadArr(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + " ");
    Console.WriteLine();
    }
    return;
}
