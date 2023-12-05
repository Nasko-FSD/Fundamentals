var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
var sortedNumbers = numbers.OrderBy(x => -x);
var largest3Numbers = sortedNumbers.Take(3);
Console.WriteLine(string.Join(" ", largest3Numbers));