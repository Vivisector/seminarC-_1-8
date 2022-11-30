Console.WriteLine("Введите трехзначное число для вывода последней его цифры:");
// полученное число перевести в цифру, разделить на 10, вычесть их исходного и получить остаток (3-ю цифру)
int num = Convert.ToInt32(Console.ReadLine());
int num2 = num/10;
Console.WriteLine(num-num2*10);
//Console.WriteLine(num % 2 == 0 ? "Четное" : "Не четное");


