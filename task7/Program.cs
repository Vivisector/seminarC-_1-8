// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число для проверки его четности:");
int num = Convert.ToInt32(Console.ReadLine());
// if (num % == 0) {
    // Console.WriteLine("число четное!");
    Console.WriteLine(num % 2 == 0 ? "Четное" : "Не четное");
// }


