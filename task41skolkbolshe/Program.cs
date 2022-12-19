// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. Ввод чисел останавливается при помощи ввода слова "stop"
Console.WriteLine("Введите числа, разделяя ввод клавишей пробел (для прекращения ввода напишите 'stop'):");

            string chisla = Console.ReadLine();

            string[] chArr = chisla.Split();
            int cnt = 0;
            for (int i = 0; i < chArr.Length - 1; i++)
            {
                try 
                {if (Convert.ToInt32(chArr[i]) > 0) cnt = cnt + 1;}
                catch(IOException e)
                {
                    break;
                }
                
            }
            Console.WriteLine($"Положительных чисел введено {cnt} штук");

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
