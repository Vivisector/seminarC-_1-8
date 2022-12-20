// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. Ввод чисел останавливается при помощи ввода слова "stop"
Console.WriteLine("Введите числа, разделяя ввод клавишей пробел (для прекращения ввода напишите 'stop'):");

string chisla = Console.ReadLine();

string[] chArr = chisla.Split();
int cnt = 0;
for (int i = 0; i < chArr.Length - 1; i++)
{
    try
    { if (Convert.ToInt32(chArr[i]) > 0) cnt = cnt + 1; }
    catch (IOException e)
    {
        break;
    }
}
// 1 - штука
// 2,3,4 - штуки
// 5-20 штук
if (cnt % 10 == 1 && cnt !=11 ) {Console.WriteLine($"Положительных чисел введено {cnt} штука.");}
else if ((cnt % 10 == 2 || cnt % 10 == 3 || cnt % 10 == 4) && (cnt !=12 && cnt !=13 && cnt !=14)) { Console.WriteLine($"Положительных чисел введено {cnt} штуки."); }
else {Console.WriteLine($"Положительных чисел введено {cnt} штук.");}


// int Num = 0;
// int i = 0;
// string s = string.Empty; // = Convert.ToInt32(Console.ReadLine());
// s = Console.ReadLine();
// while (s != "stop")
// {

// try {Num = Convert.ToInt32(Console.ReadLine());}
//  catch(IOException e){break;}
//     if (Num > 0) {i = i + 1;}
//     Console.WriteLine("счетчик " + i);
//     s = s = Console.ReadLine();
// }
// // int ay = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"введено {i} положительных чисел");
