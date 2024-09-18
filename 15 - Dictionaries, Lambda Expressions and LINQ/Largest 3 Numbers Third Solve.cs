List<double> numbers = Console.ReadLine()
    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
    .Select(double.Parse)
    .ToList();

for (int i = 0; i < numbers.Count; i++)
{
    for (int j = 0; j < numbers.Count - 1; j++)
    {
        if (numbers[j] < numbers[j + 1])
        {
            double temp = numbers[j];
            numbers[j] = numbers[j + 1];
            numbers[j + 1] = temp;
        }
    }
}

int largest3Numbers = 3;
int endIndex = Math.Min(numbers.Count, largest3Numbers);

for (int i = 0; i < endIndex; i++)
{
    Console.Write(numbers[i] + " ");
}