using System.Text.RegularExpressions;

string text = Console.ReadLine();
string pattern = @"\b[a-zA-Z]\w{2,24}\b";
Regex regex = new Regex(pattern);
MatchCollection matchCollection = regex.Matches(text);
int sum = 0;
int maxSum = 0;
string first = "";
string second = "";
for (int i = 0; i < matchCollection.Count - 1; i++)
{
    sum = matchCollection[i].Length + matchCollection[i + 1].Length;

    if (sum > maxSum)
    {
        maxSum = sum;
        first = matchCollection[i].ToString();
        second = matchCollection[i + 1].ToString();
    }
}
Console.WriteLine(first);
Console.WriteLine(second);