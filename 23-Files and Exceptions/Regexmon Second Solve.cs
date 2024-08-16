using System.Text.RegularExpressions;

Regex bojoRegex = new Regex(@"[a-zA-Z]+\-[a-zA-Z]+");
Regex didiRegex = new Regex(@"[^a-zA-Z\-]+");

string text = Console.ReadLine();

while (true)
{

    Match didiMatch = didiRegex.Match(text);
    if (didiMatch.Success == false)
    {
        break;
    }
    int didiIndex = didiMatch.Index + didiMatch.Length;
    text = text.Substring(didiIndex);
    Console.WriteLine(didiMatch.Value);

    Match bojoMatch = bojoRegex.Match(text);
    if (bojoMatch.Success == false)
    {
        break;
    }
    int bojoIndex = bojoMatch.Index + bojoMatch.Length;
    text = text.Substring(bojoIndex);
    Console.WriteLine(bojoMatch.Value);
}