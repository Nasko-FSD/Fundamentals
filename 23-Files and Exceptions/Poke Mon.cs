int power = int.Parse(Console.ReadLine());
int distance = int.Parse(Console.ReadLine());
int exhaustion = int.Parse(Console.ReadLine());
int counter = 0;
double fiftyPercent = power * 0.5;
while (power >= distance)
{
    power -= distance;
    counter++;
    if (power == fiftyPercent)
    {
        try
        {
            power /= exhaustion;
        }
        catch (Exception)
        {
            continue;
        }
    }
}
Console.WriteLine($"{power}");
Console.Write($"{counter}");