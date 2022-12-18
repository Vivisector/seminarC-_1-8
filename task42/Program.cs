// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
void PrintBinary(int n) //через рекурсию
{
    if (n <= 0) return;
    else PrintBinary(n / 2);
    Console.Write(n%2);
}
/*
// определитель количества разрядов в двоичке
int Counter(int n)
{
    int cnt = 0;
    while (n > 0) { n = n / 2; cnt = cnt + 1; }
    return cnt; // узнали кол-во разрядов = размерность будущего массива
}
int razryady = Counter(N);
int[] binarka = new int[razryady];

    for (int k = 0; k < razryady; k++)
    {
        if (N % 2 == 0) binarka[k] = 0;
        else binarka[k] = 1;
        N = N / 2;
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
reverse(binarka);
*/
Console.Write($"это же число в двоичном представлении: ");
PrintBinary(N);
// Console.Write($"{string.Join("", binarka)}");