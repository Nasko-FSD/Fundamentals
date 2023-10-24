int number = int.Parse(Console.ReadLine());
for (int i = 1; i <= number; i++)
{
    if (IsPalindrome(i) &&
        SumOfDigitsDivisibleBySeven(i) &&
        ContainsEvenDigits(i))
        Console.WriteLine(i);
}
static bool IsPalindrome(int num)
{
    int n = num;
    int rev = 0;
    while (num > 0)
    {
        int dig = num % 10;
        rev = rev * 10 + dig;
        num /= 10;
    }
    if (n == rev)
    {
        return true;
    }
    return false;
}

static bool SumOfDigitsDivisibleBySeven(int num)
{
    int sum = 0;
    while (num != 0)
    {
        sum += num % 10;
        num /= 10;
    }
    if (sum % 7 == 0)
    {
        return true;
    }
    return false;
}
static bool ContainsEvenDigits(int num)
{
    while (num > 0)
    {
        int digit = num % 10;
        if (digit % 2 == 0)
        {
            return true;
        }
        num /= 10;
    }
    return false;
}