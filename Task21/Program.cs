// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки A ");
double ax = Convert.ToDouble(Console.ReadLine());
double ay = Convert.ToDouble(Console.ReadLine());
double az = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки B ");
double bx = Convert.ToDouble(Console.ReadLine());
double by = Convert.ToDouble(Console.ReadLine());
double bz = Convert.ToDouble(Console.ReadLine());

double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double res1 = (x2-x1) * (x2-x1);
    double res2 = (y2-y1) * (y2-y1);
    double rez3 = (z2-z1) * (z2-z1);
    double result = res1 + res2 + rez3;
    return Math.Sqrt(result);
}

double distance = Distance(ax, ay, az, bx, by, bz);
Console.WriteLine(Math.Round(distance, 2, MidpointRounding.ToZero));