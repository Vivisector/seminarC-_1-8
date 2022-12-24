// Создается и показывается матрица

const int R = 5;
const int C = 3;
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

int[,] m = FillArr(R, C);
Console.WriteLine("\nВ исходной матрице:");
ShowArr(m);
// Console.WriteLine();
Counter(m);
void Counter(int [,] matr)
{
    int[] chisla = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
    int cnt = 0;
    for (int k = 0; k < chisla.Length; k++)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            if (matr[i,j]==chisla[k]){cnt++;}                            
        }
    if (cnt!=0) Console.Write($"{chisla[k]} встречается {cnt}{Shtuki(cnt)}, "); cnt=0;
    }
}

//определитель падежа 
string Shtuki(int count)
{
    string shtuk = string.Empty;
    if (count == 1 || (count > 4 && count < 22)) shtuk = " раз";
        else shtuk = " раза";
    
    return shtuk;
}