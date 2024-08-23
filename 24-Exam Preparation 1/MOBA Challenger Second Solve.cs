var players = new Dictionary<string, Dictionary<string, int>>();
string input = "";

while ((input = Console.ReadLine()) != "Season end")
{
    List<string> inputType = new List<string>();

    if (input.Contains("->"))
    {
        inputType = input
            .Split(" -> ")
            .ToList();
    }
    else if (input.Contains("vs"))
    {
        inputType = input
            .Split(" vs ")
            .ToList();
    }

    if (inputType.Count == 3)
    {
        string playerName = inputType[0];
        string position = inputType[1];
        int skill = int.Parse(inputType[2]);

        if (players.ContainsKey(playerName) == false)
        {
            players.Add(playerName, new Dictionary<string, int>());
        }
        if (players[playerName].ContainsKey(position) == false)
        {
            players[playerName].Add(position, skill);
        }
        else
        {
            if (skill > players[playerName][position])
            {
                players[playerName][position] = skill;
            }
        }
    }

    else if (inputType.Count == 2)
    {
        string firstPlayer = inputType[0];
        string secondPlayer = inputType[1];
        
        if (players.ContainsKey(firstPlayer) &&
            players.ContainsKey(secondPlayer))
        {
            string[] firstPlayerPoitions = players[firstPlayer].Keys.ToArray();

            foreach (var pos2 in players[secondPlayer].Keys)
            {
                if (firstPlayerPoitions.Contains(pos2))
                {
                    int totalSkillsFP = players[firstPlayer].Values.Sum();
                    int totalSkillsSP = players[secondPlayer].Values.Sum();

                    if (totalSkillsFP > totalSkillsSP)
                    {
                        players.Remove(secondPlayer);
                        break;
                    }

                    else if (totalSkillsFP < totalSkillsSP)
                    {
                        players.Remove(firstPlayer);
                        break;
                    }
                }
            }
        }
    }
}
foreach (var player in players.OrderByDescending
    (s => s.Value.Values.Sum())
    .ThenBy(n => n.Key))
{
    Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");
    
    foreach (var position in player.Value.OrderByDescending
        (p => p.Value)
        .ThenBy(n => n.Key))
    {
        Console.WriteLine($"- {position.Key} <::> {position.Value}");
    }
}