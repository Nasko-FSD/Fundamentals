var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
var count = new SortedDictionary<double, int>();
foreach (var number in numbers)
{
    if (count.ContainsKey(number))
    {
        count[number]++;
    }
    else
    {
        count[number] = 1;
    }
}
foreach (var pair in count)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value} times");
}