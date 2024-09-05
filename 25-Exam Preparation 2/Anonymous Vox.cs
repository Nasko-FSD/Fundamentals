using System.Text.RegularExpressions;

string inputText = Console.ReadLine();
string placeHolderPattern = @"(?<start>[a-zA-Z]+)(?<placeHolder>.+)(\k<start>)";

List<string> values = Console.ReadLine()
    .Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries)
    .ToList();

MatchCollection matches = Regex.Matches(inputText, placeHolderPattern);

foreach (Match matched in matches)
{
    if (values.Count > 0)
    {
        string currentMatch = matched.ToString();

        //string onlyPlaceHolder = matched.Groups["placeHolder"].Value.ToString(); 

        string newBlock = matched.Groups["start"].Value + values[0] + matched.Groups["start"].Value;

        inputText = inputText.Replace(currentMatch, newBlock);

        values.RemoveAt(0);
    }
    else
    {
        break;
    }
}
Console.WriteLine(inputText);