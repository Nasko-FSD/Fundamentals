using System.Text.RegularExpressions;
string searchingWord = Console.ReadLine();
string[] inputLine = Console.ReadLine()
    .Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
string pattern = $@"\W{searchingWord}\W";
var validSentences = inputLine
    .Where(sentence => Regex.IsMatch(sentence, pattern))
    .Select(sentence => sentence.Trim());
foreach (var sentence in validSentences)
{
    Console.WriteLine(sentence);
}