int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    int sum = SumofDigits(i);
    bool special = (sum == 5 || sum == 7 || sum == 11);
    Console.WriteLine($"{i} -> {special}");
}
int SumofDigits(int i)
{
    int num = i;
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}