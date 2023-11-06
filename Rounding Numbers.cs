var nums = Console.ReadLine().Split(new char[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
for (int i = 0; i < nums.Length; i++)
{
    int rounded;
    if (nums[i] > 0)
    {
        rounded = (int)(nums[i] + 0.5);
    }
    else
    {
        rounded = (int)(nums[i] - 0.5);
    }
    Console.WriteLine($"{nums[i]} => {rounded}");
}