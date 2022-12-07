// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// f-la: sqrt{(x2-x1) ^{2} + (y2-y1) ^{2} + (z2-z1) ^{2}} $ 

/////////// точка C /////////////////////
Console.WriteLine("Координата x первой точки:");
int ax = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Координата y первой точки:");
int ay = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Координата z первой точки:");
int az = Convert.ToInt32(Console.ReadLine());

/////////// точка B /////////////////////
Console.WriteLine("Координата x второй точки:");
int bx = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Координата y второй точки:");
int by = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Координата z второй точки:");
int bz = Convert.ToInt32(Console.ReadLine());

double dist = Math.Sqrt(Math.Pow((ax-bx), 2) + Math.Pow((ay-by), 2) + Math.Pow((az-bz), 2));
Console.WriteLine(dist);