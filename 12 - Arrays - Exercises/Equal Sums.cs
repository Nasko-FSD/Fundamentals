int[] numbers = Console.ReadLine()
    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int totalSum = 0;
foreach (int number in numbers)
{
    totalSum += number;
}
int leftSum = 0;
int rightSum = totalSum;
bool hasFound = false;
for (int i = 0; i < numbers.Length; i++)
{
    int currentNumber = numbers[i];
    rightSum -= currentNumber;
    if (leftSum == rightSum)
    {
        Console.WriteLine(i);
        hasFound = true;
        break;
    }
    leftSum += currentNumber;
}
if (hasFound == false)
{
    Console.WriteLine("no");
}