using System.Text.RegularExpressions;

string inputLine = Console.ReadLine();
string pattern = @"(^| )\+359{1}(-| ){1}2{1}(\2)\d{3}(\2)\d{4}\b";
MatchCollection validNumbers = Regex.Matches(inputLine, pattern);
var matchedNums = validNumbers
    .Cast<Match>()
    .Select(a => a.Value.Trim()).ToArray();
Console.WriteLine(string.Join(", ", matchedNums));