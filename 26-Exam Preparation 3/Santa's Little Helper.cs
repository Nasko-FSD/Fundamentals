using System.Text;
using System.Text.RegularExpressions;

int key = int.Parse(Console.ReadLine());
string namePattern = @"^@[a-zA-Z]+";
string behaviourPattern = @"((!G!)+|(!N!)+)";
string completePattern = @"((@[a-zA-Z]+)([^@\-!:>]+))((!G!)+|(!N!)+)";


List<string> goodChildren = new List<string>();
string input = "";
while ((input = Console.ReadLine()) != "end")
{

    StringBuilder sb = new StringBuilder();
    foreach (var ch in input)
    {
        char currentChar = (char)(ch - key);
        sb.Append(currentChar.ToString());
    }

    MatchCollection matches = Regex.Matches(sb.ToString(), completePattern);

    if (matches.Count > 0)
    {
        MatchCollection matchBehaviour = Regex.Matches(matches[0].ToString(), behaviourPattern);
        string currentBehaviour = matchBehaviour[0].Groups[0].Value.ToString();

        if (currentBehaviour.Contains("G"))
        {
            MatchCollection matchName = Regex.Matches(matches.First().ToString(), namePattern);
            string onlyName = matchName[0].Groups[0].Value.Trim('@').ToString();
            goodChildren.Add(onlyName);
        }
    }
}
Console.WriteLine(string.Join("\n", goodChildren));