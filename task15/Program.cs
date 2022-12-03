Console.WriteLine("Введите цифру, обоначающую день недели:");
int day = Convert.ToInt32(Console.ReadLine());
// проверка введенной цифры на валидность
if (day < 1 || day > 7){
    Console.WriteLine("Такого дня не существует. Введите еще раз:");
    day = Convert.ToInt32(Console.ReadLine());
}
if (day == 6 || day == 7){
    Console.WriteLine("Это выходной день");
} else{
    Console.WriteLine("Рабочий день");
}
