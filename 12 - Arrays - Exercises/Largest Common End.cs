int count1 = 0;
int count2 = 0;
string[] wordsA = Console.ReadLine().Split(' ').ToArray();
string[] wordsB = Console.ReadLine().Split(' ').ToArray();
for (int i = 0; i < Math.Min(wordsA.Length, wordsB.Length); i++)
{
    if (wordsB[i].Equals(wordsA[i]))
        count1++;
}
Array.Reverse(wordsA);
Array.Reverse(wordsB);
for (int i = 0; i < Math.Min(wordsA.Length, wordsB.Length); i++)
{
    if (wordsB[i].Equals(wordsA[i]))
        count2++;
}
Console.WriteLine(Math.Max(count1, count2));