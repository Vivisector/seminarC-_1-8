// Задать массив из 12 элементов, случайные числа из [-9 - 9]. Найти сумму отриц и пложит элементов
// квадратные пустые скобки в инициализации переменной говорит, что у нас будет возвращаться на одно число, а набор чисел

// вариант метода с кортежем
int[] arr = new int[12];
int[] FillArr(int[] a)
{
    Random rand = new Random();
    for (int i = 0; i < a.Length; i++)
        arr[i] = rand.Next(-9, 10);
    return a;
}

void ReadArr(int[] a)
{for (int i = 0; i < a.Length; i++) Console.Write(arr[i] + " ");}

// сумматор плюсов и минусов
(int, int) Summator(int[] a)
{
    int min = 0;
    int max = 0;
    for (int i = 0; i < a.Length; i++)
        if (arr[i] > 0) max = max + arr[i];
         else min = min - arr[i];
    return (max, min);
}

int[] m = FillArr(arr);
Console.WriteLine("Сгенерированный массив:");
ReadArr(arr);
Console.WriteLine($"\nСумма положительных и отрицательных элементов равна {Summator(m).Item1} положительных и {Summator(m).Item2} отрицательных значений");

/* старый вариант
int[] arr = new int[12];
int mPlus = 0;
int mMinus = 0;

void FillArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9,9);
    }

}
void ReadArr(int[] arr){
for (int k=0; k<arr.Length; k++){
    Console.Write(arr[k] + ", ");
}
}
FillArr(arr);
Console.WriteLine("В полученном массиве:");
ReadArr(arr);
Console.WriteLine();
Console.WriteLine("сумма плюсов и минусов следующая:");
// подсчет 
for (int i= 0; i<arr.Length; i++){
    if (arr[i]>0) {
        mPlus = mPlus + arr[i];
    }else{
        mMinus = mMinus + arr[i];
    }
}
//подсчет минусов
Console.WriteLine("+: " + mPlus);
Console.WriteLine("-: " + mMinus);


// Console.WriteLine("Hello, World!");
*/