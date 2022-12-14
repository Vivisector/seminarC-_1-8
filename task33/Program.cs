// Создать массив и определить, присутствует ли в нем заданное число
int A = 4;
int B = -3;
int[] arr = new int[7];

void FillArr(int[] arr){
    for (int i=0; i<arr.Length; i++){
        arr[i] = new Random().Next(-5,5);
    }
}

void ReadArr(int[] arr){
    for (int i=0; i<arr.Length;i++){
        Console.Write(arr[i] + ", ");    

    }
}
FillArr(arr);
Console.Write("Полученный массив:\n");    
ReadArr(arr);
Console.WriteLine();
// проверка наличия заданного числа внутри массива
bool mIn = false;
for (int i=0;i<arr.Length; i++){
    if (arr[i]==A){
        Console.WriteLine($"Число {A} входит в массив на позиции {i}\n");
        mIn = true;
    }
    if (arr[i]==B){
        Console.WriteLine($"Число {B} входит в массив на позиции {i}\n");
        mIn = true;
    }
}
if (mIn == false) Console.WriteLine(" Ни {B} ни {A} не входят в массив.");;
// Console.WriteLine("Hello, World!");
