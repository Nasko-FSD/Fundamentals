var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
Console.WriteLine(string.Join(" ", numbers.OrderBy(x => -x).Take(3)));