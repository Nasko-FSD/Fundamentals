int[] time = Console.ReadLine()
    .Split(':')
    .Select(int.Parse)
    .ToArray();
int stepsCount = int.Parse(Console.ReadLine()) % 86400;
int sedondPerStep = int.Parse(Console.ReadLine()) % 86400;

int timeToAdd = stepsCount * sedondPerStep;

time[2] += timeToAdd;

for (int i = time.Length - 1; i > 0; i--)
{
    if (time[i] >= 60)
    {
        time[i] -= 60;
        time[i - 1] += 1;
        i++;
    }
    if (time[0] > 23)
    {
        time[0] = 0;
    }
}
Console.WriteLine($"Time Arrival: {time[0]:d2}:{time[1]:d2}:{time[2]:d2}");