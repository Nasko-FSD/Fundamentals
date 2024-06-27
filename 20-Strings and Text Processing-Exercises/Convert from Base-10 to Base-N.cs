using System.Numerics;
using System.Text;

class Program
{
    static void Main()
    {
        string converNumbers = ConvertNumbers();
        PrintResult(converNumbers);
    }

    static void PrintResult(string converNumbers)
    {
        Console.WriteLine(converNumbers);
    }

    static string ConvertNumbers()
    {
        string[] baseAndNumber = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
        int toBase = int.Parse(baseAndNumber[0]);
        BigInteger number = BigInteger.Parse(baseAndNumber[1]);
        StringBuilder converted = new StringBuilder();
        while (number > 0)
        {
            BigInteger remainder = number % toBase;
            converted.Append(remainder);
            number /= toBase;
        }
        //string reversed = string
        //    .Concat(converted
        //    .ToString()
        //    .Reverse());
        string reversed = string
            .Join("", converted
            .ToString()
            .Reverse());
        //for (int i = converted.Length - 1; i >= 0; i--)
        //{
        //    reversed += converted[i];
        //}
        return reversed;
    }
}