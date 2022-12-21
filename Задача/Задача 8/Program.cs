//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int N = int.Parse(Console.ReadLine()!);
int i = 1;

while (i <= N && N>1)
{   
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
    i++;
}

