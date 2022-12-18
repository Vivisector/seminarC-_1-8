// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
const int LEN = 5;
const int L = 1;
const int R = 40;

int[] FillArr(int length, int L, int R){
    int[] arr = new int[length];
    Random rand = new Random();
        for (int i=0; i< length; i++){
        arr[i]=rand.Next(L, R);
        }
    return arr;
}
void ReadArr(int[] arr){
    Console.WriteLine($"Исходный массив:    {string.Join(", ", arr)}");
}
void reverse(int[] array){
    for (int k=array.Length-1; k>=0;k--){
        Console.Write($"{array[k]}, ");
    }
}

int[] matr = FillArr(LEN, L, R);
ReadArr(matr);
Console.Write($"Развернутый массив: ");
reverse(matr);
