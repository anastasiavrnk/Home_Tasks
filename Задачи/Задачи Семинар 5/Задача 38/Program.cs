// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

double [] CreateArray(int length, int minValue = 10, int maxValue = 100)
{
    double[] array = new double[length];
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}

double[] array = CreateArray(4);
PrintArray(array);

double ReturnMinValue (double[] array)
{
   double minValue = array[0];
   for (int i = 0; i < array.Length; i++)
   {
    if(array[i] < minValue)
    {
        minValue = array[i];
    }
   }
   return minValue;
}

double ReturnMaxValue (double[] array)
{
   double maxValue = array[0];
   for (int i = 0; i < array.Length; i++)
   {
    if(array[i] > maxValue)
    {
        maxValue = array[i];
    }
   }
   return maxValue;
}

double minNumber = ReturnMinValue(array);
double maxNumber = ReturnMaxValue(array);

Console.WriteLine($"Разница между максимальным числом {maxNumber} и минимальным числом {minNumber} равна {maxNumber - minNumber}");