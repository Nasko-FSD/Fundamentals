using System.Globalization;

TimeSpan time = TimeSpan.ParseExact(Console.ReadLine(), @"hh\:mm\:ss", CultureInfo.InvariantCulture);
int stepsCount = int.Parse(Console.ReadLine()) % 86400;
int secondsPerSteps = int.Parse(Console.ReadLine()) % 86400;

double timeToAdd = stepsCount * secondsPerSteps;

time += TimeSpan.FromSeconds(timeToAdd);

Console.WriteLine($"Time Arrival: {time.ToString(@"hh\:mm\:ss")}");