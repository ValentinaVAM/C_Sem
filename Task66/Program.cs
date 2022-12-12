// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int num1, int num2)
{
    if (num1 == 0 || num2 == 0) return 0;
    else if (num1 == num2) return num1;
    else if (num1 < num2) return num2 + SumNumbers(num1, num2 - 1);
    else return num2 + SumNumbers(num1, num2 + 1);
}

int result = SumNumbers(m, n);
if (m == 0 || n == 0) Console.WriteLine("Введите натуральное число");
else Console.WriteLine($"Сумма -> {result}");
