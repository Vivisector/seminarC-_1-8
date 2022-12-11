// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).
Console.WriteLine("Введи номер координатной четверти [1-2-3-4]");
int N = Convert.ToInt32(Console.ReadLine());
while (N <1 || N >4 ){
    Console.WriteLine("недопустимое значение, введите число от 1 до 4:");
    N = Convert.ToInt32(Console.ReadLine());    
}
// switch (N){
//     case N==1: Console.WriteLine($"допустимые координаты точки: x > 0, y > 0");
// break;

if (N == 1) Console.WriteLine($"допустимые координаты точки: x > 0, y > 0");
if (N == 2) Console.WriteLine($"допустимые координаты точки: x < 0, y > 0");
if (N == 3) Console.WriteLine($"допустимые координаты точки: x < 0, y < 0");
if (N == 4) Console.WriteLine($"допустимые координаты точки: x > 0, y < 0");
