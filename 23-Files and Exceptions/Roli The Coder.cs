Dictionary<int, Dictionary<string, List<string>>> eventDetails = new Dictionary<int, Dictionary<string, List<string>>>();
while (true)
{
    string inputLine = Console.ReadLine();

    if (inputLine == "Time for Code")
    {
        break;
    }

    if (inputLine.Contains("#"))
    {

        string[] lines = inputLine
            .Split(new char[] { ' ', '#' }, StringSplitOptions.RemoveEmptyEntries);

        int eventID = int.Parse(lines[0]);
        string eventName = lines[1];
        List<string> participants = new List<string>();

        for (int i = 2; i < lines.Length; i++)
        {
            participants.Add(lines[i]);
        }

        if (eventDetails.ContainsKey(eventID) == false)
        {
            eventDetails.Add(eventID, new Dictionary<string, List<string>>());
            eventDetails[eventID].Add(eventName, new List<string>(participants));
        }
        else if (eventDetails[eventID].ContainsKey(eventName))
        {
            eventDetails[eventID][eventName].AddRange(participants);
        }
    }
}
foreach (var eventID in eventDetails
    .OrderByDescending(x => x.Value.Sum(e => e.Value.Distinct().Count()))
    .ThenBy(x => x.Key))
{
    foreach (var eventName in eventID.Value)
    {
        Console.WriteLine($"{eventName.Key} - {eventName.Value.Distinct().Count()}");
        foreach (var participant in eventName.Value
            .Distinct()
            .OrderBy(p => p))
        {
            Console.WriteLine(participant);
        }
    }
}