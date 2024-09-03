Dictionary<string, List<string>> storage = new Dictionary<string, List<string>>();
string inputLine = "";
while ((inputLine = Console.ReadLine()) != "Lumpawaroo")
{
    string[] tokens = Array.Empty<string>();

    if (inputLine.Contains(" | "))
    {
        tokens = inputLine
            .Split(new[] { " | " }, StringSplitOptions.RemoveEmptyEntries);

        string forceSide = tokens[0];
        string forceUser = tokens[1];

        bool userExists = false;
        foreach (var side in storage)
        {
            if (side.Value.Contains(forceUser))
            {
                userExists = true;
                break;
            }
        }

        if (userExists)
        {
            continue;
        }

        if (storage.ContainsKey(forceSide) == false)
        {
            storage[forceSide] = new List<string>();
        }

        storage[forceSide].Add(forceUser);
    }

    else if (inputLine.Contains(" -> "))
    {
        tokens = inputLine
            .Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

        string forceSide = tokens[1];
        string forceUser = tokens[0];

        foreach (var side in storage)
        {
            if (side.Value.Contains(forceUser))
            {
                side.Value.Remove(forceUser);
                break;
            }
        }

        if (!storage.ContainsKey(forceSide))
        {
            storage[forceSide] = new List<string>();
        }
        storage[forceSide].Add(forceUser);

        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
    }
}

foreach (var side in storage
    .OrderByDescending(x => x.Value.Count)
    .ThenBy(n => n.Key))
{
    if (side.Value.Count > 0)
    {
        Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
        foreach (var user in side.Value.OrderBy(z => z))
        {
            Console.WriteLine($"! {user}");
        }
    }
}