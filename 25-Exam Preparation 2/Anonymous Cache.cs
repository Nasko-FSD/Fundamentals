using System.Text.RegularExpressions;

string setAndKeyPattern = @"([^\,\-\>\|]+)";

Dictionary<string, Dictionary<string, long>> collectedData = new Dictionary<string, Dictionary<string, long>>();
Dictionary<string, Dictionary<string, long>> cachedData = new Dictionary<string, Dictionary<string, long>>();

List<string> allSets = new List<string>();

string inputLine = "";

List<string> keys = new List<string>();
string dataSet = "";
long Size = 0;
string Key = "";
while ((inputLine = Console.ReadLine()) != "thetinggoesskrra")
{
    MatchCollection matched = Regex.Matches(inputLine, setAndKeyPattern);

    if (matched.Count == 1)
    {
        foreach (Match match in matched)
        {
            dataSet = match.Value.ToString();
            allSets.Add(match.Value);
        }
    }

    if (matched.Count > 1)
    {
        string[] tokens = inputLine
            .Split(new[] { " -> ", " | " }, StringSplitOptions.RemoveEmptyEntries);

        dataSet = tokens[2];
        Key = tokens[0];
        Size = long.Parse(tokens[1]);

        if (allSets.Contains(dataSet))
        {
            if (collectedData.ContainsKey(dataSet) == false)
            {
                collectedData.Add(dataSet, new Dictionary<string, long>());
                collectedData[dataSet].Add(Key, Size);
                keys.Add(Key);
            }
            else
            {
                collectedData[dataSet].Add(Key, Size);
            }
        }
        else
        {
            if (cachedData.ContainsKey(dataSet) == false)
            {
                cachedData.Add(dataSet, new Dictionary<string, long>());
                cachedData[dataSet].Add(Key, Size);
            }
            else
            {
                cachedData[dataSet].Add(Key, Size);
            }
        }
    }
}
foreach (var set in cachedData.Keys)
{
    if (allSets.Contains(set) &&
        collectedData.Keys.Contains(set) == false)
    {
        collectedData.Add(set, new Dictionary<string, long>());

        foreach (var kvp in cachedData[set])
        {
            collectedData[set].Add(kvp.Key, kvp.Value);
            keys.Add(kvp.Key);
        }
    }
}
if (keys.Count > 0)
{
    var largestData = collectedData
        .OrderByDescending(v => v.Value.Values.Sum())
        .First();

    string dataSets = largestData.Key;
    long totalSum = largestData.Value.Values.Sum();

    Console.WriteLine($"Data Set: {dataSets}, Total Size: {totalSum}");

    List<string> allKeys = largestData.Value.Keys.ToList();
    for (int i = 0; i < allKeys.Count; i++)
    {
        Console.WriteLine($"$.{allKeys[i]}");
    }
}