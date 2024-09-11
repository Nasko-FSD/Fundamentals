List<long> behives = Console.ReadLine()
    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
    .Select(long.Parse)
    .ToList();

List<long> hornets = Console.ReadLine()
    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
    .Select(long.Parse)
    .ToList();

for (int i = 0; i < behives.Count; i++)
{
    long hornetsPower = hornets.Sum();

    if (hornetsPower == 0)
    {
        break;
    }

    if (behives[i] < hornetsPower)
    {
        behives[i] = 0;
    }
    else
    {
        behives[i] -= hornetsPower;
        hornets.RemoveAt(0);
    }
}
if (behives.Sum() > 0)
{
    Console.WriteLine(string.Join(" ", behives.Where(b => b != 0)));
}
else
{
    Console.WriteLine(string.Join(" ", hornets.Where(h => h != 0)));
}