string[] bannedWords = Console.ReadLine()
    .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
string inputText = Console.ReadLine();
foreach (var word in bannedWords)
{
    inputText = inputText.Replace(word, new string('*', word.Length), StringComparison.OrdinalIgnoreCase);
}
Console.WriteLine(inputText);