int n = int.Parse(Console.ReadLine());
decimal sum = 0;
for (int all = 0; all < n; all++)
{
    decimal numbers = decimal.Parse(Console.ReadLine());
    sum += numbers;
}
Console.WriteLine(sum);