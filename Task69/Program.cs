﻿// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


Console.WriteLine("Введите число a: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int num2 = Convert.ToInt32(Console.ReadLine());


int MultyPlace (int a, int b)
{
    if (b == 0) return 1;
    else return a *MultyPlace(a, b - 1);
}

int result = MultyPlace(num1, num2);       
Console.WriteLine(result);    
