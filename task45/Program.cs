// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] ar1 = {1,23,3,56,77};
int[] ar2 =new int [ar1.Length];
//копирование в новый массив
for (int i=0; i<ar1.Length; i++)
{
    ar2[i]=ar1[i];
}
Console.WriteLine($"Исходный массив ar1: {string.Join(", ", ar1)}");
Console.WriteLine($"Скопированный масcив ar2: {string.Join(", ", ar2)}");