int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int maxSum = int.Parse(Console.ReadLine());
int sum = 0;
int counter = 0;
for (int i = firstNumber; i >= 1; i--)
{
    for (int j = 1; j <= secondNumber; j++)
    {
        sum += (i * j) * 3;
        counter++;

        if (sum >= maxSum)
        {
            Console.WriteLine($"{counter} combinations");
            Console.WriteLine($"Sum: {sum} >= {maxSum}");
            return;
        }
    }
}
Console.WriteLine($"{counter} combinations");
Console.WriteLine($"Sum: {sum}");