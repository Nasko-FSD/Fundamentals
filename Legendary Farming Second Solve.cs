Dictionary<string, int> validItems = new Dictionary<string, int>();
validItems.Add("shards", 0);
validItems.Add("fragments", 0);
validItems.Add("motes", 0);

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
                    case "fragments":
                        Console.WriteLine("Valanyr obtained!");
                        break;
                    case "motes":
                        Console.WriteLine("Dragonwrath obtained!");
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
validItems = validItems
    .OrderByDescending(i => i.Value)
    .ThenBy(i => i.Key)
    .ToDictionary(x => x.Key, x => x.Value);
foreach (var item in validItems)
{
    Console.WriteLine($"{item.Key}: {item.Value}");
}
foreach (var item in junkItems)
{
    Console.WriteLine($"{item.Key}: {item.Value}");
}