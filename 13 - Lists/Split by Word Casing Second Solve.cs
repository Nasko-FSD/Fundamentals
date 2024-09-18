var inputText = Console.ReadLine();
var separators = ",;:.!()\"'/ \\ [] ".ToArray();
var words = inputText.Split(separators, StringSplitOptions.RemoveEmptyEntries);
var lowerWords = new List<string>();
var mixedWords = new List<string>();
var upperWords = new List<string>();
foreach (var word in words)
{
    if (word.All(char.IsLower))
    {
        lowerWords.Add(word);
    }
    else if (word.All(char.IsUpper))
    {
        upperWords.Add(word);
    }
    else
    {
        mixedWords.Add(word);
    }
}
Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerWords));
Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedWords));
Console.WriteLine("Upper-case: {0}", string.Join(", ", upperWords));