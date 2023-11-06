var nums = Console.ReadLine().Split(new char[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
for (int i = 0; i < nums.Length; i++)
{
    int rounded = (int)Math.Round(nums[i], MidpointRounding.AwayFromZero);
    Console.WriteLine($"{nums[i]} => {rounded}");
}