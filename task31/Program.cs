// Задать массив из 12 элементов, случайные числа из [-9 - 9]. Найти сумму отриц и пложит элементов
// квадратные пустые скобки в инициализации переменной говорит, что у нас будет возвращаться на одно число, а набор чисел
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
