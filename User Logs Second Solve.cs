SortedDictionary<string, Dictionary<string, Dictionary<string, int>>> userLogs = new SortedDictionary<string, Dictionary<string, Dictionary<string, int>>>();
char[] separators = "=".ToCharArray();
while (true)
{
    List<string> inputData = Console.ReadLine()
        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
        .ToList();

    if (inputData[0] == "end")
    {
        break;
    }

    string ipAddress = inputData[0].Split(separators)[1];
    string message = inputData[1].Split(separators)[1];
    string userName = inputData[2].Split(separators)[1];

    if (userLogs.ContainsKey(userName) == false)
    {
        userLogs.Add(userName, new Dictionary<string, Dictionary<string, int>>());
    }
    if (userLogs[userName].ContainsKey(ipAddress) == false)
    {
        userLogs[userName].Add(ipAddress, new Dictionary<string, int>());
    }
    if (userLogs[userName][ipAddress].ContainsKey(message) == false)
    {
        userLogs[userName][ipAddress].Add(message, 0);
    }
    userLogs[userName][ipAddress][message]++;
}
foreach (var user in userLogs)
{
    Console.WriteLine($"{user.Key}: ");
    int i = 1;
    int totalIPs = user.Value.Count;
    foreach (var ip in user.Value)
    {
        int messagesCount = 0;
        foreach (var message in ip.Value.Values) 
        {
            messagesCount += message;
        }
        if (i == totalIPs)
        {
            Console.WriteLine($"{ip.Key} => {messagesCount}.");
        }
        else
        {
            Console.Write($"{ip.Key} => {messagesCount}, ");
        }
        i++;
    }
}