using System.Text.RegularExpressions;

string inputText = Console.ReadLine();
string regex = @"\b[A-Z][a-z]+\s[A-Z][a-z]+\b";
MatchCollection matchedNames = Regex.Matches(inputText, regex);
foreach (Match name in matchedNames)
{
    Console.Write(name.Value + " ");
}
Console.WriteLine();