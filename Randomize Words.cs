var words = Console.ReadLine()
    .Split(' ')
    .ToList();
Random rnd = new Random();
var result = new List<string>();
while (words.Count > 0)
{
    var randomPosition = rnd.Next(0, words.Count()); 
    result.Add(words[randomPosition]);
    words.RemoveAt(randomPosition);
}
Console.WriteLine(string.Join("\r\n", result));