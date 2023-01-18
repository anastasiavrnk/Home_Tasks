// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int GetSumOfDigit(int number)
{
    int sum = 0;
    if (Math.Abs(number)>0)
    {
        while(number != 0)
        {
            sum = sum + (number % 10);
            number = number/10;
        }
    }
    return Math.Abs(sum);
}

int number = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр в числе {number} равна {GetSumOfDigit(number)}");
