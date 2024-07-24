using System.IO;
using System.Text;
using System.Text.RegularExpressions;
Stream inputStream = Console.OpenStandardInput(8192);
Console.SetIn(new StreamReader(inputStream, Console.InputEncoding, false, 8192));
string inputLine = Console.ReadLine();
string firstPattern = @"(?<=<p>)(.*?)(?=</p>)";
MatchCollection matches = Regex.Matches(inputLine, firstPattern);
string result = "";
foreach (Match match in matches)
{
    result += match.Groups[1].ToString();
}
string replacePattern = @"([^a-z\d])";
result = Regex.Replace(result, replacePattern, " ");
string secondReplace = @"(\s+|\n+)";
result = Regex.Replace(result, secondReplace, " ");
StringBuilder completeResult = new StringBuilder();
foreach (var ch in result)
{
    if (ch >= 'a' && ch <= 'm')
    {
        completeResult.Append((char)(ch + 13));
    }
    else if (ch >= 'n' && ch <= 'z')
    {
        completeResult.Append((char)(ch - 13));
    }
    else
    {
        completeResult.Append(ch);
    }
}
Console.WriteLine(completeResult);