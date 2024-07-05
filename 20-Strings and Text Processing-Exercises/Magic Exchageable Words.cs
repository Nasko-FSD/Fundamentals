string[] tokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
char[] word1 = tokens[0].ToCharArray();
char[] word2 = tokens[1].ToCharArray();
word1 = word1.Distinct().ToArray();
word2 = word2.Distinct().ToArray();

if (word1.Length != word2.Length)
{
    Console.WriteLine("false");
}
else
{
    Dictionary<char, char> IsMagic = new Dictionary<char, char>();
    for (int i = 0; i < word1.Length; i++)
    {
        if (IsMagic.ContainsKey(word1[i]) == false)
        {
            IsMagic[word1[i]] = word2[i];
        }
        else if (IsMagic[word1[i]] != word2[i])
        {
            Console.WriteLine("false");
            break;
        }
    }
    Console.WriteLine("true");
}