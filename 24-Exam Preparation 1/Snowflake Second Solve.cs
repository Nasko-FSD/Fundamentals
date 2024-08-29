using System.Text.RegularExpressions;

string lines = string.Empty;
string surffacePattern = @"[^A-Za-z0-9]+";
string mantlePattern = @"[_0-9]+";
string corePattern = @"[a-zA-Z]+";
bool isAllFine = true;
int coreLength = -1;

for (int i = 1; i <= 5; i+=1)
{
    lines += Console.ReadLine();
    string currentPattern = string.Empty;
    if (i == 1 || i == 5)
    {
        currentPattern = surffacePattern;
    }
    else if (i == 2 || i == 4)
    {
        currentPattern = mantlePattern;
    }
    else
    {
        currentPattern = corePattern;
    }

    Regex regex = new Regex(currentPattern);

    if (regex.IsMatch(lines) && i == 3)
    {
        coreLength = regex.Match(lines).Length;
    }
    if (regex.IsMatch(lines) == false)
    {
        isAllFine = false;
    }
}
if (isAllFine)
{
    Console.WriteLine("Valid");
    Console.WriteLine(coreLength);
}
else
{
    Console.WriteLine("Invalid");
}