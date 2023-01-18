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

int SumOfChetIndex (int [] array)
{   
    int sum = 0;
    int size = array.Length;
    for (int i = 0; i < size; i+=2)
    {   
        sum = sum + array[i];
    }
    return sum;
}

int sum = SumOfChetIndex(array);
Console.WriteLine($"Сумма элементов, стоящих на четных позициях равна {sum}");
