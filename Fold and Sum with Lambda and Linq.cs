int[] sampleArray = Console.ReadLine()
    .Split(' ').Select(int.Parse).ToArray();
int length = sampleArray.Length / 4;
var rowOneLeft = sampleArray.Take(length).Reverse();
var rowOneRight = sampleArray.Reverse().Take(length);
int[] rowOne = rowOneLeft.Concat(rowOneRight).ToArray();
int[] rowTwo = sampleArray.Skip(length).Take(2 * length).ToArray();
var sum = rowOne.Select((x, index) => x + rowTwo[index]);
Console.WriteLine(string.Join(", ", sum));