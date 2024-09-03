using System.Text.RegularExpressions;

string planetNamePattern = @"(?<=@)[a-zA-Z]+";
List<string> attackName = new List<string>();
List<string> destroyName = new List<string>();
int planetCounterAttack = 0;
int planetCounterDestroyed = 0;

string planetPopulationPattern = @"(?<=:)[0-9]+";
int planetPopulationCount = 0;

string attackTypePattern = @"(?(?=!A!)(!A!)|(!D!))";
string actionType = "";

string soldierCountPattern = @"(?<=->)[0-9]+";
int soldierCount = 0;

List<string> attackedPlanets = new List<string>();

List<string> destroyedPlanets = new List<string>();


int numberOfMesseges = int.Parse(Console.ReadLine());

for (int i = 1; i <= numberOfMesseges; i++)
{
    string inputLine = Console.ReadLine();

    string clearView = string.Empty;
    List<string> decryptedMessage = new List<string>();

    double sum = inputLine.Count(c => "STARstar".Contains(c));

    for (int c = 0; c < inputLine.Length; c++)
    {
        int currentCharValue = inputLine[c] - (int)sum;
        char currentChar = (char)currentCharValue;
        decryptedMessage.Add(currentChar.ToString());
    }

    clearView = string.Join("", decryptedMessage);

    MatchCollection nameMatches = Regex.Matches(clearView, planetNamePattern);

    MatchCollection populationRegex = Regex.Matches(clearView, planetPopulationPattern);
    MatchCollection soldierRegex = Regex.Matches(clearView, soldierCountPattern);

    MatchCollection typeMatches = Regex.Matches(clearView, attackTypePattern);
    foreach (Match match in typeMatches)
    {
        actionType = match.Value.ToString();
    }

    string allPattern = @"@(?<name>[A-Za-z]+)[^@\-!:>]*:(?<population>\d+)[^@\-!:>]*!(?<type>A|D)![^@\-!:>]*->(?<soldierCount>\d+)";
    MatchCollection allMatch = Regex.Matches(clearView, allPattern);

    foreach (Match match in allMatch)
    {
        string clearPattern = string.Join("", match.Value.ToString());

    }
    if (allMatch.Count == 0)
    {
        continue;
    }

    if (actionType == "!A!")
    {
        planetCounterAttack++;

        foreach (Match match in nameMatches)
        {
            attackName.Add(match.Value.ToString());
        }
    }

    if (actionType == "!D!")
    {
        planetCounterDestroyed++;
        {
            foreach (Match match in nameMatches)
            {
                destroyName.Add(match.Value.ToString());
            }
        }
    }
}
attackName = attackName.OrderBy(a => a).ToList();
destroyName = destroyName.OrderBy(a => a).ToList();
Console.WriteLine($"Attacked planets: {planetCounterAttack}");
for (int i = 0; i < planetCounterAttack; i++)
{
    Console.WriteLine($"-> {attackName[i]}");
}
Console.WriteLine($"Destroyed planets: {planetCounterDestroyed}");
for (int i = 0; i < planetCounterDestroyed; i++)
{
    Console.WriteLine($"-> {destroyName[i]}");
}