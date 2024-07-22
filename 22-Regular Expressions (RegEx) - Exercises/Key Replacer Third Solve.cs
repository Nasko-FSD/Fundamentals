using System.Text.RegularExpressions;

string keys = Console.ReadLine();
string pattern = @"(^([A-Za-z]+)(?=[<|\\|\|]))|((?<=[<|\\|\|])([A-Za-z]+)$)";
MatchCollection allKeys = Regex.Matches(keys, pattern);
string firstKey = allKeys[0].Value;
string secondKey = allKeys[1].Value;
string textInput = Console.ReadLine();
string secondPattern = $@"(?<={Regex.Escape(firstKey)})(.*?)(?={Regex.Escape(secondKey)})";
MatchCollection validText = Regex.Matches(textInput, secondPattern);
bool foundValidText = false;
foreach (Match match in validText)
{
    if (match.Length > 1)
    {
        Console.Write(string.Join("", match.Groups[1].Value));
        foundValidText = true;
    }
}
if (foundValidText == false)
{
    Console.WriteLine("Empty result");
}