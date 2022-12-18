// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int[] shisla = {3, 5, 7, 10, 15, 20};
for (int k=0; k<shisla.Length;k++){
    
int F = shisla[k];
int[] mass = new int[F];
    mass[0]=0;
    mass[1]=1;
    for (int i=2; i<F; i++)
    {
        mass[i]=mass[i-1]+mass[i-2];
    }
Console.WriteLine($"числа Фибоначчи из {F} элементов будут следующие: {string.Join(", ", mass)}");
}