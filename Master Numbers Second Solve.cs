int number = int.Parse(Console.ReadLine());
for (int i = 1; i <= number; i++)
{
    if (Palindrome(i) && DivisibleBy7(i) && EvenNumber(i))
    {
        Console.WriteLine(i);
    }
}

static bool Palindrome(int num)
{
    int n = num;
    int reverse = 0;
    while (num > 0)
    {
        int dig = num % 10;
        reverse = reverse * 10 + dig;
        num /= 10;
    }
    if (n == reverse)
    {
        return true;
    }
    return false;
}

static bool DivisibleBy7(int num)
{
    int sum = 0;
    while (num > 0)
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

static bool EvenNumber(int num)
{
    while (num > 0)
    {
        int digit = num % 10;
        num /= 10;
        if (digit % 2 == 0)
        {
            return true;
        }
    }
    return false;
}
