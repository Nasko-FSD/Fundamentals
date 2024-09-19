long number = long.Parse(Console.ReadLine());
bool result = IsPrime(number);
Console.WriteLine(result);

static bool IsPrime(long number)
{
    bool result = true;
    if (number == 0 || number == 1)
    {
        result = false;
    }
    for (long i = 2; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0)
        {
            result = false;
            break;
        }
    }
    return result;
}