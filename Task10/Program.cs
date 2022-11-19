// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 456 -> 5
// 782 -> 8
// 918 -> 1

int Middle(int num)
{
    int middleDigit = num / 10;
    int result = middleDigit % 10;
    return result;
}

Console.WriteLine("Введите трёхзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
if(number < 1000 && number > 99 || number > -1000 && number < -99)
{
    int res = Middle(number);
    Console.WriteLine(res);
}
else Console.WriteLine("Число не является трёхзначным");