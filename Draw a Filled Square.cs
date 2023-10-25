int n = int.Parse(Console.ReadLine());

PrintHeader(n);
PrintBody(n);
PrintHeader(n);
static void PrintHeader(int n)
{
    Console.WriteLine(new string('-', n * 2));
}

static void PrintBody(int n)
{
    for (int row = 1; row <= n - 2; row++)
    {
        Console.Write("-");
        for (int col = 1; col < n; col++)
        {
            Console.Write("\\/");
        }
        Console.WriteLine("-");
    }
}