var inputText = Console.ReadLine();
string[] words = Console.ReadLine().Split(' ');
foreach (var word in words)
{
    inputText = inputText.Replace(word, new string('*', word.Length));
}
Console.WriteLine(inputText);