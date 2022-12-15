// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
const int LEN = 7; const int L = -100; const int R = 100;

int[] GetRandArr(int LEN, int L, int R){
    int[] arr = new int[LEN];
    Random randN = new Random();
    for (int i=0; i< LEN; i++){
        arr[i] = randN.Next(L, R);
    }
    return arr;
}

int[] mass = GetRandArr(LEN, L, R); // собрали массив из сл. чисел
Console.WriteLine($"Исходный массив: {string.Join(", ", mass)}"); //посмотрели

// считалка нечетных элементов
int GetCount(int[] arr){
int oddSum = 0;
    for (int i=0;i<arr.Length; i++){
        if (i%2!=0) oddSum+= arr[i];
    }
return oddSum;
}
Console.Write($"Сумма нечетных элементов составит {GetCount(mass)} шт."); //отчитались