// Напишите цикл, который принимает на вход два 
//числа (A и B) и возводит число A в натуральную степень B.


void ToDegree(int A, int B)
{
    int result = 1;
    for (int i = 1; i <= B; i++)
    {
        result = result * A;
    }
    Console.WriteLine(A + " в степени " + B + " = " + result);
}

int A = int.Parse(Console.ReadLine()!);
int B = int.Parse(Console.ReadLine()!);

ToDegree(A, B);
