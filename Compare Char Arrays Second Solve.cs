char[] firstArray = Console.ReadLine()
    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
    .Select(char.Parse)
    .ToArray();
char[] secondArray = Console.ReadLine()
    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
    .Select(char.Parse)
    .ToArray();
int minLength = Math.Min(firstArray.Length, secondArray.Length);
int i;
for (i = 0; i < minLength; i++)
{
    if (firstArray[i] != secondArray[i])
    {
        break;
    }
}
if (i == minLength)
{
    if (firstArray.Length < secondArray.Length)
    {
        Console.WriteLine(string.Join("", firstArray));
        Console.WriteLine(string.Join("", secondArray));
    }
    else
    {
        Console.WriteLine(string.Join("", secondArray));
        Console.WriteLine(string.Join("", firstArray));
    }
}
else if (firstArray[i] < secondArray[i])
{
    Console.WriteLine(string.Join("", firstArray));
    Console.WriteLine(string.Join("", secondArray));
}
else
{
    Console.WriteLine(string.Join("", secondArray));
    Console.WriteLine(string.Join("", firstArray));
}