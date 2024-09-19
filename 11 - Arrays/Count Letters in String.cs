string inputText = Console.ReadLine().ToLower();
int[] count = new int[inputText.Max() + 1];
foreach (var letter in inputText)
{
    count[letter]++;
}
for (char letters = (char)0; letters < count.Length; letters++)
{
    if (count[letters] != 0)
    {
        Console.WriteLine($"{letters} -> {count[letters]}");
    }
}