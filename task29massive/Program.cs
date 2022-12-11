// массив из 8 элементов и выводит их на экран

// прием данных от пользователя (метод)
int[] arr = new int[8];
for (int i = 0; i <= 7; i++)
{
    Console.Write("Введите " + (i + 1) + "-е число из 8: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Собран следующий массив: ");
PrintArr(arr); // вывод массива на экран

void PrintArr(int[] arr)
{
    for (int k = 0; k < arr.Length; k++)
    {
        if (k == 0)
        {
            Console.Write("[" + arr[k] + ", ");
        }
        else if (k == arr.Length - 1)
        {
            Console.Write(arr[k] + "]");
        }
        else
        {
            Console.Write(arr[k] + ", ");
        }
    }
}