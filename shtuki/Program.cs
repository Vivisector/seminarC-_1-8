string Shtuki(int count)
{
    string shtuk = string.Empty;
if ((count % 10 == 1 && count != 11) || count == 0) shtuk =" раз";
else if ((count % 10 == 2 || count % 10 == 3 || count % 10 == 4) && (count != 12 && count != 13 && count != 14)) shtuk = " раза";
else shtuk = " раз";
return shtuk;
}
Console.WriteLine("Введите любое число:");
int chislo = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(chislo + Shtuki(chislo));
Console.WriteLine(chislo + Shtuki(chislo));