using System.Text.RegularExpressions;

string[] inputLine = Console.ReadLine()
    .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries);
string patternHealth = @"(?<health>[^0-9+\-*\/\.])";
string patternDamage = @"(?<damage>-?\d+(\.\d+)*)";

Dictionary<string, Dictionary<int, double>> demons = new Dictionary<string, Dictionary<int, double>>();

foreach (string demon in inputLine)
{
    int health = 0;
    foreach (Match letter in Regex.Matches(demon, patternHealth))
    {
        health += letter.Value[0];
    }
    double damage = 0.0;

    foreach (Match point in Regex.Matches(demon, patternDamage))
    {
        damage += double.Parse(point.Value);
    }
    var multiplication = demon
        .Where(s => s == '*')
        .ToArray();
    var division = demon
        .Where(s => s == '/')
        .ToArray();

    damage *= Math.Pow(2, multiplication.Length);
    damage /= Math.Pow(2, division.Length);

    if (demons.ContainsKey(demon) == false)
    {
        demons.Add(demon, new Dictionary<int, double>());
    }
    demons[demon].Add(health, damage);
}

foreach (var demon in demons
    .OrderBy(d => d.Key))
{
    foreach (var kvp in demon.Value)
    {
        Console.WriteLine($"{demon.Key} - {kvp.Key} health, {kvp.Value:f2} damage");
    }
}