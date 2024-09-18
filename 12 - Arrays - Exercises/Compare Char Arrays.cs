char[] firstArray = Console.ReadLine()
    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
    .Select(char.Parse)
    .ToArray();
char[] secondArray = Console.ReadLine()
    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
    .Select(char.Parse)
    .ToArray();
int minLength = Math.Min(firstArray.Length, secondArray.Length);

for (int i = 0; i < minLength; i++)
{
    if (firstArray[i] < secondArray[i])
    {
        Console.WriteLine(string.Join("", firstArray));
        Console.WriteLine(string.Join("", secondArray));
        break;
    }
    else if (firstArray[i] > secondArray[i])
    {
        Console.WriteLine(string.Join("", secondArray));
        Console.WriteLine(string.Join("", firstArray));
        break;
    }
    else
    {
        if (minLength == firstArray.Length)
        {
            Console.WriteLine(string.Join("", firstArray));
            Console.WriteLine(string.Join("", secondArray));
            break;
        }
        else
        {
            Console.WriteLine(string.Join("", secondArray));
            Console.WriteLine(string.Join("", firstArray));
            break;
        }
    }
}