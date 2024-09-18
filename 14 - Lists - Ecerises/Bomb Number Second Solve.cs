List<int> numbers = Console.ReadLine()
    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();
List<int> specialNumbers = Console.ReadLine()
    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();
int bombNumber = specialNumbers[0];
int range = specialNumbers[1];

for (int i = 0; i < numbers.Count; i++)
{
    if (numbers[i] == bombNumber)
    {
        int startIndex = Math.Max(0, i - range);
        int endIndex = Math.Min(numbers.Count - 1, i + range);

        numbers.RemoveRange(startIndex, endIndex - startIndex + 1);
        i = Math.Max(startIndex - 1, 0); // Adjust loop index to accommodate removed elements
    }
}

int sum = numbers.Sum();
Console.WriteLine(sum);