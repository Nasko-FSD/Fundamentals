string[] words = Console.ReadLine()
    .Split();
Random random = new Random();

for (int i = 0; i < words.Length; i++)
{
    int index = random.Next(0, words.Length);

    var temp = words[i];
    words[i] = words[index];
    words[index] = temp;
}
Console.WriteLine(string.Join(Environment.NewLine, words));