int count = int.Parse(Console.ReadLine());
int[] numbers = new int[count];
for (int i = 0; i < count; i++)
{
    numbers[i] = int.Parse(Console.ReadLine());
}

PrintResults(numbers);

static void PrintResults(int[] numbers)
{
    Console.WriteLine($"Sum = {sumNumbers(numbers)}");
    Console.WriteLine($"Min = {minNumber(numbers)}");
    Console.WriteLine($"Max = {maxNumber(numbers)}");
    Console.WriteLine($"Average = {averageNumber(numbers)}");
}

static int sumNumbers(int[] numbers)
{
    int result = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        result += numbers[i];
    }
    return result;
}

static int minNumber(int[] numbers)
{
    int result = int.MaxValue;
    for (int i = 1; i < numbers.Length - 1; i++)
    {
        if (numbers[i] < result)
        {
            result = numbers[i];
        }
    }
    return result;
}

static int maxNumber(int[] numbers)
{
    int result = int.MinValue;
    for (int i = 0; i < numbers.Length - 1; i++)
    {
        if (numbers[i] > result)
        {
            result = numbers[i];
        }
    }
    return result;
}

static double averageNumber(int[] numbers)
{
    double result = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        result += numbers[i];
    }
    result /= numbers.Length;
    return result;
}