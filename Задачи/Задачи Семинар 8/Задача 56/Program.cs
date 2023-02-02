// Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов

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

void FindRowWithMinSum(int[,] array)
{
    int minSum = int.MaxValue;
    int rowIndex = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j]; 
        }
        if (sum < minSum)
        {
            minSum = sum;
            rowIndex++;
        }
    }
    Console.WriteLine($"Наименьшая сумма элементов равна {minSum} и находится в строке с индексом {rowIndex}");
}


int [,] array = CreateArray(3, 3);
PrintArray(array);
FindRowWithMinSum(array);