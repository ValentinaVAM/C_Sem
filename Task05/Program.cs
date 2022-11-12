Console.WriteLine("Введите число N ");

int n = Convert.ToInt32(Console.ReadLine());
int count = -n;
while(count <= n)
{
    Console.Write ($"{count} ");
    count = count + 1;
}

if(n < 0)
    while(count >= n)
    {
    Console.Write ($"{count} ");
    count = count - 1;
    }