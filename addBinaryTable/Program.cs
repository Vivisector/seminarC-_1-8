// пробую написать программку, которая выведет матрицу из всех возможных сочетаний 0 и 1 для четырех бит
// не понял, откуда в
/*
Console.Write(Convert.ToString(9, 16)); // в качестве base м испть только 2, 8, 16. И будет выведено заявленное число в нужной системе счисления
*/
    // 

for (int i = 0; i < 4; i++)
{
    var binary = Convert.ToString(i, 2);
    // Console.Write(binary)
if (binary.Length == 1) Console.Write("000" + Convert.ToString(i, 2) + " "); //добавляем незначащие нули для ровности отображения
if (binary.Length == 2) Console.Write("00" + Convert.ToString(i, 2) + " ");
if (binary.Length == 3) Console.Write("0" + Convert.ToString(i, 2) + " ");
if (binary.Length == 4) Console.Write(Convert.ToString(i, 2) + " ");    
    // Console.Write(Convert.ToString(i, 2) + " ");
}
Console.WriteLine();
for (int i = 4; i < 8; i++)
{
    var binary = Convert.ToString(i, 2);
    // Console.Write(binary)
if (binary.Length == 1) Console.Write("000" + Convert.ToString(i, 2) + " "); //добавляем незначащие нули для ровности отображения
if (binary.Length == 2) Console.Write("00" + Convert.ToString(i, 2) + " ");
if (binary.Length == 3) Console.Write("0" + Convert.ToString(i, 2) + " ");
if (binary.Length == 4) Console.Write(Convert.ToString(i, 2) + " ");    
    // Console.Write(Convert.ToString(i, 2) + " ");
}
Console.WriteLine();
for (int i = 8; i < 12; i++)
{
    var binary = Convert.ToString(i, 2);
    // Console.Write(binary)
if (binary.Length == 1) Console.Write("000" + Convert.ToString(i, 2) + " "); //добавляем незначащие нули для ровности отображения
if (binary.Length == 2) Console.Write("00" + Convert.ToString(i, 2) + " ");
if (binary.Length == 3) Console.Write("0" + Convert.ToString(i, 2) + " ");
if (binary.Length == 4) Console.Write(Convert.ToString(i, 2) + " ");    
    // Console.Write(Convert.ToString(i, 2) + " ");
}
Console.WriteLine();
for (int i = 12; i < 16; i++)
{
    var binary = Convert.ToString(i, 2);
    // Console.Write(binary)
if (binary.Length == 1) Console.Write("000" + Convert.ToString(i, 2) + " "); //добавляем незначащие нули для ровности отображения
if (binary.Length == 2) Console.Write("00" + Convert.ToString(i, 2) + " ");
if (binary.Length == 3) Console.Write("0" + Convert.ToString(i, 2) + " ");
if (binary.Length == 4) Console.Write(Convert.ToString(i, 2) + " ");    
    // Console.Write(Convert.ToString(i, 2) + " ");
}
