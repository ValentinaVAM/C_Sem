Console.WriteLine("Введите трёхзначное число: ");

int number = Convert.ToInt32(Console.ReadLine());
if(number < 1000 && number > 99)
{
    number = number %10;
    Console.WriteLine($"Последняя цифра {number}");
}
else
{
    Console.WriteLine("Введите трёхзначное число ");
}