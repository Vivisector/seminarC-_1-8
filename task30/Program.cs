// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
int[] arr = new int[8];

void FillArr(int[] arr) //заполнитель массива
{
    for (int k = 0; k < arr.Length; k++)
    {
        arr[k] = new Random().Next(0, 2);
    }
}

void PrintArr(int[] arr) //распечатка на экране
{
    for (int i = 0; i < arr.Length; i++)
    {
    if(i==0)
           {Console.Write($"[{arr[i]}, ");
            }else if (i== arr.Length-1){
            Console.Write($"{arr[i]}]");
            }else{
         Console.Write($"{arr[i]}, ");
            }
    }
}
FillArr(arr);
PrintArr(arr);