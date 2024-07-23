using System.Text.RegularExpressions;

var usernames = Console.ReadLine()
           .Split(new char[] { '\\', '/', '(', ')', ' ' }, StringSplitOptions.RemoveEmptyEntries)
           .ToArray();

var validUsernames = new List<string>();

string pattern = @"^[A-Za-z][A-Za-z\d_]{2,24}$";
var reg = new Regex(pattern);

for (int i = 0; i < usernames.Length; i++)
{
    if (reg.IsMatch(usernames[i]))
    {
        validUsernames.Add(usernames[i]);
    }
}

var maxLenght = 0;
var startIndex = 0;
for (int i = 0; i < validUsernames.Count - 1; i++)
{
    if (validUsernames[i].Length + validUsernames[i + 1].Length > maxLenght)
    {
        maxLenght = validUsernames[i].Length + validUsernames[i + 1].Length;
        startIndex = i;
    }
}
Console.WriteLine(validUsernames[startIndex]);
Console.WriteLine(validUsernames[startIndex + 1]);