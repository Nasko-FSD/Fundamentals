PrintIntegerToBase();

static void PrintIntegerToBase()
{
    int number = int.Parse(Console.ReadLine());
    int toBase = int.Parse(Console.ReadLine());
    string result = string.Empty;
    string remainder = string.Empty;
    while (number > 0)
    {
        remainder = (number % toBase).ToString();
        result = result.Insert(0, remainder);
        number /= toBase;
    }
    Console.WriteLine(result);
}