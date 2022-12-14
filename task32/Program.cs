// Програма замены элементов массива: положительные элементы заменить на соответсвующие отрицательные и наоборот
// [-4,-8,8,2] -> [4,8,-,8,-2]
int Len = new Random().Next(5, 10);
int[] arr = new int[Len];
void FillArr(int[] arr, int Len)
{

    for (int i = 0; i < Len; i++)
    {
        arr[i] = new Random().Next(-9, 9);
    }
}
void ReadArr(int[] arr, int Len)
{
    for (int k = 0; k < Len; k++)
    {
        Console.Write(arr[k] + ", ");
    }
}
FillArr(arr, Len);
Console.WriteLine("Исходный массив:");
ReadArr(arr, Len);
Console.WriteLine();
// смена знаков
for (int i=0; i<Len;i++){
    arr[i]=-arr[i];
}
Console.WriteLine("Измененный массив:");
ReadArr(arr, Len);
// Console.WriteLine("Hello, World!");
