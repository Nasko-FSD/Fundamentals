Random rnd = new Random();
var nums = new List<int>();
for (int i = 0; i < 100; i++)
{
    nums.Add(rnd.Next(10, 21));
}
Console.WriteLine(string.Join(" ", nums));