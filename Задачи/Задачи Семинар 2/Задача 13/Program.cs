// Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.

int number = int.Parse(Console.ReadLine()!);
number = Math.Abs(number);

if (number > 99)
{   
    while (number > 999)
    {
        number = number / 10;
    }
int result = number % 10;
Console.WriteLine(result);}

else
{
    Console.WriteLine("Третьей цифры нет");
}
