//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double [,] CreateArray(int rows, int columns, int minValue = 0, int maxValue = 50)
{
    double[,] array = new double[rows, columns];
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = Convert.ToDouble(new Random().Next(minValue, maxValue+1))/10;
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j], 4} ");
        }
        Console.WriteLine();
    }
}    

double[,] array = CreateArray(3, 4);
PrintArray(array);