var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
var rotator = int.Parse(Console.ReadLine());
var sumArray = new int[numbers.Length];
for (int i = 0; i < rotator; i++)
{
    for (int j = 0; j < numbers.Length; j++)
    {
        var oldElement = numbers[j];
        numbers[j] = numbers[numbers.Length - 1];
        numbers[numbers.Length - 1] = oldElement;
    }
    for (int sum = 0; sum < numbers.Length; sum++)
    {
        sumArray[sum] += numbers[sum];
    }
}
Console.WriteLine(string.Join(" ", sumArray));