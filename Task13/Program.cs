//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
if(number < 0)
{
    number = -number;
}

int TripleDigit(int num)
{
while (num > 1000)
    {
        num = num / 10;
    }
    return num % 10;
}

int result = TripleDigit(number);
if(number > 99) Console.WriteLine($"Третья цифра {result}");
else Console.WriteLine("Нет третьей цифры");
