int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
var count = 0;
for (int left = 0; left < numbers.Length; left++)
{
    for (int right = left + 1; right < numbers.Length; right++)
    {
        int a = numbers[left];
        int b = numbers[right];
        int sum = a + b;
        if (numbers.Contains(sum))
        {
            Console.WriteLine($"{numbers[left]} + {numbers[right]} == {sum}");
            count++;
        }
    }
}
if (count == 0)
{
    Console.WriteLine("No");
}