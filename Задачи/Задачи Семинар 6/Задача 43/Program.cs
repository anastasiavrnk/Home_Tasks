// Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void IntersectionOfLines(double b1, double k1, double b2, double k2)
{
    if (k1 == k2 && b1 == b2)
    {
       Console.WriteLine("Две прямые имеют бесконечное количество точек соприкосновения, так как координаты двух прямых полностью совпадают");
    }
    else if (k1 == k2)
    {
        Console.WriteLine("Прямые параллельны");
    }    
    else
    {
        double x = (-b2 + b1)/(-k1 + k2);
        double y = k2 * x + b2;
        Console.WriteLine($"Две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
    }
}
double b1 = 2;
double k1 = 5;
double b2 = 4;
double k2 = 9;
IntersectionOfLines(b1, k1, b2, k2);
