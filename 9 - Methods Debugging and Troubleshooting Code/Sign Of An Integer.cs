SignOfAnInteger();

static void SignOfAnInteger()
{
    int number = int.Parse(Console.ReadLine());
    if (number > 0)
    {
        Console.WriteLine($"The number {number} is positive.");
    }
    if (number == 0)
    {
        Console.WriteLine($"The number {number} is zero.");
    }
    if (number < 0)
    {
        Console.WriteLine($"The number {number} is negative.");
    }
}