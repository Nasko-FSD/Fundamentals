var words = Console.ReadLine()
    .Split(' ')
    .ToArray();
Random rnd = new Random();
for (int i = 0; i < words.Length; i++)
{
    var randomPosition = rnd.Next(words.Length);
    var oldPosition = words[i];
    words[i] = words[randomPosition];
    words[randomPosition] = oldPosition;
}
Console.WriteLine(string.Join("\r\n", words));