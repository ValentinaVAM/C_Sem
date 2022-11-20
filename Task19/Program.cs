// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());

bool Palindrom(int num)
{
    int num1 = num / 10000;
    int num2 = num % 10;
    int num3 = num / 1000 % 10;
    int num4 = num / 10 % 10;
    return num1 == num2 && num3 == num4;
}

bool result = Palindrom(number);
Console.WriteLine(result ? "Да, является палиндромом" : "Не является палиндромом");