using System.Text.RegularExpressions;

string[] inputLine = Console.ReadLine()
    .Split(new char[] { ' ', '/', '\\', '(', ')' }, StringSplitOptions.RemoveEmptyEntries)
    .ToArray();
string pattern = @"\b((^[A-Za-z])\w{2,24})\b";
MatchCollection validNames;
List<string> validValues = new List<string>();
foreach (string line in inputLine)
{
    validNames = Regex.Matches(line, pattern);
    if (validNames.Count > 0)
    {
        validValues.Add(validNames
            .First()
            .Value
            .ToString());
    }
}
string firstUserName = "";
string secondUserName = "";
int sum = 0;
int totalSum = 0;
for (int i = 0; i < validValues.Count - 1; i++)
{
    sum = validValues[i].Length + validValues[i + 1].Length;
    if (sum > totalSum)
    {
        totalSum = sum;
        firstUserName = validValues[i];
        secondUserName = validValues[i + 1];
    }
}
Console.WriteLine(firstUserName);
Console.WriteLine(secondUserName);