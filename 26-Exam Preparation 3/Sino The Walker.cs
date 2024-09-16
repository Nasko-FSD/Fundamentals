using System.Globalization;

var leaves = DateTime.ParseExact(Console.ReadLine()
    ,"HH:mm:ss", CultureInfo.InvariantCulture);
long steps = long.Parse(Console.ReadLine()) % 86400;
long timeS = long.Parse(Console.ReadLine()) % 86400;

long walkingTime = steps * timeS;

DateTime walking = leaves.AddSeconds(walkingTime);

Console.WriteLine($"Time Arrival: {walking:HH:mm:ss}");