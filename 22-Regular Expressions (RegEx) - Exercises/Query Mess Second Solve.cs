using System.Text.RegularExpressions;

var firstPattern = @"([^&=?]*)=([^&=]*)";
var seconPatter = @"((%20|\+)+)";


while (true)
{
    string inputLine = Console.ReadLine();
    if (inputLine == "END")
    {
        break;
    }
    var pairs = new Regex(firstPattern);
    var matches = pairs.Matches(inputLine);
    var results = new Dictionary<string, List<string>>();

    for (int i = 0; i < matches.Count; i++)
    {
        var field = matches[i].Groups[1].Value;
        field = Regex.Replace(field, seconPatter, word => " ").Trim();

        var value = matches[i].Groups[2].Value;
        value = Regex.Replace(value, seconPatter, word => " ").Trim();

        if (results.ContainsKey(field) == false)
        {
            results.Add(field, new List<string>());
        }

        results[field].Add(value);
    }

    foreach (var pair in results)
    {
        Console.Write($"{pair.Key}=[{string.Join(", ", pair.Value)}]");
    }

    Console.WriteLine();
}