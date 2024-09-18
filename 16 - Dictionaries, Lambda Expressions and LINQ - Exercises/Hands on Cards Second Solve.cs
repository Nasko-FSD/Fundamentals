Dictionary<string, List<string>> players = new Dictionary<string, List<string>>();

while (true)
{
    char[] separators = ", ".ToCharArray();
    string[] inputData = Console.ReadLine()
        .Split(":");
    string playerName = inputData[0];

    if (playerName == "JOKER")
    {
        break;
    }

    string[] cards = inputData[1].
        Split(separators, StringSplitOptions.RemoveEmptyEntries);
    cards = cards.Distinct().ToArray();

    if (players.ContainsKey(playerName) == false)
    {
        players.Add(playerName, new List<string>());
    }

    players[playerName].AddRange(cards);
}
Dictionary<string, int> powers = new Dictionary<string, int>();

for (int i = 2; i < 10; i++)
{
    powers.Add(i.ToString(), i);
}
powers.Add("J", 11);
powers.Add("Q", 12);
powers.Add("K", 13);
powers.Add("A", 14);

powers.Add("1", 10);
powers.Add("S", 4);
powers.Add("H", 3);
powers.Add("D", 2);
powers.Add("C", 1);

foreach (var player in players)
{
    List<string> uniqueCards = player.Value.Distinct().ToList();

    int sum = 0;
    foreach (string card in uniqueCards)
    {
        string cardPowerStr = card[0].ToString();
        string cardSuitStr = card[card.Length - 1].ToString();

        int cardPower = powers[cardPowerStr];
        int cardSuit = powers[cardSuitStr];
        sum += cardPower * cardSuit;
    }
    Console.WriteLine($"{player.Key}: {sum}");
}