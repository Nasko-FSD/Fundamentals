using System.Text;
using System.Text.RegularExpressions;

int n = int.Parse(Console.ReadLine());
Regex starRegex = new Regex(@"[sStTaArR]");
Regex messageRegex = new Regex(@"@(?<name>[A-Za-z]+)[^@\-!:>]*:(?<population>\d+)[^@\-!:>]*!(?<type>A|D)![^@\-!:>]*->(?<soldierCount>\d+)");
List<string> attacked = new List<string>();
List<string> destroyed = new List<string>();

for  (int i = 0; i < n; i++)
{
    string line = Console.ReadLine();
    MatchCollection starMatches = starRegex.Matches(line);
    int step = starMatches.Count;
    StringBuilder decryptedMessage = new StringBuilder();

    for (int j = 0; j < line.Length; j++)
    {
        char current = (char)(line[j] - step);
        decryptedMessage.Append(current);
    }

    if (messageRegex.IsMatch(decryptedMessage.ToString()))
    {
        Match match = messageRegex.Match(decryptedMessage.ToString());
         string type = match.Groups["type"].Value;
        string name = match.Groups["name"].Value;

        if (type == "A")
        {
            attacked.Add(name);
        }
        else
        {
            destroyed.Add(name);
        }
    }
}
Console.WriteLine($"Attacked planets: {attacked.Count}");

foreach (string planet in attacked.OrderBy(x => x))
{
    Console.WriteLine($"-> {planet}");
}

Console.WriteLine($"Destroyed planets: {destroyed.Count}");

foreach (string planet in destroyed.OrderBy(x => x))
{
    Console.WriteLine($"-> {planet}");
}