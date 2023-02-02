// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

int AkkermanFunction (int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return AkkermanFunction(m - 1,1);
    }
    else if (m > 0 && n > 0)
    {
        return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
    }
    else
    {
        return 0;
    }
}

int A = AkkermanFunction(3, 2);
Console.WriteLine(A);