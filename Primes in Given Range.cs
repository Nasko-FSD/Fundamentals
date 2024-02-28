int startNumber = int.Parse(Console.ReadLine());
int endNumber = int.Parse(Console.ReadLine());

List<int> result = FindPrimesInRange(startNumber, endNumber);
Console.WriteLine(string.Join(", ", result));

static List<int> FindPrimesInRange(int startNumber, int endNumber)
{
    List<int> result = new List<int>();
    for (int i = startNumber; i <= endNumber; i++)
    {
        if (IsPrime(i))
        {
            result.Add(i);
        }
    }
    return result;
}

static bool IsPrime(int startNumber)
{
    bool IsPrime = (startNumber > 1);
    for (int i = 2; i <= Math.Sqrt(startNumber); i++)
    {
        if (startNumber % i == 0)
        {
            IsPrime = false;
            break;
        }
    }
    return IsPrime;
}