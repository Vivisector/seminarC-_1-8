// Задача 57: Частотный словарь элементов двумерного массива - сколько раз встречается элемент входных данных.

const int R = 5;
const int C = 5;

int[,] FillArr(int r, int c)
{
    Random rand = new Random();
    int[,] matr = new int[r, c];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++) matr[i, j] = rand.Next(0, 10);
    }
    return matr;
}

void ReadArr(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++) Console.Write(matr[i, j] + " ");
        Console.WriteLine();
    }
}

string[] GetAllFigures(int[,] matr) // собираем все числа матрицы в одномерный массив/строку
{
    int[] all = new int[matr.GetLength(0) * matr.GetLength(1)]; //задали переменную для хранения всех чисел матрицы
    int k = 0; //счетчик
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            all[k] = matr[i, j];
            k++;
        }
    }
    //тут сортируем массив по возрастанию
    for (int i = 0; i < all.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < all.Length; j++)
        {
            if (all[j] < all[minPosition]) minPosition = j;
        }
        int temp = all[i];
        all[i] = all[minPosition];
        all[minPosition] = temp;
    }
    // конвертируем в строку и удаляем повторяющиеся числа
    string s = Convert.ToString(all[0]) + ",";
    for (int i = 1; i < all.Length; i++)
    {
        if (all[i] != all[i - 1]) s = s + Convert.ToString(all[i] + ",");
    }
    string[] allCleared = s.Split(",");
    return allCleared;
}

int CountVxod(int[,] matr, int N) // считаем количество вхождений данного числа
{
    int count = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++) if (matr[i, j] == N) count++;
    }
    return count;
}

//определитель падежа 
string Shtuki(int count)
{
    string shtuk = string.Empty;
    if (count == 1 || (count > 4 && count < 22)) shtuk = " раз";
        else shtuk = " раза";
    
    return shtuk;
}

int[,] m = FillArr(R, C);
Console.WriteLine("\nИсходная матрица:");
ReadArr(m);
string[] mAll = GetAllFigures(m); //собрали, отсортировали и удалили дубли
// Console.WriteLine($"{string.Join(",", mAll)}"); //контроль получаемого списка чисел
Console.WriteLine($"встречается чисел: {mAll.Length - 1} шт.");
for (int i = 0; i < mAll.Length - 1; i++)
{
    Console.WriteLine($"{mAll[i]} встречается {CountVxod(m, Convert.ToInt32(mAll[i]))} {Shtuki(CountVxod(m, Convert.ToInt32(mAll[i])))}");

}
