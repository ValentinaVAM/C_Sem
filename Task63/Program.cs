﻿// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


Console.WriteLine("Введите натруальное число: ");
int number = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(number);

void NaturalNumbers(int num)
{
    if (num == 0) return;        //или можно так if (num > 0)
    NaturalNumbers (num - 1);    //{ Console.Write($"{num} "); 
    Console.Write($"{num} ");    // NaturalNumbers (num - 1); }
}