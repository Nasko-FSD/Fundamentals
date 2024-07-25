using System.Text.RegularExpressions;

Regex regex = new Regex(@"\|<(?<picture>\w+)");
int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int skipNumber = numbers[0];
int takeNumber = numbers[1];

string inputLine = Console.ReadLine();
MatchCollection matches = regex.Matches(inputLine);

string[] allResults = new string[matches.Count];
int index = 0;
foreach (Match match in matches)
{
    string currentMatch = match.Groups["picture"].Value;

    char[] resultChars = currentMatch.Skip(skipNumber)
        .Take(takeNumber)
        .ToArray();

    string currentRresult = string.Join("", resultChars);
    allResults[index++] = currentRresult;
}
Console.WriteLine(string.Join(", ", allResults));