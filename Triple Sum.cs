var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

static bool Contains(int[] numbers, int sum)
{
    bool exists = false;
    for (int i = 0; i < numbers.Length; i++)  // Same as numbers.Count
    {
        if (numbers[i] == sum)
        {
            exists = true;
            break;
        }
    }
    return exists;
}

var count = 0;
for (int left = 0; left < numbers.Length; left++)
{
    for (int right = left + 1; right < numbers.Length; right++)
    {
        var sum = numbers[left] + numbers[right];
        bool exists = Contains(numbers, sum);
        if (exists)
        {
            Console.WriteLine($"{numbers[left]} + {numbers[right]} == {sum}");
            count++;
        }
    }
}
if (count == 0)
{
    Console.WriteLine("No");
}