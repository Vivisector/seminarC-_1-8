// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите номер дня недели (1-7)");

// Задача №3. Выдает название дня недели по заданному номеру

string sNum = Console.ReadLine();
if (sNum == "1")
    Console.WriteLine("Это понедельник");
else if (sNum == "2")
    Console.WriteLine("Это вторник");
else if (sNum == "3")
    Console.WriteLine("Среда");
else if (sNum == "4")
    Console.WriteLine("Четверг");
else if (sNum == "5")
    Console.WriteLine("Пятница");
else if (sNum == "6")
    Console.WriteLine("Суббота");
else if (sNum == "7")
    Console.WriteLine("Воскресенье");
else
    Console.WriteLine("Такого дня нет!");