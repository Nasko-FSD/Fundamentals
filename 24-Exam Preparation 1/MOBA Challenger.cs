Dictionary<string, Dictionary<string, int>> playerInfo = new Dictionary<string, Dictionary<string, int>>();
string inputLine = "";
while ((inputLine = Console.ReadLine()) != "Season end")
{
    string[] tokensAdd = Array.Empty<string>();
    if (inputLine.Contains(" -> "))
    {
        tokensAdd = inputLine
            .Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
    }
    string[] tokensFight = Array.Empty<string>();
    if (inputLine.Contains(" vs "))
    {
        tokensFight = inputLine
            .Split(new[] { " vs " }, StringSplitOptions.RemoveEmptyEntries);
    }

    if (tokensAdd.Length > 0)
    {
        string playerName = tokensAdd[0];
        string playerPosition = tokensAdd[1];
        int skill = int.Parse(tokensAdd[2]);
        if (playerInfo.ContainsKey(playerName) == false)
        {
            playerInfo.Add(playerName, new Dictionary<string, int>());
        }
        if (playerInfo[playerName].ContainsKey(playerPosition) == false)
        {
            playerInfo[playerName].Add(playerPosition, skill);
        }
        if (playerInfo[playerName].ContainsKey(playerPosition))
        {
            if (playerInfo[playerName][playerPosition] < skill)
            {
                playerInfo[playerName][playerPosition] = skill;
            }
        }
    }
    if (tokensFight.Length > 0)
    {
        string playerOne = tokensFight[0];
        string playerTwo = tokensFight[1];

        if (playerInfo.ContainsKey(playerOne) &&
            playerInfo.ContainsKey(playerTwo))
        {

            foreach (var position in playerInfo[playerOne].Keys)
            {
                if (playerInfo[playerTwo].ContainsKey(position)) 
                {
                    if (playerInfo[playerOne][position] >
                        playerInfo[playerTwo][position])
                    {
                        playerInfo.Remove(playerTwo);
                    }
                    else if (playerInfo[playerOne][position] <
                        playerInfo[playerTwo][position])
                    {
                        playerInfo.Remove(playerOne);
                    }
                    break;
                }
            }
        }
    }
}
foreach (var player in playerInfo.OrderByDescending(p => p.Value.Values.Sum()).ThenBy(p => p.Key))
{
    int totalSkills = player.Value.Values.Sum();
    Console.WriteLine($"{player.Key}: {totalSkills} skill");

    foreach (var position in player.Value.OrderByDescending(p => p.Value).ThenBy(p => p.Key))
    {
        Console.WriteLine($"- {position.Key} <::> {position.Value}");
    }
}