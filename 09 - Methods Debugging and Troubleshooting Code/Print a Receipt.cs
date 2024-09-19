var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
Console.WriteLine(@"/------------------\");
foreach (var num in nums)
{
    Console.WriteLine("|{0,17:f2} |", num);
}
Console.WriteLine(@"|------------------|");
Console.WriteLine("| Total:{0,10:f2} |", nums.Sum());
Console.WriteLine(@"\------------------/");