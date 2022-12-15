// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int len = new Random().Next(5, 10);

int[] GetRandArray(int len, int left, int right)
{
    int[] arr = new int[len];
    Random rand = new Random();
    for (int i = 0; i < len; i++)
    {
        arr[i] = rand.Next(left, right);
    }
    return arr;
}
const int LEFTN = 100; int RIGHTN = 1000;
int[] mArr = GetRandArray(len, LEFTN, RIGHTN);
Console.Write($"Исходный массив: {string.Join(", ", mArr)}");
int cntEven = 0; //счетчик четных элементов
    for (int k = 0; k < len; k++)
    {
        if (mArr[k] % 2 == 0) cntEven = cntEven + 1;
    }
Console.Write($"\nЧетных элементов в массиве: {cntEven}");
