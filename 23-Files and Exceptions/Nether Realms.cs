using System.Text.RegularExpressions;

string patternHealth = @"[^0-9+\-*\/\.]";
string patternDamage = @"(-)?\d+(\.\d+)*";
string[] demons = Console.ReadLine()
    .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries);

List<string> sortedDemons = new List<string>();

foreach (var demon in demons)
{
    int totalHP = 0;

    foreach (Match match in Regex.Matches(demon, patternHealth))
    {
        if (match.Success)
        {
            totalHP += match.Value[0];
        }
    }

    double totalDM = 0;

    foreach (Match number in Regex.Matches(demon, patternDamage))
    {
        if (number.Success)
        {
            totalDM += double.Parse(number.Value);
        }
    }

    var multiplication = demon
        .Where(x => x == '*')
        .ToArray();
    var division = demon
        .Where(x => x == '/')
        .ToArray();

    totalDM *= Math.Pow(2, multiplication.Length);
    totalDM /= Math.Pow(2, division.Length);

    string result = $"{demon} - {totalHP} health, {totalDM:f2} damage ";
    sortedDemons.Add(result);
}

sortedDemons = sortedDemons
    .OrderBy(x => x)
    .ToList();

foreach (var demon in sortedDemons)
{
    Console.WriteLine(demon);
}