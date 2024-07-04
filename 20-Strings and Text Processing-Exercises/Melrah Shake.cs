string word = Console.ReadLine();
string pattern = Console.ReadLine();
while (true)
{
    int indexFirst = word.IndexOf(pattern);
    int indexLast = word.LastIndexOf(pattern);
    if (indexFirst == indexLast)
    {
        break;
    }
    Console.WriteLine("Shaked it.");
    word = word.Remove(indexLast, pattern.Length);
    word = word.Remove(indexFirst, pattern.Length);
    pattern = pattern.Remove(pattern.Length / 2, 1);
    if (pattern.Length < 1)
    {
        break;
    }
}
Console.WriteLine("No shake.");
Console.Write($"{word}");