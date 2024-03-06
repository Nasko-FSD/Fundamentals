int[] numbers = Console.ReadLine()
    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int counter = 1;
int maxSequence = 1;
int endIndex = 0;
for (int i = 0; i < numbers.Length - 1; i++)
{
    if (numbers[i] < numbers[i + 1])
    {
        counter++;
        if (counter > maxSequence)
        {
            maxSequence = counter;
            endIndex = i + 1;
        }
    }
    else
    {
        counter = 1;
    }
}
int startIndex = endIndex - maxSequence + 1;
for (int i = startIndex; i <= endIndex; i++)
{
    Console.Write(string.Join(" ", numbers[i] + " "));
}