var separators = ". , : ; ( ) [ ] \" ' ! ? "
    .ToArray();
var inputText = Console.ReadLine()
    .ToLower()
    .Split(separators, StringSplitOptions.RemoveEmptyEntries)
    .Where(x => x.Length < 5)
    .OrderBy(x => x)
    .Distinct();
Console.WriteLine(string.Join(", ", inputText));