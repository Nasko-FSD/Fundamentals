
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
        BigInteger number = BigInteger.Parse(numberAndBase[1]);
        BigInteger sum = 0;
        int pow = 0;
        while (number > 0)
        {

            BigInteger currentNumber = number % 10;
            BigInteger currentSum = currentNumber * BigInteger.Pow(toBase, pow);
            sum += currentSum;
            number /= 10;
            pow++;
        }
        return sum;
    }
}