using System.Text.RegularExpressions;

var numbers = Regex
    .Split(Console.ReadLine(), "\\s+")
    .Select(x => int.Parse(x))
    .ToArray();    
string inputLine = Console.ReadLine();
string pattern = $@"\|<.{{{numbers[0]}}}([^|]{{0,{numbers[1]}}})";
Regex regex = new Regex(pattern);
MatchCollection cameraNumbers = regex.Matches(inputLine);
List<string> result = new List<string>();
foreach (Match cameraNumber in cameraNumbers)
{
    result.Add(cameraNumber.Groups[1].Value);
}
Console.WriteLine(string.Join(", ", result)); 