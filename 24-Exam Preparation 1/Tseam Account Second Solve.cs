List<string> games = Console.ReadLine()
    .Split(" ")
    .ToList();
string input = "";

while ((input = Console.ReadLine()) != "Play!")
{
    input.Split(" ").ToArray();
    string[] commands = input.Split(" ").ToArray();
    string command = commands[0];
    string game = commands[1];

    if (command == "Install")
    {
        if (games.Contains(game) == false)
        {
            games.Add(game);
        }
    }

    else if (command == "Uninstall")
    {
        games.Remove(game);
    }

    else if (command == "Update")
    {
        if (games.Contains(game))
        {
            games.Remove(game);
            games.Add(game);
        }
    }

    else if (command == "Expansion")
    {
        string[] expansion = game.Split("-");
        int index = games.IndexOf(expansion[0]);
        if (games.Contains(expansion[0]))
        {
            games.Insert(index + 1, string.Join(":", expansion));
        }
    }
}
Console.WriteLine(string.Join(" ", games));