﻿int n = int.Parse(Console.ReadLine());

Dictionary<string, int> legionActivity = new Dictionary<string, int>();
Dictionary<string, Dictionary<string, long>> legionInfo = new Dictionary<string, Dictionary<string, long>>();

for (int i = 0; i < n; i++)
{
    string[] tokens = Console.ReadLine()
        .Split(new[] { " = ", " -> ", ":" },StringSplitOptions.RemoveEmptyEntries);

    int lastActivity = int.Parse(tokens[0]);
    string legionName = tokens[1];
    string soldierType = tokens[2];
    long soldierCount = long.Parse(tokens[3]);

    if (legionInfo.ContainsKey(legionName) == false)
    {
        legionInfo.Add(legionName, new Dictionary<string, long>());
        legionActivity.Add(legionName, lastActivity);
    }
    if (legionInfo[legionName].ContainsKey(soldierType) == false)
    {
        legionInfo[legionName].Add(soldierType, soldierCount);
    }
    else
    {
        legionInfo[legionName][soldierType] += soldierCount;
    }
    if (legionActivity[legionName] < lastActivity)
    {
        legionActivity[legionName] = lastActivity;
    }
}
string command = Console.ReadLine();

if (command.Contains(@"\"))
{
    string[] tokens = command
        .Split(new[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
    int activity = int.Parse(tokens[0]);
    string soldierType = tokens[1];

    foreach (var legion in legionInfo
        .Where(s => legionInfo[s.Key].ContainsKey(soldierType))
        .OrderByDescending(c => c.Value[soldierType])
        .Where(a => legionActivity[a.Key] < activity))
    {
        Console.WriteLine($"{legion.Key} -> {legion.Value[soldierType]}");
    }
}
else
{
    foreach (var legion in legionInfo
        .Where(s => legionInfo[s.Key].ContainsKey(command))
        .OrderByDescending(c => legionActivity[c.Key]))
    {
        Console.WriteLine($"{legionActivity[legion.Key]} : {legion.Key}");
    }
}