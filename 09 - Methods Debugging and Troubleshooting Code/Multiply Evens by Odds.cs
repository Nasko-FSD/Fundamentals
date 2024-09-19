int number = int.Parse(Console.ReadLine());

int result = GetMultipleOfEvensAndOdds(number);
Console.WriteLine(result);
static int GetMultipleOfEvensAndOdds(int number)
{
    int result = 0;
    number = Math.Abs(number);
    int evenSum = GetSumOfEvenDigits(number);
    int oddSum = GetSumofOddDigits(number);
    result = evenSum * oddSum;
    return result;
}

static int GetSumOfEvenDigits(int number)
{
    int evenNumbers = 0;
    while (number > 0)
    {
        int lastDigit = number % 10;
        if (lastDigit % 2 == 0)
        {
            evenNumbers += lastDigit;
        }
        number /= 10;
    }
    return evenNumbers;
}

static int GetSumofOddDigits(int number)
{
    int oddNumbers = 0;
    while (number > 0)
    {
        int lastDigit = number % 10;
        if (lastDigit % 2 == 1)
        {
            oddNumbers += lastDigit;
        }
        number /= 10;
    }
    return oddNumbers;
}