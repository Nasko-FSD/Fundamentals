var firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
var secondArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
var maxLength = Math.Max(firstArray.Length, secondArray.Length);
var sumArrays = new int[maxLength];
for (int equal = 0; equal < maxLength; equal++)
{
    var firstEqual = firstArray[equal % firstArray.Length];
    var secondEqual = secondArray[equal % secondArray.Length];
    sumArrays[equal] = firstEqual + secondEqual;
}
Console.WriteLine(string.Join(" ", sumArrays));