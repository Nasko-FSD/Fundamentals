using System.Text;
using System.Text.RegularExpressions;

string[] words = File
    .ReadAllText("words.txt")
    .ToLower()
    .Split();

Dictionary<string, int> counts = words.ToDictionary(x => x, x => 0);
    
string text = File
    .ReadAllText("text.txt")
    .ToLower();

MatchCollection matches = Regex
    .Matches(text, @"[A-Za-z][A-Za-z0-9']*");

foreach (Match match in matches)
{
    if (counts.ContainsKey(match.Value))
    {
        counts[match.Value]++;
    }        
}

var output = new StringBuilder(words.Length);

foreach (var item in counts
    .OrderByDescending(w => w.Value))
{
    output.AppendLine($"{item.Key} -> {item.Value}");
}

File.WriteAllText("results.txt", output.ToString());