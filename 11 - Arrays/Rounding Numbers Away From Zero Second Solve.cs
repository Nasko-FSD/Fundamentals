double[] numbers = Console.ReadLine()
    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
    .Select(double.Parse)
    .ToArray();

Rounded(numbers);

static void Rounded(double[] numbers)
{
    int[] result = new int[numbers.Length];
    for (int i = 0; i < numbers.Length; i++)
    {
        result[i] = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);
        Console.WriteLine($"{numbers[i]} => {result[i]}");
    }
}