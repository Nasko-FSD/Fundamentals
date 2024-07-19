using System.Text.RegularExpressions;

string inputLine = Console.ReadLine();
string patter = @"(^|(?<=\s))([a-zA-Z0-9]+)(.|-|_)?([A-Za-z0-9]+)?(@)([a-zA-Z]+([.|-][A-Za-z]+)+)(\b|(?=\s))";
MatchCollection validEmails = Regex.Matches(inputLine, patter);
foreach (Match mail in validEmails)
{
    Console.WriteLine(mail);
}