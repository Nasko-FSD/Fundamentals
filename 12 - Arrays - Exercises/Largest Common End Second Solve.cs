string[] wordsOne = Console.ReadLine().Split(' ');
string[] wordsTwo = Console.ReadLine().Split(' ');
var count1 = 0;
var count2 = 0;
for (int i = 0; i < wordsOne.Length && i < wordsTwo.Length; i++)
{
    if (wordsOne[i] == wordsTwo[i])
    {
        count1++;
    }
}
for (int j = 0; j < wordsOne.Length && j < wordsTwo.Length; j++)
{
    if (wordsOne[wordsOne.Length - j - 1] == wordsTwo[wordsTwo.Length - j - 1])
    {
        count2++;
    }
}
Console.WriteLine(Math.Max(count1, count2));