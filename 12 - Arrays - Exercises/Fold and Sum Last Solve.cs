int[] numbers = Console.ReadLine()
    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int[] leftPart = new int[numbers.Length / 4];
int[] rightPart = new int[numbers.Length / 4];
int[] sumArray = new int[numbers.Length / 2];
for (int i = 0; i < numbers.Length / 4; i++)
{
    leftPart[i] = numbers[numbers.Length / 4 - 1 - i];
    rightPart[i] = numbers[numbers.Length - 1 - i];

    sumArray[i] = leftPart[i] + numbers[numbers.Length / 4 + i];
    sumArray[sumArray.Length / 2 + i] = rightPart[i] + numbers[numbers.Length / 2 + i];
}
Console.WriteLine(string.Join(" ", sumArray));