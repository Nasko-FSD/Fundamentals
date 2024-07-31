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

foreach (string word in inputWords)
{
    counts[word] = 0;
}

foreach (Match word in matches)
{
    if (counts.ContainsKey(word.Value))
    {
        counts[word.Value]++;
    }
}

var output = new StringBuilder(inputWords.Length);
foreach (var word in counts.OrderByDescending(w => w.Value))
{
    output.AppendLine($"{word.Key} -> {word.Value}");
}
File.WriteAllText("results.txt", output.ToString());