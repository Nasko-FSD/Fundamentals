List<string> drivers = Console.ReadLine()
    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
    .ToList();

List<double> zones = Console.ReadLine()
    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
    .Select(double.Parse)
    .ToList();

List<int> checkpoints = Console.ReadLine()
    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

int reachedZone = 0;

for (int i = 0; i < drivers.Count; i++)
{
    double startingFuel = drivers[i][0];
    bool hasFuel = true;

    for (int z = 0; z < zones.Count; z++)
    {
        if (checkpoints.Contains(z))
        {
            startingFuel += zones[z];
        }
        else
        {
            startingFuel -= zones[z];
        }

        if (startingFuel <= 0)
        {
            reachedZone = z;
            hasFuel = false;
            break;
        }
    }

    if (hasFuel)
    {
        Console.WriteLine($"{drivers[i]} - fuel left {startingFuel:f2}");
    }
    else
    {
        Console.WriteLine($"{drivers[i]} - reached {Math.Abs(reachedZone)}");
    }
}