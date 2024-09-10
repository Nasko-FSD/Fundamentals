Dictionary<string, Dictionary<string, long>> mainSet = new Dictionary<string, Dictionary<string, long>>();
Dictionary<string, Dictionary<string, long>> cache = new Dictionary<string, Dictionary<string, long>>();

string input = Console.ReadLine();

while (input != "thetinggoesskrra")
{
    string[] splitData = input
        .Split(new char[] { ' ', '-', '>', '|' }, StringSplitOptions.RemoveEmptyEntries);

    if (splitData.Length != 1)
    {
        string key = splitData[0];
        long size = long.Parse(splitData[1]);
        string set = splitData[2];

        if (mainSet.ContainsKey(set) == false)
        {
            if (cache.ContainsKey(set) == false)
            {
                cache.Add(set, new Dictionary<string, long>());
            }

            if (cache[set].ContainsKey(key) == false)
            {
                cache[set].Add(key, 0);
            }
            cache[set][key] += size;
        }
        else
        {
            mainSet[set].Add(key, size);
        }

    }
    else
    {
        string set = splitData[0];

        if (mainSet.ContainsKey(set) == false)
        {
            mainSet.Add(set, new Dictionary<string, long>());
        }
        if (cache.ContainsKey(set))
        {
            mainSet[set] = cache[set]; 
        }
    }

    input = Console.ReadLine();
}
if (mainSet.Count > 0)
{
    KeyValuePair<string, Dictionary<string, long>> highestSet = mainSet.OrderByDescending(x => x.Value.Values.Sum()).First();

    Console.WriteLine($"Data Set: {highestSet.Key}, Total Size: {highestSet.Value.Values.Sum()}");

    foreach (var kvp in highestSet.Value)
    {
        Console.WriteLine($"$.{kvp.Key}");
    }
}