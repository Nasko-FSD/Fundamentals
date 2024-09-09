using System.Text.RegularExpressions;

string input = Console.ReadLine();
string[] values = Console.ReadLine().Split(new[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries);
List<string> strList = new List<string>();

string pattern = @"(?<start>[A-Za-z]+)(?<placeholder>.+)\1";
MatchCollection matches = Regex.Matches(input, pattern);
foreach (Match match in matches)
{
    string placeholder = match.Groups["placeholder"].Value;
    strList.Add(placeholder);
}
int end = Math.Min(values.Length, strList.Count);

for (int i = 0; i < end; i++)
{
    input = ReplaceFirstOccurance(input, strList[i], values[i]);
}

Console.WriteLine(input);

static string ReplaceFirstOccurance(string input, string match, string replace)
{
    int index = input.IndexOf(match);
    input = input.Remove(index, match.Length);
    input = input.Insert(index, replace);
    return input;
}