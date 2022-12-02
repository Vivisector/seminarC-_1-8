// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());
if(n1>n2){
        if (n1 % n2 == 0){
        Console.WriteLine("Первое число кратно второму");    
        }
        else{
            Console.WriteLine("Первое число НЕкратно второму и остаток равен " + Convert.ToString(n1 % n2));    
        }
}else if (n2>n1){
        if (n2 % n1 == 0){
            Console.WriteLine("Второе число кратно первому");    
            }
            else{
                Console.WriteLine("Второе число НЕкратно первому и остаток равен " + Convert.ToString(n2 % n1));    
            }
}