string[] firstArray = Console.ReadLine()
    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
string[] secondArray = Console.ReadLine()
    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
int minLength = Math.Min(firstArray.Length, secondArray.Length);
int leftCounter = 0;
int rightCounter = 0;

for (int i = 0; i < minLength; i++)
{
    if (firstArray[i] == secondArray[i])
    {
        leftCounter++;
    }
    if (firstArray[firstArray.Length - i - 1] == secondArray[secondArray.Length - i - 1]) 
    {
        rightCounter++;
    }
}
int biggestCounter = Math.Max(rightCounter, leftCounter);
Console.WriteLine(biggestCounter);