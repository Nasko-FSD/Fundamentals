string inputText = Console.ReadLine();
string pattern = Console.ReadLine();
while (true)
{
    int indexFirst = inputText.IndexOf(pattern);
    int indexSecond = inputText.LastIndexOf(pattern);
    if (indexFirst == - 1 || indexFirst == indexSecond || pattern == "")
    {
        Console.WriteLine("No shake.");
        break;
    }
    inputText = inputText.Remove(indexSecond, pattern.Length);
    inputText = inputText.Remove(indexFirst, pattern.Length);
    pattern = pattern.Remove(pattern.Length / 2, 1);
    Console.WriteLine("Shaked it.");
}
Console.WriteLine(inputText);