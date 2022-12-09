// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumNums (int n)
{
    if (n == 0) return 0;
    else return n % 10 + SumNums(n / 10);
}

int result = SumNums(num);       
Console.WriteLine(result);    
