PrintingTriangle();
static void PrintingTriangle()
{
    int number = int.Parse(Console.ReadLine());
    var count = 1;
    for (int UpperRows = 1; UpperRows <= number; UpperRows++)
    {
        for (int col = 1; col <= count; col++)
        {
            Console.Write(col + " ");
        }
        Console.WriteLine();
        count++;
    }
    for (int UpperRows = 1; UpperRows <= number; UpperRows++)
    {
        for (int col = 1; col <= count - 2; col++)
        {
            Console.Write(col + " ");
        }
        Console.WriteLine();
        count--;
    }
}