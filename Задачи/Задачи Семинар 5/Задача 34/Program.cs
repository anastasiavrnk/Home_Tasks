// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int [] CreateArray(int length, int minValue = 100, int maxValue = 1000)
{
    int[] array = new int[length];
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1);
    
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}


int[] array = CreateArray(10);
PrintArray(array);
   
int CountOfChetNumbers (int [] array)
{   
    int count = 0;
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {   
        if(array[i] % 2 == 0 ) 
        {
            count++;
        }
    }
    return count;
}
int count = CountOfChetNumbers(array);
Console.WriteLine($"В массиве четных чисел {count}");
