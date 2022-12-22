//Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
int number = int.Parse(Console.ReadLine()!);
if (number >=1 && number <=5)
{
    Console.WriteLine("Нет");
}
else if (number==6 || number ==7)
{
    Console.WriteLine("Да");
}