// пробуем наисать программку перевода "инта" в двоичную систему
// 1. посчитать двоичную разрядность введенного числа деля на 2
// 2. по полученному колву разрядов создать массив
// 3. массив заполнить 1 и 0 по методике деления на два исходного числа
// 4. развернуть массив и вывести экран

Console.WriteLine("Введите целое число:");
int decima = Convert.ToInt32(Console.ReadLine());
int razryadof = CountRazryady(decima);
int CountRazryady(int n) //функция подсчета разрядности двоичного представления
{
    int cnt = 0;
    while (n > 0) {n = n / 2; cnt++;}
    return cnt;
}

int[] arr = new int[razryadof];
int i = 0;
    while (decima > 0){
        // Console.WriteLine(i);
            if (decima%2 !=0){
                arr[i] = 1;
                // Console.WriteLine(1);
            }else{
                arr[i] = 0;
                // Console.WriteLine(0);
            }
    decima = decima / 2;
    i++;
    }
Console.Write($"это же число в двоичном виде: ");
for (i=arr.Length-1; i>=0; i--) {Console.Write(arr[i]);}

/*
PrintArr(arr);

void PrintArr(int[] arr){
    for (int i=arr.Length-1; i>=0; i--){
Console.Write(arr[i]);
    }
}

*/