int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
while(numbers.Length > 1)
{
    int[] condensedNumbers = new int[numbers.Length - 1];
    for (int i = 0; i < numbers.Length - 1; i++)
    {
        condensedNumbers[i] = numbers[i] + numbers[i + 1];
    }
        numbers = condensedNumbers;
}
Console.WriteLine(numbers[0]);