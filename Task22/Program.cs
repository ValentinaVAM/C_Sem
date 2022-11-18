// // Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

Console.Write("Введите число  ");
int number = Convert.ToInt32(Console.ReadLine());

void Square(int numb)
{
    int count = 1;
    while (count <= numb)
    {
        Console.WriteLine($"{count}  {count * count}");
        count++;
    }
}
Square(number);
