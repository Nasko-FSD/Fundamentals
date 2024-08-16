using System.Text.RegularExpressions;

Regex bojoRegex = new Regex(@"[a-zA-Z]+\-[a-zA-Z]+");
Regex didiRegex = new Regex(@"[^a-zA-Z\-]+");

string text = Console.ReadLine();

int index = 0;
while (true)
{
    Match didiMatch = didiRegex.Match(text, index);

    if (didiMatch.Success == false)
    {
        break;
    }

    index = didiMatch.Index + didiMatch.Length;
    Console.WriteLine(didiMatch.Value, index);

    Match bojoMatch = bojoRegex.Match(text, index);

    if (bojoMatch.Success == false)
    {
        break;
    }

    index = bojoMatch.Index + bojoMatch.Length;
    Console.WriteLine(bojoMatch.Value);
}