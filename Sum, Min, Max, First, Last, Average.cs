string line = Console.ReadLine();
string[] tokens = line.Split(new char[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
var nums = new int[tokens.Length];
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = int.Parse(tokens[i]);
}
Console.WriteLine($"Sum = {nums.Sum()}");
Console.WriteLine($"Min = {nums.Min()}");
Console.WriteLine($"Max = {nums.Max()}");
Console.WriteLine($"First = {nums.First()}");
Console.WriteLine($"Last = {nums.Last()}");
Console.WriteLine($"Average = {nums.Average()}");