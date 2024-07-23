using System.Text.RegularExpressions;
 
Regex regex = new Regex(@"(?<key>[^\=&\?]+)=(?<value>[^\=&\?]+)");
while (true)
{
    string inputLine = Console.ReadLine();
    if (inputLine == "END")
    {
        break;
    }
    MatchCollection matches = regex.Matches(inputLine);
    Dictionary<string, List<string>> keys = new Dictionary<string, List<string>>();
    foreach (Match match in matches)
    {
        string key = match.Groups["key"].Value;
        string value = match.Groups["value"].Value;
        key = Regex.Replace(key, @"(%20|\+)+", " ").Trim();
        value = Regex.Replace(value, @"(%20|\+)+", " ").Trim();

        if (keys.ContainsKey(key) == false)
        {
            keys.Add(key, new List<string>());
        }
        keys[key].Add(value);
    }
    foreach (var pair in keys)
    {
        Console.Write($"{pair.Key}=[{string.Join(", ", pair.Value)}]");
    }
    Console.WriteLine();
}