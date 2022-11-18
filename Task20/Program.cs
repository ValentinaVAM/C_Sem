// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21


Console.WriteLine("Введите координаты точки A ");
double ax = Convert.ToDouble(Console.ReadLine());
double ay = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки B ");
double bx = Convert.ToDouble(Console.ReadLine());
double by = Convert.ToDouble(Console.ReadLine());

double Distance(double x1, double y1, double x2, double y2)
{
    double res1 = (x2-x1) * (x2-x1);
    double res2 = (y2-y1) * (y2-y1);
    double result = res1 + res2;
    return Math.Sqrt(result);
}

double distance = Distance(ax, ay, bx, by);
Console.WriteLine(Math.Round(distance, 2, MidpointRounding.ToZero));