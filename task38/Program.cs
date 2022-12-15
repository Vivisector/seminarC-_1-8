// Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементами массива.
const int LEN = 10;
const int L = 5;
const int R = 105;
int[] GetRandArr(int LEN, int L, int R)
{
    int[] arr = new int[LEN];
    Random randN = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = randN.Next(L, R);
    }
    return arr;
}
int[] mass = GetRandArr(LEN, L, R);
Console.WriteLine($"Исходный массив: {string.Join(", ", mass)}");

// считаем макс/мин
(int, int, int posMin, int posMax) GetMaxMin(int[] mass)
{
    int mmax = mass[0]; int mmin = mass[0];
    int posMin = 0; int posMax = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] < mmin) {mmin = mass[i]; posMin = i;}
        if (mass[i] > mmax) {mmax = mass[i]; posMax = i;}
    }

    return (mmax, mmin, posMin, posMax);
}
(int mmax, int mmin, int posMin, int posMax) = GetMaxMin(mass);
Console.WriteLine($"Разница между максимальным {mmax} ({posMax+1}-й элемент) и минимальным {mmin} ({posMin+1}-й) элементами массива равна {mmax-mmin}");