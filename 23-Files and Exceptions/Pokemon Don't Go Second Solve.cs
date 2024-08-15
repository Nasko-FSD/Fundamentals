List<int> numbers = Console.ReadLine()
    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();
long sum = 0;
 
while (numbers.Count > 0)
{
    int currentIndex = int.Parse(Console.ReadLine());
    int removedNumber = 0;

    if (currentIndex < 0)
    {
        removedNumber = numbers[0];
        numbers[0] = numbers[numbers.Count - 1];
    }
    else if (currentIndex > numbers.Count - 1)  
    {
        removedNumber = numbers[numbers.Count - 1];
        numbers[numbers.Count - 1] = numbers[0];
    }
    else
    {
        removedNumber = numbers[currentIndex];
        numbers.RemoveAt(currentIndex);
    }
    sum += removedNumber;

    for (int i = 0; i < numbers.Count; i++)
    {
        int currentNumber = numbers[i];
        if (currentNumber <= removedNumber)
        {
            numbers[i] += removedNumber;
        }
        else
        {
            numbers[i] -= removedNumber;
        }
    }
}
Console.WriteLine(sum);