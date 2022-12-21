//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);

if (a > b)
{
    Console.WriteLine ($"Максимальное число {a}, минимальное число {b}");
}

else if (a < b)
{
    Console.WriteLine ($"Максимальное число {b}, минимальное число {a}");
}

else
{
    Console.WriteLine ($"Число {a} равно числу {b}");
}