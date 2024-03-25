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
int bombIndex = numbers.IndexOf(bombNumber);
while (bombIndex != -1)
{
    int startIndex = bombIndex - range;
    int endIndex = bombIndex + range;

    if (startIndex < 0)
    {
        startIndex = 0;
    }
    else if (endIndex > numbers.Count)
    {
        endIndex = numbers.Count - 1;
    }
    int numbersToRemove = endIndex - startIndex + 1;
    numbers.RemoveRange(startIndex, numbersToRemove);
    bombIndex = numbers.IndexOf(bombNumber);
}
int sum = numbers.Sum();
Console.WriteLine(sum);