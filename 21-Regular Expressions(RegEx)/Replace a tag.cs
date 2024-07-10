using System.Text.RegularExpressions;
while (true)
{
    string inputLine = Console.ReadLine();
    if (inputLine == "end")
    {
        break;
    }
    string pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
    string replacement = @"[URL href=$1]$2[/URL]";

    inputLine = Regex.Replace(inputLine, pattern, replacement);
    Console.WriteLine(inputLine);
}