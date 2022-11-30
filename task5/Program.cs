// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число (и программа напишет все числа от минус 'ваше число' до плюс 'ваше число'):");
int num = Convert.ToInt32(Console.ReadLine());
for (int i=-num; i<=num; i++){
Console.Write(i + " ");
}

