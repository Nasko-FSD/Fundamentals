using System.Text.RegularExpressions;
using System.IO;
Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));
var pattern = @"<p>(.*?)<\/p>";

var input = Console.ReadLine();

Regex regex = new Regex(pattern);

var matches = regex.Matches(input);

Regex rep = new Regex(@"[^a-z\d]");
Regex tag = new Regex(@"(\s+|\n+)");

var result = string.Empty;

foreach (Match item in matches)
{
    result += item.Groups[1].ToString();
}
result = rep.Replace(result, " ");
result = tag.Replace(result, " ");

var newResult = string.Empty;

for (int i = 0; i < result.Length; i++)
{
    if (char.IsLetter(result[i]))
    {
        if (result[i] <= 109)
        {
            newResult += (char)(result[i] + 13);
        }
        else
        {
            newResult += (char)(result[i] - 13);
        }
    }
    else
    {
        newResult += result[i];
    }
}

Console.WriteLine(newResult);