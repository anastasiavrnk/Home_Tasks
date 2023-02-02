// Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumOfNumbers(int M, int N)
{
    if (M == N)
    {
        return M;
    }
    else if (N == 0)
    {
        return (M * (M + 1)) / 2;
    }
    int sum = M + SumOfNumbers(M+1, N);
    return sum;  
}

int result = SumOfNumbers(1, 15);
Console.WriteLine(result);