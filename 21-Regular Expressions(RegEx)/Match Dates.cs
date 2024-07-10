using System.Text.RegularExpressions;

string inputLine = Console.ReadLine();
string regex = @"\b(\d{2})([-|.|/])([A-Z][a-z]{2})(\2)(\d{4})\b";
MatchCollection dates = Regex.Matches(inputLine, regex);
foreach (Match date in dates)
{
    var day = date.Groups[1].Value;
    var month = date.Groups[3].Value;
    var year = date.Groups[5].Value;

    Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
}