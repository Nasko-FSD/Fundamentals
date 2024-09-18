var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
for (int i = 0; i < nums.Count - 1; i++)
{
    if (nums[i] == nums[i + 1])
    {
        nums[i] = nums[i] + nums[i + 1];
        nums.RemoveAt(i + 1);
        i = i - 2;
        if (i < 0)
        {
            i = -1;
        }
    }
}
Console.WriteLine(string.Join(" ", nums));