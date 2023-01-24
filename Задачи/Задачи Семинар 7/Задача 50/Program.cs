// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] CreateArray(int rows, int columns, int minValue = 0, int maxValue = 50)
{
    int[,] array = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(minValue, maxValue+1);
        }

    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j], 3} ");
        }
        Console.WriteLine();
    }
}  

int [,] array = CreateArray(3, 4);
PrintArray(array);
Console.WriteLine();

void ReturnArrayElement(int i, int j)
{
    if(i < array.GetLength(0) && j < array.GetLength(1))
    {
        Console.WriteLine($"Значение элемента на заданной позиции: {array[i, j]}");
    }
    else
    {
        Console.WriteLine($"На позиции {i}, {j} нет элементов'");
    }
}

Console.WriteLine("Введите позицию элемента в строке");
int i = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите позицию элемента в стобце");
int j = int.Parse(Console.ReadLine()!);

ReturnArrayElement(i, j);