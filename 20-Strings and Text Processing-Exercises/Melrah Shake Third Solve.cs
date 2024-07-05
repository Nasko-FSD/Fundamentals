string inputText = Console.ReadLine();
string pattern = Console.ReadLine();
while (true)
{
    int firstIndex = inputText.IndexOf(pattern);
    int lastIndex = inputText.LastIndexOf(pattern);
    if (firstIndex == lastIndex || firstIndex == -1 || pattern == "")
    {
        break;
    }
    inputText = inputText.Remove(lastIndex, pattern.Length);
    inputText = inputText.Remove(firstIndex, pattern.Length);
    pattern = pattern.Remove(pattern.Length / 2, 1);
    Console.WriteLine("Shaked it.");
}
Console.WriteLine("No shake.");
Console.WriteLine($"{inputText}");