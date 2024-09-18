List<double> input = Console.ReadLine()
    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
    .Select(double.Parse)
    .ToList();

List<double> numbers = new List<double>();
List<int> count = new List<int>();

input.Sort();
foreach (var number in input)
{
    if (numbers.Contains(number) == false)
    {
        numbers.Add(number);
        count.Add(1);
    }
    else
    {
        int index = numbers.IndexOf(number);
        count[index]++;
    }
}
for (int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine($"{numbers[i]} -> {count[i]}");
}