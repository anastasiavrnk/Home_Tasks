// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] Create3DArray(int x, int y, int z, int minValue = 10, int maxValue = 99)
{
    int[,,] array = new int[x, y, z];
    var rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = rnd.Next(minValue, maxValue+1);
            }
        }
    }
    return array;
}

void Print3DArray(int[,,] array)
{
    for (int i = 0; i <  array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) 
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write( $"{array[i,j,k]} ({i}, {j}, {k}); ");            
            }
            Console.WriteLine();
        }        
    }        
}

int[,,] array = Create3DArray(2, 2, 2);
Print3DArray(array);