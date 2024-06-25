string inputText = Console.ReadLine();
string[] words = inputText
    .Split(".,!? ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
List<string> palindromes = new List<string>();
foreach (var word in words)
{
    bool isPalindrome = IsPalindrome(word);
    if (isPalindrome)
    {
        palindromes.Add(word);
    }
}
var sorted = palindromes
    .Distinct()
    .OrderBy(w => w);
Console.WriteLine(string.Join(", ", sorted));

static bool IsPalindrome(string word)
{
    string reversed = new string(word.Reverse().ToArray());
    return String.Equals(reversed, word);
}