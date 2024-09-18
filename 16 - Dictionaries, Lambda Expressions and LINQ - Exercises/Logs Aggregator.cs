SortedDictionary<string, int> totalTime = new SortedDictionary<string, int>();
Dictionary<string, Dictionary<string, int>> logsAggregator = new Dictionary<string, Dictionary<string, int>>();

int linesOfCode = int.Parse(Console.ReadLine());

for (int i = 0; i < linesOfCode; i++)
{
    string[] inputData = Console.ReadLine()
        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

    string userName = inputData[1];
    string ipAddress = inputData[0];
    int time = int.Parse(inputData[2]);

    if (totalTime.ContainsKey(userName) == false)
    {
        totalTime.Add(userName, 0);
        logsAggregator.Add(userName, new Dictionary<string, int>());
    }
    if (logsAggregator[userName].ContainsKey(ipAddress) == false)
    {
        logsAggregator[userName].Add(ipAddress, 0);
    }
    totalTime[userName] += time;
    logsAggregator[userName][ipAddress] += time;
}
foreach (var user in totalTime.OrderBy(u => u.Key))
{
    Console.Write($"{user.Key}: {user.Value} ");

    Dictionary<string, int> totalIpAddresses = logsAggregator[user.Key]
        .OrderBy(x => x.Key)
        .ToDictionary(x => x.Key, x => x.Value);

    Console.WriteLine($"[{string.Join(", ", totalIpAddresses.Keys)}]");
}