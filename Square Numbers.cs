List<int> numbers = Console.ReadLine()
    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();
List<int> result = new List<int>();
for (int i = 0; i < numbers.Count; i++)
{
    if (Math.Sqrt(numbers[i]) == (int)Math.Sqrt(numbers[i]))
    {
        result.Add(numbers[i]);
    }
}
result.Sort();
for (int j = result.Count - 1; j >= 0; j--)
{
    Console.Write(result[j] + " ");
}