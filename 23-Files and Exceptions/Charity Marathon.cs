long days = long.Parse(Console.ReadLine());
long runners = long.Parse(Console.ReadLine());
long laps = long.Parse(Console.ReadLine());
long trackLength = long.Parse(Console.ReadLine());
long initialCapacity = long.Parse(Console.ReadLine());
decimal money = decimal.Parse(Console.ReadLine());

long totalCapacity = initialCapacity * days;

if (runners > totalCapacity)
{
    runners = totalCapacity;
}

long totalDistance = runners * laps * trackLength;
long kilometers = totalDistance / 1000;
decimal totalMoney = money * kilometers;
Console.WriteLine($"Money raised: {totalMoney:f2}");