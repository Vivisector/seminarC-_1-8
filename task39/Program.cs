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
void reverse(int[] array){
    int tmp = 0;
    for (int i=0; i< array.Length/2; i++)
    {
        tmp = array[i];
        array[i] = array[array.Length-1-i];
        array[array.Length-1-i] = tmp;
    }

}

int[] matr = FillArr(LEN, L, R);
Console.WriteLine($"Исходный массив:    [{string.Join(", ", matr)}]");

reverse(matr);
Console.Write($"Развернутый массив: [{string.Join(", ", matr)}]");
