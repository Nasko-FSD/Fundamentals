List<string> numbers = Console.ReadLine()
    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
    .ToList();
List<int> result = new List<int>(numbers.Count);

foreach (var number in numbers)
{
    char[] resultArray = number.ToCharArray();
    Array.Reverse(resultArray);
    result.Add(int.Parse(new string(resultArray)));
}

int sum = result.Sum();

Console.WriteLine(sum);