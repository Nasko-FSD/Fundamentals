int counter = 0;
while (true)
{
    string input = Console.ReadLine();
    try
    {
        int number = int.Parse(input);
        counter++;
    }
    catch (Exception)
    {
        Console.WriteLine(counter);
        break;
    }
}