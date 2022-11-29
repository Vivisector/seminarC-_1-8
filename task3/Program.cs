// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите номер дня недели (1-7)");

// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

string sNum = Console.ReadLine();
if (sNum == "1") 
{ 
    Console.WriteLine("Это понедельник!"); 
}
elseif (sNum == "2"); 
{
    Console.WriteLine("Это вторник!");
}
else
{
    Console.WriteLine("Такого дня нет!");
}