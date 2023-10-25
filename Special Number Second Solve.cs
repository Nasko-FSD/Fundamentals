int n = int.Parse(Console.ReadLine());

PrintSpecial(n);

static void PrintSpecial(int n)
{
    for (int i = 1; i <= n; i++)
    {
        int num = i;
        int sum = 0;
        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }
        bool special = (sum == 5 || sum == 7 || sum == 11);
        Console.WriteLine($"{i} -> {special}");
    }
}