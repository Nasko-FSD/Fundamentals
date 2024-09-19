StringRepeater();

static void StringRepeater()
{
    string Text = Console.ReadLine();
    int num = int.Parse(Console.ReadLine());
    for (int repeat = 1; repeat <= num; repeat++)
    {
        Console.Write($"{Text}");
    }
}