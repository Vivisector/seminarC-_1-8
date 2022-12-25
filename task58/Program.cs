// Создается и показывается матрица

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

int[,] MultArr(int[,] matr1, int[,] matr2, int r, int c)
{
    int[,] matrMult = new int[r,c];
for (int i=0; i<matrMult.GetLength(0); i++)
{
for (int j=0; j<matrMult.GetLength(1); j++)
{
matrMult[i,j]=matr1[i,j]*matr2[i,j];
}
}return matrMult;
}

void ShowArr(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            Console.Write(matr[i, j] + " "); Console.WriteLine();
    }
}

int[,] m1 = FillArr(R, C);
Console.WriteLine("\nПервая матрица:");
ShowArr(m1);
int[,] m2 = FillArr(R, C);
Console.WriteLine("\nВторая матрица:");
ShowArr(m2);
Console.WriteLine("\nМатрица произведений:");
int[,] m3 = MultArr(m1, m2, R,C);
ShowArr(m3);