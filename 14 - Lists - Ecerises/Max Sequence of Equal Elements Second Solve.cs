List<int> numbers = Console.ReadLine()
    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();
int maxSequence = 0;
int elements = 0;
foreach (var number1 in numbers)
{
    int counter = 0;
    foreach (var number2 in numbers)
    {
        if (number1 == number2)
        {
            counter++;
        }
    }
    if (counter > maxSequence)
    {
        maxSequence = counter;
        elements = number1;
    }
}
for (int i = 0; i < maxSequence; i++)
{
    Console.Write(elements + " ");
}