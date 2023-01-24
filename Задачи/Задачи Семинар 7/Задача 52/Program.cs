// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateArray(int rows, int columns, int minValue = -10, int maxValue = 10)
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

void GetArithmeticMean(int[,] array)
{   
    double sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
        }
        double result = sum/array.GetLength(0);
        Console.WriteLine(result + "; ");
        sum = 0;
    }
}

Console.WriteLine("Введите количество строк");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество стоблцов");
int columns = int.Parse(Console.ReadLine()!);

int [,] array = CreateArray(rows, columns);
PrintArray(array);
GetArithmeticMean(array);




