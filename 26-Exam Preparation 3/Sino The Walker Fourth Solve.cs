string input = Console.ReadLine();
int stepsCount = int.Parse(Console.ReadLine()) % 86400;
int secondsPerStep = int.Parse(Console.ReadLine()) % 86400;

DateTime d = DateTime.Parse(input);
TimeSpan duration = TimeSpan.FromSeconds(secondsPerStep * stepsCount);

TimeSpan ts = d.TimeOfDay.Add(duration);
Console.WriteLine("Time Arrival: {0:D2}:{1:D2}:{2:D2}", ts.Hours, ts.Minutes, ts.Seconds);