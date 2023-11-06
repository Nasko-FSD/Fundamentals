var nums = Console.ReadLine().Split(new char[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
for (int i = 0; i < nums.Length / 2; i++)
{
    var old = nums[i];
    nums[i] = nums[nums.Length - i - 1];
    nums[nums.Length - i - 1] = old; 
}
Console.WriteLine(string.Join(" ", nums));