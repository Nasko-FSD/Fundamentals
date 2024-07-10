using System.Text.RegularExpressions;

string inputLine = Console.ReadLine();
string pattern = @"(^|(?<=\s))-?\d+(.\d+)?($|(?=\s))";
MatchCollection validNumbers = Regex.Matches(inputLine, pattern);
foreach (Match number in validNumbers)
{
    Console.Write(number.Value + " ");
}