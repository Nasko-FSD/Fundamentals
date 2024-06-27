
using System.Numerics;

class Program
{
    static void Main()
    {
        BigInteger convertedNumbers = ConvertedNumbers();
        PrintResult(convertedNumbers);
    }

    static void PrintResult(BigInteger convertedNumbers)
    {
        Console.WriteLine(convertedNumbers);
    }

    static BigInteger ConvertedNumbers()
    {
        string[] numberAndBase = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int toBase = int.Parse(numberAndBase[0]);
        string number = numberAndBase[1].ToString();
        BigInteger sum = 0;
        int pow = 0;
        for (int i = number.Length - 1; i >= 0; i--)
        {
            char currentChar = number[i];
            int currentNumber = int.Parse(currentChar.ToString());
            BigInteger currentSum = currentNumber * BigInteger.Pow(toBase, pow);
            sum += currentSum;
            pow++;
        }
        return sum;
    }
}