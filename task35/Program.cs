/*
Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/
const int LEN = 123;
const int LEFTN = 0;
const int RIGHTN = 151;
int[] GetRandArr(int len, int leftN, int rightN)
{
    Random rand = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = rand.Next(leftN, rightN);
    }
    return arr;
}
int[] mass = GetRandArr(LEN, LEFTN, RIGHTN);

// счетчик условных элементов
void counter(int[] mass)
{
    int cnt = 0;
    for (int m = 0; m < mass.Length; m++)
    {
        // Console.Write(mass[m] + ", ");
        if (mass[m] > 9 && mass[m] < 100) {
            cnt = cnt + 1;
        }

    }
Console.Write($"Кол-во элементов, лежащих в диапазоне [10-99] равно {cnt}");   
}

Console.WriteLine($"Иcходный массив:\n{string.Join(", ", mass)}");
counter(mass);
// Console.Write($"Кол-во элементов, лежащих в диапазоне 10-99 равно: {counter(mass)}");