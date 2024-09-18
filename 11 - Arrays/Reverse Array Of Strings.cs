string[] words = Console.ReadLine().Split(' ').ToArray();
for (int i = 0; i < words.Length / 2; i++)
{
    string oldWords = words[i];
    words[i] = words[words.Length - 1 - i];
    words[words.Length - 1 - i] = oldWords;
}
foreach (string word in words)
{
    Console.WriteLine(word);
}