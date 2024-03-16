List<int> numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();
numbers.Sort();
int count = 1;
for (int i = 0; i < numbers.Count - 1; i++)
{
    if (numbers[i] == numbers[i + 1])
    {
        count++;
    }
    else
    {
        Console.WriteLine($"{numbers[i]} -> {count}");
        count = 1;
    }
}
Console.WriteLine($"{numbers[numbers.Count - 1]} -> {count}");