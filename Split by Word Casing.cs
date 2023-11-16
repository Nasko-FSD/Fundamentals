var inputText = Console.ReadLine();
var separators = ",;:.!()\"'/\\[] ".ToArray();
var words = inputText.Split(separators, StringSplitOptions.RemoveEmptyEntries);
var lowerWords = new List<string>();
var mixedWords = new List<string>();
var upperWords = new List<string>();
foreach (var word in words)
{
    var lowerLetters = 0;
    var upperLetters = 0;
    foreach (var letter in word)
    {
        if (char.IsLower(letter))
        {
            lowerLetters++;
        }
        if (char.IsUpper(letter))
        {
            upperLetters++;
        }
    }
    if (upperLetters == word.Length)
    {
        upperWords.Add(word);
    }
    else if (lowerLetters == word.Length)
    {
        lowerWords.Add(word);
    }
    else
        mixedWords.Add(word);
}
Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerWords));
Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedWords));
Console.WriteLine("Upper-case: {0}", string.Join(", ", upperWords));