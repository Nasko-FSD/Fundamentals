int n = int.Parse(Console.ReadLine());

Dictionary<string, int> legionActivity = new Dictionary<string, int>();

Dictionary<string, Dictionary<string, long>> legionInfo = new Dictionary<string, Dictionary<string, long>>();


for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine()
        .Split(new[] { " = ", " -> ", ":" }, StringSplitOptions.RemoveEmptyEntries);

    int activity = int.Parse(input[0]);
    string legionName = input[1];
    string soldierType = input[2];
    long soldierCount = long.Parse(input[3]);

    if (legionActivity.ContainsKey(legionName) == false)
    {
        legionInfo.Add(legionName, new Dictionary<string, long>());
        legionActivity.Add(legionName, activity);
    }
    if (legionInfo[legionName].ContainsKey(soldierType) == false)
    {
        legionInfo[legionName].Add(soldierType, soldierCount);
    }
    else
    {
        legionInfo[legionName][soldierType] += soldierCount;
    }
    if (legionActivity[legionName] < activity)
    {
        legionActivity[legionName] = activity;
    }

}
string command = Console.ReadLine();

if (command.Contains(@"\"))
{
    string[] tokens = command
        .Split('\\');

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
    foreach (var legion in legionActivity
       .OrderByDescending(s => s.Value))
    {
        if (legionInfo[legion.Key].ContainsKey(command))
        {
            Console.WriteLine($"{legion.Value} : {legion.Key}");
        }
    }
}