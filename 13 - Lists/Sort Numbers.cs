var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
numbers.Sort();
Console.WriteLine(string.Join(" <= ", numbers));