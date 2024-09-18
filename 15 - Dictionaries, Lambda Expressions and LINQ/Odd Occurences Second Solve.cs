List<string> inputString = Console.ReadLine()
    .ToLower()
    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
    .ToList();
Dictionary<string, int> oddOccurence = new Dictionary<string, int>();
List<string> oddWords = new List<string>();
foreach (var word in inputString)
{
    if (oddOccurence.ContainsKey(word))
    {
        oddOccurence[word]++;
    }
    else
    {
        oddOccurence[word] = 1;
    }
}
foreach (var word in oddOccurence)
{
    if (word.Value % 2 == 1)
    {
        oddWords.Add(word.Key);
    }
}
Console.WriteLine(string.Join(", ", oddWords));