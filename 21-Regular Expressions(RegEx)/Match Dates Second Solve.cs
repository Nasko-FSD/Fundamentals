using System.Text.RegularExpressions;

string inputLine = Console.ReadLine();
string regex = @"\b(?<day>\d{2})(-|\.|/)(?<month>[A-Z][a-z]{2})(\1)(?<year>\d{4})\b";
MatchCollection dates = Regex.Matches(inputLine, regex);
foreach (Match date in dates)
{
    var day = date.Groups["day"].Value;
    var month = date.Groups["month"].Value;
    var year = date.Groups["year"].Value;

    Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
}