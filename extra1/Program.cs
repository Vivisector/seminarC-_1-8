int[] arr = {-2,8,14,-34,-9,7,92,-35,7,4,16,-8,5};
// Console.WriteLine(Convert.ToString(arr[0]));

int sum = 0;
string a = " ";
int cnt = 0;
for (int i = 0; i<arr.Length; i++){
    if (arr[i]>0) {
        sum = sum+ arr[i];
        a = a + Convert.ToString(arr[i]) + ", ";
        cnt++;
    }
}
Console.WriteLine("=====================");
Console.WriteLine($"В представленном массиве:");
mPrint(arr);
Console.WriteLine($"содержится {cnt} положительных чисел:{a}");
Console.WriteLine($"a их сумма составляет {sum}");
Console.WriteLine("=====================");
// Console.WriteLine("Hello, World!");

// mPrint(arr);
void mPrint (int[] arr){
    for (int k=0; k<arr.Length; k++){
        Console.Write(arr[k] + ", ");
    }
Console.WriteLine();
}