// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на чётных позициях.

int [] CreateArray(int length, int minValue = 10, int maxValue = 100)
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


int[] array = CreateArray(4);
PrintArray(array);