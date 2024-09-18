int[] inputArray = Console.ReadLine()
    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int difference = int.Parse(Console.ReadLine());
int counter = 0;
for (int i = 0; i < inputArray.Length; i++)
{
    for (int j = i + 1; j < inputArray.Length; j++)
    {
        if (inputArray[i] - inputArray[j] == difference || inputArray[j] - inputArray[i] == difference)
        {
            counter++;
        }
    }
}
Console.WriteLine(counter);