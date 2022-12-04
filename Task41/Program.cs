// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int[] array = new int[3];

void FillNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите любое число с индексом {i}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int GetNumberPositiveElem(int[] array)
{
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) res++; 
    }
    return res;
}
FillNumbers(array);
PrintArray(array);
int numberPositiveElem = GetNumberPositiveElem(array);
Console.WriteLine($"Положительных чисел --> {numberPositiveElem}");