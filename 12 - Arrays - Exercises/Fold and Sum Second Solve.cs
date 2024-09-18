var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
var result = new int[nums.Length / 2];
for (int i = 0; i < nums.Length / 4; i++)
{
    result[i] = (nums[nums.Length / 4 - 1 - i] + nums[i + nums.Length / 4]);
    result[result.Length / 2 + i] = (nums[nums.Length - i - 1] + nums[(i + nums.Length / 2)]);
}
Console.WriteLine(string.Join(" ", result));