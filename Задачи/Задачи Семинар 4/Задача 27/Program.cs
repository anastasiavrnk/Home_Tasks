// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int GetSumOfDigit(int number)
{
    int sum = 0;
        while(number % 10 != 0)
        {
            sum = sum + (number % 10);
            number = number/10;
        }
    return sum;
}

int number = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр в числе {number} равна {GetSumOfDigit(number)}");
