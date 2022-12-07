// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
// для измерения номера четверти нужно одновременно мерить знаки координат
// I ++
// II -+
// III --
// IV +-

Console.WriteLine("Введите коорд точки по Х");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коорд точки по Y");
int y = Convert.ToInt32(Console.ReadLine());
if (x == 0 || y == 0) Console.WriteLine("Точка лежит на границе четвертей, введите верные данные");

if (x > 0 && y > 0) Console.WriteLine("Точка в I четверти");
if (x < 0 && y > 0) Console.WriteLine("Точка в II четверти");
if (x < 0 && y < 0) Console.WriteLine("Точка в III четверти");
if (x > 0 && y < 0) Console.WriteLine("Точка в IV четверти");