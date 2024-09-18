string[] racers = Console.ReadLine()
    .Split();
double[] zones = Console.ReadLine()
    .Split()
    .Select(double.Parse)
    .ToArray();
int[] indexes = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

double[] fuel = new double[racers.Length];

fuel = racers
    .Select(e => (double)e[0])
    .ToArray();

for (int i = 0; i < zones.Length; i++)
{
    if (indexes.Contains(i))
    {
        for (int j = 0; j < racers.Length; j++)
        {
            if (fuel[j] > 0)
            {
                fuel[j] += zones[i];
            }
        }
    }
    else
    {
        for (int j = 0; j < racers.Length; j++)
        {
            if (fuel[j] > 0)
            {
                fuel[j] -= zones[i];
                if (fuel[j] <= 0)
                {
                    fuel[j] = i * -1;
                }
            }
        }
    }
}
for (int i = 0; i < racers.Length; i++)
{
    if (fuel[i] > 0)
    {
        Console.WriteLine($"{racers[i]} - fuel left {fuel[i]:f2}");
    }
    else
    {
        Console.WriteLine($"{racers[i]} - reached {Math.Abs(fuel[i])}");
    }
}