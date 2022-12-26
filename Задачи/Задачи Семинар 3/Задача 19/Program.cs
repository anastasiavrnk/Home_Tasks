//Напишите программу, которая принимает 
//на вход пятизначное число и проверяет, является ли оно палиндромом.

void PrintResultOfPalindrome(int number)

{
   if (number/10000 == number%10)
    {
        if ((number/1000)%10 == (number%100)/10)
        {
            Console.WriteLine($"Число {number} является палиндромом");
            return;
        }
    }
    Console.WriteLine($"Число {number} не является палиндромом");
}



int number = int.Parse(Console.ReadLine()!);

if (number > 9999 && number < 99999)
{
    Console.WriteLine(PrintResultOfPalindrome(number));
}

else
{
    Console.WriteLine($"Число {number} является палиндромом");
}



