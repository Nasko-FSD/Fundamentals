using System.Text.RegularExpressions;

string surfacePattern = @"[^a-zA-Z0-9]+";
string mantlePattern = @"[_\d]+";
string corePattern = @"[a-zA-Z]+";

bool isFine = true;
int coreLength = -1;
string currentPattern = "";
for (int i = 0; i < 5; i++)
{
    string inputLIne = Console.ReadLine();
    if (i == 0 || i == 4)
    {
        currentPattern = surfacePattern;
    }
    else if (i == 1 || i == 3)
    {
        currentPattern = mantlePattern;
    }
    else
    {
        currentPattern = corePattern;
    }

    Regex regex = new Regex(currentPattern);

    if (regex.IsMatch(inputLIne) && i == 2)
    {
        coreLength = regex.Match(inputLIne).Length;
    }
    if (regex.IsMatch(inputLIne) == false)
    {
        isFine = false;
    }
}
if (isFine)
{
    Console.WriteLine("Valid");
    Console.WriteLine($"{coreLength}");
}
else
{
    Console.WriteLine("Invalid");
}