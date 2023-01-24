// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите количество задаваемых чисел: ");
int M = Convert.ToInt32(Console.ReadLine());

int [] CreateArray(int M)
{
    int[] array = new int[M];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i+1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int NumbersGreaterThanZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
         if (array[i] > 0)
         {
             count++;
         }
     }
     return count;
}

int[] array = CreateArray(M);
int qtyNumbers = NumbersGreaterThanZero(array);

Console.WriteLine($"Количество чисел больше нуля равно {qtyNumbers}");

