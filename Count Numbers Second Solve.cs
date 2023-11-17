var numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
numbers.Sort();
for (int start = 0; start < numbers.Count; start++)
{
    int end;
    for (end = start + 1; end < numbers.Count; end++)
    {
        if (numbers[start] != numbers[end])
        {
            break;
        }
    }
    var count = end - start;
    start = end - 1;
    Console.WriteLine($"{numbers[start]} -> {count}");
}