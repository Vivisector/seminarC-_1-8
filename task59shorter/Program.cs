int[,] matr = new int[6, 6];
/////////////////////////////////////////////
int[,] FillArr(int[,] m)
{
    Random rand = new Random();
    for (int i = 0; i < m.GetLength(0); i++)
    {
        for (int j = 0; j < m.GetLength(1); j++)
        {
            m[i, j] = rand.Next(0, 100);
        }
    }
    return m;
}
/////////////////////////////////////////////
void ReadMatr(int[,] m)
{
    for (int i = 0; i < m.GetLength(0); i++)
    {
        for (int j = 0; j < m.GetLength(1); j++)
        {
            Console.Write(m[i, j] + " "); ;
        }
        Console.WriteLine();
    }
}
/////////////////////////////////////////////
(int, int) GetMin(int[,] m)
{
    int min = m[0, 0]; int posMin1 = 0; int posMin2 = 0;

    for (int i = 0; i < m.GetLength(0); i++)
    {
        for (int j = 0; j < m.GetLength(1); j++)
        {
            if (m[i, j] < min)
            {
                min = m[i, j];
                posMin1 = i; posMin2 = j;
            }
        }
    }
    return (posMin1, posMin2);
}
/////////////////////////////////////////////
string Rearrange(int[,] m, int p1, int p2)
{
    int[,] rearr = new int[m.GetLength(0) - 1, m.GetLength(1) - 1];
    string s = string.Empty;
    for (int i = 0; i < m.GetLength(0); i++)
    {
        if (i != p1)
        {
            for (int j = 0; j < m.GetLength(1); j++)
            {
                if (j != p2)
                {
                    s = s + m[i, j] + " ";
                }
            }
            s = s + "\n";
            // string[] ss = s.Split(); s = string.Empty; Console.WriteLine("!" + ss.Length);
            // for (int k=0; k<ss.Length-1; k++){rearr[i,k] = Convert.ToInt32(ss[k]);}
        }
    }
    return s;
}
/////////////////////////////////////////////
int[,] m = FillArr(matr);
Console.WriteLine("исходная матрица:");
ReadMatr(m);
Console.WriteLine($"минимальный элемент ({m[GetMin(m).Item1, GetMin(m).Item2]}) находится в {GetMin(m).Item1 + 1} строке, в {GetMin(m).Item2 + 1} колонке");
Console.WriteLine("После удаления этого ряда и колонки матрица принимает вид:");
int pos1 = GetMin(m).Item1; int pos2 = GetMin(m).Item2;
string m2 = Rearrange(m, pos1, pos2);
Console.WriteLine(m2);
