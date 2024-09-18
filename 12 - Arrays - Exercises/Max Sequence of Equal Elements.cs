var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
int counter = 1;
int maxSequence = 0;
int elements = 0;
for (int i = 0; i < nums.Length - 1; i++)
{
    if (nums[i] == nums[i + 1])
    {
        counter++;
    }
    else
    {
        counter = 1;
    }
    if (counter > maxSequence)
    {
        maxSequence = counter;
        elements = nums[i];
    }
}
for (int j = 0; j < maxSequence; j++)
{
    Console.Write(string.Join(" ", elements + " "));
}