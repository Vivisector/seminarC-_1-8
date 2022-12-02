// генерируем сл. трехзначное число, и превращаем в двухзначное
int n1 = new Random().Next(100,1000);
int n01 = n1/100*10;
// Console.WriteLine(n01);
int n02 = n1 % 10;
Console.WriteLine("Сгенерировано " + n1);
Console.WriteLine($"Превратилось в {n01+n02}");

