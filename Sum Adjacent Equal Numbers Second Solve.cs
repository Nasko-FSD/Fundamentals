var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
int position = 0;
while (position < nums.Count - 1)
{
    if (nums[position] == nums[position + 1])
    {
        nums[position] = nums[position] + nums[position + 1];
        nums.RemoveAt(position + 1);
        position--;
        if (position < 0)
        {
            position = 0;
        }
    }
    else
        position++;
}
Console.WriteLine(string.Join(" ", nums));