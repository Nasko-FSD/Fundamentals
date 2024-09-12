﻿int n = int.Parse(Console.ReadLine());

Dictionary<string, long> legionsActivity = new Dictionary<string, long>();
Dictionary<string, Dictionary<string, long>> legionInfo = new Dictionary<string, Dictionary<string, long>>();

while (n-- > 0)
{
    string[] data = Console.ReadLine()
        .Split("=->: "
        .ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

    long lastActivity = long.Parse(data[0]);
    string legionName = data[1];
    string soldierType = data[2];
    long soldierCount = long.Parse(data[3]);

    if (legionInfo.ContainsKey(legionName) == false)
    {
        legionInfo.Add(legionName, new Dictionary<string, long>());
        legionsActivity.Add(legionName, lastActivity);

    }
    if (legionInfo[legionName].ContainsKey(soldierType) == false)
    {
        legionInfo[legionName].Add(soldierType, soldierCount);
    }
    else
    {
        legionInfo[legionName][soldierType] += soldierCount;
    }
    if (legionsActivity[legionName] < lastActivity)
    {
        legionsActivity[legionName] = lastActivity;
    }
}

string command = Console.ReadLine();

if (command.IndexOf('\\') != -1)
{
    int activity = int.Parse(command.Substring(0, command.IndexOf('\\')));
    string soldierType = command.Substring(command.IndexOf("\\") + 1);

    legionInfo.Where(e => legionsActivity[e.Key] < activity &&
        legionInfo[e.Key].ContainsKey(soldierType))
        .OrderByDescending(e => e.Value[soldierType])
        .ToDictionary(x => x.Key, v => v.Value)
        .ToList()
        .ForEach(e =>
        {
            Console.WriteLine($"{e.Key} -> {e.Value[soldierType]}");
        });
}
else
{
    legionsActivity.OrderByDescending(x => x.Value)
        .ToDictionary(x => x.Key, v => v.Value)
        .ToList()
        .ForEach(e =>
    {
        if (legionInfo[e.Key].ContainsKey(command))
        {
            Console.WriteLine($"{e.Value} : {e.Key}");
        }
    });
}