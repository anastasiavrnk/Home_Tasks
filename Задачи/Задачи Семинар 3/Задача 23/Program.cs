//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int N = int.Parse(Console.ReadLine()!);
int i = 1;

if (N > 1)
{
    while (i <= N)
    {
        double cubeOfNumber = Math.Pow(i, 3);
        i++;
        Console.WriteLine(cubeOfNumber);
    }
    return;   
}

else
{
    Console.WriteLine($"Число должно быть больше 1");
}
