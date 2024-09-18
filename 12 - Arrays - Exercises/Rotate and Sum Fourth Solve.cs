int[] numbers = ParseArray(Console.ReadLine());

int rotations = int.Parse(Console.ReadLine());

int[] sumArray = new int[numbers.Length];

for (int i = 0; i < rotations; i++)
{
    Shift(numbers);
    Sum(sumArray, numbers);
}

Console.WriteLine(string.Join(" ", sumArray));

static void Sum(int[] summArray, int[] numbers)
{
    for (int i = 0; i < summArray.Length; i++)
    {
        summArray[i] += numbers[i];
    }
}

static void Shift(int[] numbers)
{
    int lastElement = numbers[numbers.Length - 1];
    for (int i = numbers.Length - 1; i > 0; i--)
    {
        numbers[i] = numbers[i - 1];
    }
    numbers[0] = lastElement;
}

int[] ParseArray(string numbers)
{
    string[] tokens = numbers
        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[tokens.Length];

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = int.Parse(tokens[i]);
    }
    return result;
}