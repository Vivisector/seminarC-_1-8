// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// Akk(m,n) = n+1 if m==0
// Akk(m-1,1) if m>0, n==0
// Akk(m-1, Akk(m,n-1)) if m>0, n>0

// int M = 2; int N = 3;
// int M = 2; int N = 1;
int Akk(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0) { return Akk(m - 1, 1); }
    else return Akk(m - 1, Akk(m, n - 1)); 

    // return m;
}
Console.WriteLine($"\nЗначения функции при малых входных значениях:");
for (int i=0; i<4; i++)
{
    for (int j=0; j<4; j++){
    Console.WriteLine($"Acc({i},{j}) = {Akk(i, j)}");
    }
}