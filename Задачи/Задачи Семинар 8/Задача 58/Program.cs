// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] CreateArray(int rows, int columns, int minValue = 0, int maxValue = 9)
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


void GetArrayComposition(int [,] array, int[,] array2)
{
    if (array.GetLength(0) != array2.GetLength(1))
    {
        Console.WriteLine("Матрицы нельзя перемножить");
        return;
    }

    int[,] resultArray = new int[array.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                resultArray[i,j] += array[i,k] * array2[k,j];
            }
            Console.Write($"{resultArray[i, j], 3} ");
        }
        Console.WriteLine();
    }
    
}

int [,] array = CreateArray(2, 2);
int [,] array2 = CreateArray(2, 2);
PrintArray(array);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();
GetArrayComposition(array, array2);