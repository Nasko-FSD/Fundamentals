int n = int.Parse(Console.ReadLine());
int[] nums = new int[n];
for (int i = 0; i < n; i++)
{
    nums[i] = int.Parse(Console.ReadLine());
}
var sum = nums[0];
var min = nums[0];
var max = nums[0];
var first = nums[0];
var last = nums[nums.Length - 1];
for (int i = 1; i < n; i++) 
{
    sum += nums[i];
    if (nums[i] > max) max = nums[i];
    if (nums[i] < min) min = nums[i];
}
var average = (double)sum / n;
Console.WriteLine($"Sum = {sum}");
Console.WriteLine($"Min = {min}");
Console.WriteLine($"Max = {max}");
Console.WriteLine($"First = {first}");
Console.WriteLine($"Last = {last}");
Console.WriteLine($"Average = {average}");