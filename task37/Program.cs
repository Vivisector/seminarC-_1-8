/* task37 - 2022_12_14
найти произведение пар чисел в одномерном массиве. Парой считать первый и последний элементы, второй и предпоследний и т.д. Результат записать в новом массиве
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

// задаем псевдослучайный размер массива
int L = new Random().Next(4,8);
int[] arr = new int[L];
// int LPair = (L%2==0 ? L/2 : L/2+1);
int LPair = L/2+L%2; // этот короткий вариант записи подсмотрел на семинаре
int[] arrPair = new int[LPair];

void FillArr(int[] arr, int L){
    Random rand = new Random();
    for (int i=0; i<L;i++){
        arr[i] = rand.Next(1,10);
    }
}

void ReadArr(int[] arr, int L){
    for (int i=0; i<L;i++){
        Console.Write(arr[i] + ",");
    }
}

FillArr(arr, L);
Console.Write("Исходный массив:\n");
ReadArr(arr, L);
Console.Write("\nЕго длина: " + L);
// собираем второй массив с произведениями пар
for (int m=0; m<LPair; m++){
arrPair[m] = arr[m]*arr[L-m-1];
}
if (L%2!=0) arrPair[LPair-1] = arr[LPair-1]; // для нечетного колва элементов переписываем срединныйэлемент из первого массива
Console.WriteLine("\nПопарное произведение крайних элементов:");
ReadArr(arrPair, LPair);
