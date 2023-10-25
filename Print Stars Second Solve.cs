PrintStars();

static void PrintStars()
{
    for (int i = 1; i <= 20; i++)
    {
        Console.WriteLine(new string('*', i + 1));
    }
}