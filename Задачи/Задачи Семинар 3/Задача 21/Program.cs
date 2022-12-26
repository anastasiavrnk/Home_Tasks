//Напишите программу, которая принимает 
//на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double GetDistanceBetweenDots(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
    return result;
}

int x1 = int.Parse(Console.ReadLine()!);
int y1 = int.Parse(Console.ReadLine()!);
int z1 = int.Parse(Console.ReadLine()!);

int x2 = int.Parse(Console.ReadLine()!);
int y2 = int.Parse(Console.ReadLine()!);
int z2 = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Расстояние равно {GetDistanceBetweenDots(x1, y1, z1, x2, y2, z2)}");


