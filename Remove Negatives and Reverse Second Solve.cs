var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
var positives = new List<int>();
foreach (var num in nums)
{
    if (num >= 0)
    {
        positives.Add(num);
    }
}
positives.Reverse();
if (positives.Count > 0)
{
    Console.WriteLine(string.Join(" ", positives));
}
else
{
    Console.WriteLine("empty");
}