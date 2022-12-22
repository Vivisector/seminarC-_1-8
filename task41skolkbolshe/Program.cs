// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. Ввод чисел останавливается при помощи ввода слова "stop"
Console.WriteLine("Введите числа, разделяя ввод клавишей пробел (для прекращения ввода напишите 'stop'):");

int Num = 0;
int cnt = 0;
string s = string.Empty;

do
{
    s = Console.ReadLine();
    if (s == "stop") break;
    Num = Convert.ToInt32(s);
    if (Num > 0) { cnt = cnt + 1; }
}
while (true);

if (cnt % 10 == 1 && cnt != 11) { Console.WriteLine($"Положительных чисел введено {cnt} штука."); }
else if ((cnt % 10 == 2 || cnt % 10 == 3 || cnt % 10 == 4) && (cnt != 12 && cnt != 13 && cnt != 14)) { Console.WriteLine($"Положительных чисел введено {cnt} штуки."); }
else { Console.WriteLine($"Положительных чисел введено {cnt} штук."); }
