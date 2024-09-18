string word = Console.ReadLine();
char[] alphabet = new char[26];
int index = 0;
for (char i = 'a'; i <= 'z'; i++)
{
    alphabet[index++] = i;
}

foreach (char letter in word)
{
    int foundIndex = Array.IndexOf(alphabet, letter);

    Console.WriteLine($"{letter} -> {foundIndex}");
}