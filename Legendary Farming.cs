Dictionary<string, int> validItems = new Dictionary<string, int>();

validItems.Add("shards", 0);
validItems.Add("motes", 0);
validItems.Add("fragments", 0);

SortedDictionary<string, int> junkItems = new SortedDictionary<string, int>();

bool isRunning = true;

while (isRunning)
{
    string[] inputData = Console.ReadLine()
        .ToLower()
        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    for (int i = 0; i < inputData.Length - 1; i += 2)
    {
        int quantity = int.Parse(inputData[i]);
        string item = inputData[i + 1];

        if (validItems.ContainsKey(item))
        {
            validItems[item] += quantity;
            if (validItems[item] >= 250)
            {
                validItems[item] -= 250;
                isRunning = false;

                switch (item)
                {
                    case "shards":
                        Console.WriteLine("Shadowmourne obtained!");
                        break;
                    case "motes":
                        Console.WriteLine("Dragonwrath obtained!");
                        break;
                    case "fragments":
                        Console.WriteLine("Valanyr obtained!");
                        break;
                }
                break;
            }
        }
        else
        {
            if (junkItems.ContainsKey(item))
            {
                junkItems[item] += quantity;
            }
            else
            {
                junkItems.Add(item, quantity);
            }
        }
    }
}
Dictionary<string, int> sortedItems = validItems
    .OrderByDescending(i => i.Value)
    .ThenBy(i => i.Key)
    .ToDictionary(x => x.Key, x => x.Value);
foreach (var sortedItem in sortedItems)
{
    Console.WriteLine($"{sortedItem.Key}: {sortedItem.Value}");
}
foreach (var junkItem in junkItems)
{
    Console.WriteLine($"{junkItem.Key}: {junkItem.Value}");
}