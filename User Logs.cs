SortedDictionary<string, Dictionary<string, Dictionary<string, int>>> userLogs = new SortedDictionary<string, Dictionary<string, Dictionary<string, int>>>();
char[] separators = "=".ToCharArray();

while (true)
{
    string[] inputData = Console.ReadLine()
        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    if (inputData[0] == "end")
    {
        break;
    }

    string ipAddress = inputData[0].Split(separators)[1];
    string userName = inputData[2].Split(separators)[1];
    string messages = inputData[1].Split(separators)[1];

    if (userLogs.ContainsKey(userName) == false)
    {
        userLogs.Add(userName, new Dictionary<string, Dictionary<string, int>>());
    }
    if (userLogs[userName].ContainsKey(ipAddress) == false)
    {
        userLogs[userName].Add(ipAddress, new Dictionary<string, int>());
    }
    if (userLogs[userName][ipAddress].ContainsKey(messages) == false)
    {
        userLogs[userName][ipAddress].Add(messages, 0);
    }
    userLogs[userName][ipAddress][messages]++;
}
foreach (var user in userLogs)
{
    Console.WriteLine($"{user.Key}: ");
    int i = 1;
    int totalIPs = user.Value.Count;
    foreach (var ip in user.Value)
    {
        int messagesCount = ip.Value.Values.Sum();
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