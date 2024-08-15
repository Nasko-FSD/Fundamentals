List<int> numbers = Console.ReadLine()
    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

long sum = 0L;
while (numbers.Count > 0)
{
    int removedElement = 0;
    int currentIndex = int.Parse(Console.ReadLine());
    if (currentIndex < 0)
    {
        removedElement = numbers[0];
        sum += numbers[0];
        numbers[0] = numbers[numbers.Count - 1];
    }
    else if (currentIndex > numbers.Count - 1)
    {
        removedElement = numbers[numbers.Count - 1];
        sum += numbers[numbers.Count - 1];
        numbers[numbers.Count - 1] = numbers[0];
    }
    else
    {
        removedElement = numbers[currentIndex];
        sum += removedElement;
        numbers.RemoveAt(currentIndex);
    }

    for (int j = 0; j < numbers.Count; j++)
    {
        if (numbers[j] <= removedElement)
        {
            numbers[j] += removedElement;
        }
        else if (numbers[j] > removedElement)
        {
            numbers[j] -= removedElement;
        }
    }
}
Console.WriteLine(sum);