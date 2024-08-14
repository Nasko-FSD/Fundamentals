int power = int.Parse(Console.ReadLine());
int distance = int.Parse(Console.ReadLine());
int exhaustion = int.Parse(Console.ReadLine());
int counter = 0;
double fiftyPercent = power * 0.5;
while (power >= distance)
{
    power -= distance;
    counter++;
    if (power == fiftyPercent &&
        exhaustion > 0)
    {
        power /= exhaustion;
    }
}
Console.WriteLine($"{power}");
Console.Write($"{counter}");