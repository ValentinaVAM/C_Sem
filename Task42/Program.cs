// 
// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int[] BinaryCode(int num)
{
    int num2 = num;
    int count = 0;
    while (num > 0)
    {
        num = num / 2;
        count++;
    }
    int[] arr = new int[count];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = num2 % 2;
        num2 = num2 / 2;
    }
    return arr;
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
int[] arr = BinaryCode(45);
PrintArray(arr);
