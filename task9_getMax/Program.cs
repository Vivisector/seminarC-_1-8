// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
//ищем макс значение из списка чисел

int[] arr = { 1, 21, 19, 41, 15, 658, 17, 84, 29, 12 };
void PrintArr(int[] arr){
    for (int i=0; i<arr.Length; i++){
        while(i<arr.Length-1){
        Console.Write($"{arr[i]}, ");
        i++;  
        }
        Console.Write($"{arr[i]} -- ");
    }
    
}
// int M = arr[0];
// if (arr[1]>M) M = arr[1];
// if (arr[2]>M) M = arr[2];
// int max1 = Max(arr[0], arr[1], arr[2]);
// int max2 = Max(arr[3], arr[4], arr[5]);
// int max3 = Max(arr[6], arr[7], arr[8]);

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int M = Max(
    Max(arr[0], arr[1], arr[2]),
    Max(arr[3], arr[4], arr[5]),
    Max(arr[6], arr[7], arr[8])
    );
PrintArr(arr);
Console.WriteLine($"максимальное число из представленного ряда - {M}");

