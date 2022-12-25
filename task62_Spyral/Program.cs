// Задача 62. Заполните спирально массив 4 на 4.

const int D=4;
// расставим индексы ячеек по порядку возрастания номеров
// 0,0 0,1 0,2 0,3
// 1,0 1,1 1,2 1,3
// 2,0 2,1 2,2 2,3
// 3,0 3,1 3,2 3,3

// В спиральном виде последовательность заполнения ячеек такая: 
// 0,0 0,1 0,2 0,3 | 1,3 2,3 3,3 | 3,2 3,1 3,0 | 2,0 1,0 | 1,1 1,2 | 2,2 2,1


int[,] FillSpyral(int d)
{
    int[,] matr = new int[d,d];
    int cnt=1;
    int i; int j;
// i=0;
for (j = 0; j<4;j++) {matr[0,j] = cnt;cnt++;}

// j=3
for (i = 1; i<4;i++) {matr[i,3] = cnt;cnt++;}

// i=3
for (j = 2; j>=0;j--) {matr[3,j] = cnt;cnt++;}

// j=0
for (i = 2; i>0;i--) {matr[i,0] = cnt;cnt++;}

// i=1
for (j = 1; j<3;j++) {matr[1,j] = cnt;cnt++;}

// i=2
for (j = 2; j>0;j--) {matr[2,j] = cnt;cnt++;}

return matr;
}
void ShowArr(int[,] matr)
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++)
        Console.Write(matr[i,j] + " "); Console.WriteLine();
    }
}
string GetList(int n)
{
    string s = string.Empty;
    for (int k=1; k<=n*n; k++)
    {
s=s+k + " ";
    }
return s;
}
int[,] m= FillSpyral(D);
Console.WriteLine($"\nСпиралевидная матрица из [ {GetList(D)}] элементов выглядит так:");
ShowArr(m);
Console.WriteLine();