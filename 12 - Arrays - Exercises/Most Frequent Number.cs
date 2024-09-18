int[] numbers = Console
    .ReadLine()
    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int maxSequence = 0;
int elements = 0;
for (int i = 0; i < numbers.Length; i++)
{
    int counter = 0;
    for (int j = i; j < numbers.Length; j++)
    {
        if (numbers[i] == numbers[j])
        {
            counter++;
        }
    }
    if (counter > maxSequence)
    {
        maxSequence = counter;
        elements = numbers[i];
    }
}
Console.Write(elements);