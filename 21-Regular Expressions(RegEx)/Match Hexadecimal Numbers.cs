using System.Text.RegularExpressions;

string inputLine = Console.ReadLine();
string pattern = @"\b(0x|[0-9A-F])+\b";
MatchCollection validHexa = Regex.Matches(inputLine, pattern);
var hexaDecimals = Regex.Matches(inputLine, pattern)
    .Cast<Match>()
    .Select(m => m.Value)
    .ToArray();
Console.WriteLine(string.Join(" ", hexaDecimals));