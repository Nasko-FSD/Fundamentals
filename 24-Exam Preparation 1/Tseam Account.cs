using System.Text.RegularExpressions;

List<string> inputLine = Console.ReadLine()
    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
    .ToList();
while (inputLine[0] != "Play!")
{
    string[] tokens = Console.ReadLine()
        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    if (tokens[0] == "Play!")
    {
        break;
    }

    if (tokens[0] == "Install" ||
        tokens[0] == "Uninstall" ||
        tokens[0] == "Update")
    {
        bool contains = false;

        if (inputLine.Contains(tokens[1]))
        {
            contains = true;
        }

        if (tokens[0] == "Install" &&
            contains == false)
        {
            inputLine.Add(tokens[1]);
        }

        else if (tokens[0] == "Uninstall" &&
               contains == true)
        {
            inputLine.Remove(tokens[1]);
        }

        else if (tokens[0] == "Update" &&
            contains == true)
        {
            inputLine.Remove(tokens[1]);
            inputLine.Add(tokens[1]);
        }
    }
    else if (tokens[0] == "Expansion")
    {
        Match matchExpansion = Regex.Match(tokens[1], @"((?<=\-)[a-zA-Z]+)");
        Match matchGame = Regex.Match(tokens[1], @"([a-zA-Z]+(?=\-))");
        bool containsGame = false;
        if (inputLine.Contains(matchGame.Value))
        {
            containsGame = true;
        }
        string expansionName = matchExpansion.Groups[1].Value;
        string gameName = matchGame.Groups[1].Value;
        string newGame = gameName + ":" + expansionName;
        for (int i = 0; i < inputLine.Count; i++)
        {
            if (inputLine[i].Contains(gameName))
            {
                inputLine.Insert(i + 1, newGame);
                break;
            }
        }
    }
}
Console.Write(string.Join(" ", inputLine));