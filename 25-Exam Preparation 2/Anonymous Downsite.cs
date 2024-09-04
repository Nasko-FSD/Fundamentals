using System.Numerics;

int hackedSites = int.Parse(Console.ReadLine());
int key = int.Parse(Console.ReadLine());
decimal siteLoss = 0;

if (hackedSites > 0)
{
    for (int i = 0; i < hackedSites; i++)
    {
        string[] inputLine = Console.ReadLine()
            .Split(' ')
            .ToArray();

        string name = inputLine[0];
        long visits = long.Parse(inputLine[1]);
        decimal price = decimal.Parse(inputLine[2]);
        siteLoss += visits * price;

        Console.WriteLine(name);
    }
    BigInteger securityToken = BigInteger.Pow(key, hackedSites);

    Console.WriteLine($"Total Loss: {siteLoss.ToString("f20")}");
    Console.WriteLine($"Security Token: {securityToken}");
}