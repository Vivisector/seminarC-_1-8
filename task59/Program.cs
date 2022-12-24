// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

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

(int, int) GetMin(int[,] matr)
{
    int Min = matr[0, 0]; //задали исходный минимум
    // int[] minRC = { 0, 0 }; // 
    int minR = 0; //искомые адреса строки и столбца, которые будем удалять
    int minC = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            if (matr[i, j] < Min)
            {
                Min = matr[i, j];
                minR = i; minC = j;
            }
    }
    return (minR, minC);
}

string MatrResection(int[,] matrResec, int rR, int cR) //формируем новую матрицу
{
    int[,] mResection = new int[matrResec.GetLength(0), matrResec.GetLength(1)]; //размерность на единицу меньше, тк удаляем и ряд и столбец
    string s = string.Empty;
    for (int i = 0; i < matrResec.GetLength(0); i++)
    {
        if (i != rR)
        {
            for (int j = 0; j < matrResec.GetLength(0); j++){
            if (j != cR) s = s + Convert.ToInt32(matrResec[i, j])+" ";}
        }
        s = s + "\n";
    }
    return s;// matrResec;
}

int[,] m = FillArr(R, C);
Console.WriteLine("\nИсходная матрица:");
ShowArr(m);
Console.WriteLine();
Console.WriteLine($"Наименьший элемент: {m[GetMin(m).Item1, GetMin(m).Item2]}, расположен в строке {GetMin(m).Item1 + 1}, столбце {GetMin(m).Item2 + 1}");
Console.WriteLine("После удаления соотвествующего ряда и столбца матрица принимает вид:");
int rResec = GetMin(m).Item1; int cResec = GetMin(m).Item2;
Console.WriteLine(MatrResection(m, rResec, cResec));
// ShowArr(MatrResection(m, rResec, cResec));