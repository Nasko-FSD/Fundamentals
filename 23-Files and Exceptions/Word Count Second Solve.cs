using System.Text;
using System.Text.RegularExpressions;

string inputText = File
    .ReadAllText("text.txt")
    .ToLower();

string[] inputWords = File
    .ReadAllText("words.txt")
    .ToLower()
    .Split();

string pattern = @"[A-Za-z][A-Za-z]*";
MatchCollection matches = Regex.Matches(inputText, pattern);

Dictionary<string, int> counts = new Dictionary<string, int>();

foreach (Match match in matches)
{
    foreach (var word in inputWords)
    {
        if (match.Value.Equals(word))
        {
            if (counts.ContainsKey(word) == false)
            {
                counts[word] = 1;
            }
            else
            {
                counts[word]++;
            }
        }
    }
}
var output = new StringBuilder(inputWords.Length);
foreach (var word in counts.OrderByDescending(w => w.Value))
{
    output.AppendLine($"{word.Key} -> {word.Value}");
}
File.WriteAllText("results.txt", output.ToString());