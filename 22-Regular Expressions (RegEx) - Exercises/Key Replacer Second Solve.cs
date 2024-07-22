using System.Text.RegularExpressions;

string keys = Console.ReadLine();
string pattern = @"(^([A-Za-z]+)(?=[<|\\|\|]))|((?<=[<|\\|\|])([A-Za-z]+)$)";
MatchCollection allKeys = Regex.Matches(keys, pattern);
string firstKey = allKeys[0].Value;
string secondKey = allKeys[1].Value;
string textInput = Console.ReadLine();
string secondPattern = $@"{firstKey}(?!{secondKey})(.*?){secondKey}";
MatchCollection validText = Regex.Matches(textInput, secondPattern);
if (validText.Count > 0)
{
    foreach (Match match in validText)
    {
        if (match.Length > 1)
        {
            Console.Write(string.Join("", match.Groups[1].Value));
        }
    }
}
else
{
    Console.WriteLine("Empty result");
}