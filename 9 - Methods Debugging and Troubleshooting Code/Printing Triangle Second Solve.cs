int num = int.Parse(Console.ReadLine());

PrintTriangle(num);
static void PrintTriangle(int num)
{
    PrintTopPart(num);
    PrintBottomPart(num);
}

static void PrintBottomPart(int num)
{
    for (int row = num - 1; row >= 1; row--)
    {
        for (int col = 1; col <= row; col++)
        {
            Console.Write(col + " ");
        }
        Console.WriteLine();
    }
}

static void PrintTopPart(int num)
{
    for (int row = 1; row <= num; row++)
    {
        for (int col = 1; col <= row; col++)
        {
            Console.Write(col + " ");
        }
        Console.WriteLine();
    }
}