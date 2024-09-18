using System.Numerics;

int number = int.Parse(Console.ReadLine());
BigInteger factorial = 1;
for (int i = 2; i <= number; i++)
{
    factorial *= i;
}
int counter = 0;
while (factorial > 0)
{
    BigInteger digit = factorial % 10;
    if (digit > 0)
    {
        break;
    }
    counter++;
    factorial /= 10;
}
Console.WriteLine($"{counter} trailing zeroes");