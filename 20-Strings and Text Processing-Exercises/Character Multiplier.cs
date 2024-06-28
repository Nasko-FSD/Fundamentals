class Program
{
    static void Main()
    {
        int inputString = ReadInput();
        PrintResult(inputString);
    }

    static void PrintResult(int inputString)
    {
        Console.Write(inputString);
    }

    static int ReadInput()
    {
        string[] inputText = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries);
        string stringOne = inputText[0];
        string stringTwo = inputText[1];
        int maxLength = Math.Max(stringOne.Length, stringTwo.Length);
        int totalSum = 0;
        for (int i = 0; i < maxLength; i++)
        {
            if (i < stringOne.Length && i < stringTwo.Length)
            {
                totalSum += stringOne[i] * stringTwo[i];
            }
            else if (i < stringOne.Length)
            {
                totalSum += stringOne[i];
            }
            else
            {
                totalSum += stringTwo[i];
            }
        }
        return totalSum;
    }
}