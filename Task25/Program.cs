// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243
// 2, 4 -> 16

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int Exponentiation(int num1, int num2)
{
    int result = 1;
    for (int i = 1; i <= num2; i++)
    {
        result = result * num1;
    }
    return result; 
}

if (number2 > 0)
{
    int res = Exponentiation(number1, number2);

    if(number1 < 0) Console.WriteLine($"Ответ: - {res}");
    else Console.WriteLine($"Ответ: {res}");
}
else Console.WriteLine("Второе число введите натуральное");
