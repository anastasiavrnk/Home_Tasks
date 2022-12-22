//Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

int GetSecondDigit(int number)
{
    int firstDigit = number / 100;
    int lastDigit = number % 10;
    int secondDigit = (number - firstDigit*100 - lastDigit)/10;
    return secondDigit;
}

int number = int.Parse(Console.ReadLine()!);
if (number > 99 && number < 1000)
{
    Console.WriteLine(GetSecondDigit(number));
}

else
{
    Console.WriteLine("Вы ввели не трехзначное число");
}