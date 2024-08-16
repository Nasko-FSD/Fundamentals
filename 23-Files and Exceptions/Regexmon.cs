using System.Text.RegularExpressions;

string inputLine = Console.ReadLine();
string didiPattern = @"([^a-zA-Z\-])+";
string bojomonPattern = @"[a-zA-Z]+-[a-zA-Z]+";
int endIndex = inputLine.Length - 1;
int didiIndex = 0;
int bojoIndex = 0;
int didiCounter = 0;
int bojoCounter = 0;
for (int i = 0; i < inputLine.Length; i++)
{
    if (i % 2 == 0 &&
        didiIndex < endIndex)
    {
        MatchCollection didiMatches = Regex.Matches(inputLine, didiPattern);
        if (didiMatches.Count > 0)
        {
            Match didiMatch = didiMatches[didiCounter];
            didiIndex = didiMatch.Index + didiMatch.Length - 1;
            Console.WriteLine(didiMatch);
            didiCounter++;
        }
    }
    if (didiIndex == endIndex &&
        bojoIndex != 0)
    {
        break;
    }
    if (i % 2 == 1 &&
        bojoIndex < endIndex)
    {
        MatchCollection bojoMatches = Regex.Matches(inputLine, bojomonPattern);
        if (bojoMatches.Count > 0)
        {
            Match bojoMatch = bojoMatches[bojoCounter];
            bojoIndex = bojoMatch.Index + bojoMatch.Length - 1;
            Console.WriteLine(bojoMatch);
            bojoCounter++;
        }
    }
    if (bojoIndex == endIndex)
    {
        break;
    }
}