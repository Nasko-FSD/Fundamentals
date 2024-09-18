char[] separators = ".,:;()[]\"'\\/!? ".ToCharArray();
List<string> inputWords = Console.ReadLine()
    .ToLower()
    .Split(separators)
    .ToList();
List<string> result = new List<string>();
foreach (var word in inputWords)
{
    if (word.Length < 5 && word != "")
    {
        result.Add(word);
    }
}
for (int i = 0; i < result.Count; i++)
{
    for (int j = i + 1; j < result.Count; j++)
    {
        if (string.Compare(result[i], result[j]) > 0)
        {
            string temp = result[i];
            result[i] = result[j];
            result[j] = temp;
        }
    }
}
result = result.Distinct().ToList();
Console.WriteLine(string.Join(", ", result));