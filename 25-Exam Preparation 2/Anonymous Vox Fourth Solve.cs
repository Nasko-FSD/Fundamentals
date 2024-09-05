using System.Text;
using System.Text.RegularExpressions;

string inputText = Console.ReadLine();
string placeHolderPattern = @"(?<start>[a-zA-Z]+)(?<placeHolder>.+)(\k<start>)";

List<string> values = Console.ReadLine()
    .Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries)
    .ToList();

MatchCollection matches = Regex.Matches(inputText, placeHolderPattern);

StringBuilder sb = new StringBuilder(inputText);

foreach (Match matched in matches)
{
    if (values.Count > 0)
    {
        string currentMatch = matched.ToString();

        int matchIndex = -1;

        for (int i = 0; i <= sb.Length - currentMatch.Length; i++)
        {
            // Compare the substring starting at position i with currentMatch
            if (sb.ToString(i, currentMatch.Length) == currentMatch)
            {
                matchIndex = i;
                break;
            }
        }

        if (matchIndex >= 0)
        {
            string newBlock = matched.Groups["start"].Value + values[0] + matched.Groups["start"].Value;

            sb.Remove(matchIndex, currentMatch.Length);
            sb.Insert(matchIndex, newBlock);

            values.RemoveAt(0);
        }
    }
    else
    {
        break;
    }
}

Console.WriteLine(sb.ToString());