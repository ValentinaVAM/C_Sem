Console.WriteLine("Введите два числа: ");

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int max;

if(a >= b)
{
    max = a;
    Console.WriteLine($"Максимальное число {max}");
}
else
{
    max = b;
    Console.WriteLine($"Максимальное число {max}");
}