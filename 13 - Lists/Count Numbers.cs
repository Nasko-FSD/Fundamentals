var numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
numbers.Sort();
for (int start = 0; start < numbers.Count; start++)
{
    int count = 1;
    while (start + count < numbers.Count && numbers[start] == numbers[start + count])
    {
        count++;
    }
    start += count - 1;
    Console.WriteLine($"{numbers[start]} -> {count}");
}