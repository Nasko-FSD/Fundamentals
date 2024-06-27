
using System.Numerics;

class Program
{
    static void Main()
    {
        string convertedNumbers = ConvertedNumbers();
        PrintIntegerToBase(convertedNumbers);
    }

    static void PrintIntegerToBase(string convertedNumbers)
    {
        Console.WriteLine(convertedNumbers);
    }

    static string ConvertedNumbers()
    {
        string[] toBaseAndNumber = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries);
        int toBase = int.Parse(toBaseAndNumber[0]);
        BigInteger number = BigInteger.Parse(toBaseAndNumber[1]);
        string result = string.Empty;
        while (number > 0)
        {
            string remainder = (number % toBase).ToString();
            result = result.Insert(0, remainder);
            number /= toBase;
        }
        return result;
    }
}