﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Введите три числа: ");

int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
int max;

if(number1 > number2)
{
   if(number3 > number1)
   {
      max = number3;
   }
   else
   {
      max = number1;
   }
}
else
{
   if(number3 > number2)
   {
      max = number3;
   }
   else{
      max = number2;
   }
}
Console.WriteLine($"Максимальное число {max}");