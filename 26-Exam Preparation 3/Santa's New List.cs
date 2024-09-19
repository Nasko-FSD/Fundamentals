Dictionary<string, Dictionary<string, long>> childernList = new Dictionary<string, Dictionary<string, long>>();
Dictionary<string, long> toysCollection = new Dictionary<string, long>();
string input = "";

while ((input = Console.ReadLine()) != "END")
{
    string[] tokens = input
        .Split(new[] { "->" }, StringSplitOptions.RemoveEmptyEntries);

    if (tokens.Length > 2)
    {
        string childName = tokens[0];
        string typeOfPresent = tokens[1];
        long amount = long.Parse(tokens[2]);
        if (childernList.ContainsKey(childName) == false)
        {
            childernList.Add(childName, new Dictionary<string, long>());
            childernList[childName].Add(typeOfPresent, amount);
        }
        if (childernList[childName].ContainsKey(typeOfPresent) == false)
        {
            childernList[childName].Add(typeOfPresent, amount);

        }
        if (toysCollection.ContainsKey(typeOfPresent) == false)
        {
            toysCollection.Add(typeOfPresent, amount);
        }        
        else
        {
            toysCollection[typeOfPresent] += amount;
        }
    }
    else
    {
        string childName = tokens[1];
        if (childernList.ContainsKey(childName))
        {
            foreach (var child in childernList.Keys)
            {
                if (child == childName)
                {
                    childernList.Remove(child);
                }
            }
        }
    }
}
    Console.WriteLine("Children:");
foreach (var child in childernList
    .OrderByDescending(t => t.Value.Sum(k => k.Value))
    .ThenBy(n => n.Key))
{
        Console.WriteLine($"{child.Key} -> {child.Value.Values.Sum()}");
}
    Console.WriteLine("Presents:");
foreach (var toy in toysCollection)
{
    Console.WriteLine($"{toy.Key} -> {toy.Value}");
}