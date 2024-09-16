List<string> participant = Console.ReadLine()
    .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
    .ToList();
List<string> songs = Console.ReadLine()
    .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
    .ToList();

Dictionary<string, List<string>> stageInfo = new Dictionary<string, List<string>>();

string inputLine = "";
while ((inputLine = Console.ReadLine()) != "dawn")
{
    string[] tokens = inputLine
        .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
    string performer = tokens[0];
    string songName = tokens[1].Trim();
    string award = tokens[2].Trim();

    if (participant.Contains(performer) &&
        songs.Contains(songName))
    {
        if (stageInfo.ContainsKey(performer) == false)
        {
            stageInfo.Add(performer, new List<string>());
        }
        if (stageInfo[performer].Contains(award) == false)
        {
            stageInfo[performer].Add(award);
        }
    }
}
if (stageInfo.Values.Count > 0)
{
    foreach (var performer in stageInfo.OrderByDescending(a => a.Value.Count)
        .ThenBy(n => n.Key))
    {
        Console.WriteLine($"{performer.Key}: {performer.Value.Count} awards");
        
        foreach (var award in performer.Value
            .OrderBy(z => z))
        {
            Console.WriteLine($"--{award}");
        }
    }
}
else
{
    Console.WriteLine("No awards");
}