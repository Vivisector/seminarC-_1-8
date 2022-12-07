// доп.задание: разворот массива (не используя память под дополнительный массив)

// сначала генератор массива (чтобы руками не набирать)
int len = new Random().Next(5, 8); // задаем диапазон генерации длины массива
int tmp = 0; // переменная для временного хранения элементов массива
int[] arr = new int[len]; // задали новый массив

void GenArr(int[] arr, int len) // генератор массива
{
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(1, 20);
    }
}
GenArr(arr, len); //собрали новый массив и демонстририруем
Console.WriteLine("Исходный массив:");
PrintArr(arr); // показали на экране

// теперь разворачиваем
for (int i = 0; i < len / 2; i++) //перебираем только половину элементов, не включая срединный (если он есть [в случае нечетного колва элементов])
{
    tmp = arr[i];
    arr[i] = arr[len - i - 1];
    arr[len - i - 1] = tmp;
    // Console.Write(arr[i]);
}
// */
void PrintArr(int[] arr)
{
    for (int k = 0; k < len; k++)
    {
            if (k==0){Console.Write($"[{arr[k]}, ");}
            else if (k==len-1){Console.Write($"{arr[k]}]");}
            else{Console.Write($"{arr[k]}, ");}
        // Console.Write($"{arr[k]}, ");
    }
}
Console.WriteLine("\nПеревернутый массив:");
PrintArr(arr); //показали на экране

