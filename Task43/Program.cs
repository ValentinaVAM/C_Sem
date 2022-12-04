// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите значение b1: ");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2: ");
double number2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение K1: ");
double number3 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2: ");
double number4 = Convert.ToDouble(Console.ReadLine());

double GetIntersectionPointX(double num1, double num2, double num3, double num4)
{
    double res1 = 0;
    res1 = (num2 - num1) / (num3 - num4);
    return res1;
}

double GetIntersectionPointY(double num1, double num2, double num3, double num4)
{
    double res2 = 0;
    res2 = num3 * (num2 - num1) / (num3 - num4) + num1;
    return res2;
}

double result1 = GetIntersectionPointX(number1, number2, number3, number4);
double result2 = GetIntersectionPointY(number1, number2, number3, number4);

if (number3 == number4) Console.WriteLine($"Прямые параллельные");
else Console.WriteLine($"Точка пересечения двух прямых: ({Math.Round(result1, 1)}; {Math.Round(result2, 1)})");
