List<int> numbers = Console.ReadLine()
    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

string[] commands = Console.ReadLine()
    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

static List<int> GetOdds(List<int> numbers, string[] commands)
{
    if (commands[0] == "Odd")
    {
        numbers.RemoveAll(x => x % 2 == 0);
    }
    return numbers;
}

static List<int> GetEvens(List<int> numbers, string[] commands)
{
    if (commands[0] == "Even")
    {
        numbers.RemoveAll(x => x % 2 != 0);
    }
    return numbers;
}

static List<int> DeleteNumbers(List<int> numbers, string[] commands)
{
    int element = int.Parse(commands[1]);
    numbers.RemoveAll(x => x == element);
    return numbers;
}

static List<int> InsertNumbers(List<int> numbers, string[] commands)
{
    int index = int.Parse(commands[2]);
    int element = int.Parse(commands[1]);
    numbers.Insert(index, element);
    return numbers;
}

static void PrintNumbers(List<int> numbers)
{
    Console.WriteLine(string.Join(" ", numbers));
}

if (string.IsNullOrEmpty(commands[0]))
{
    PrintNumbers(numbers);
}
else
{
    while (commands[0] != "Odd" &&
           commands[0] != "Even")
    {
        if (commands[0] == "Delete")
        {
            DeleteNumbers(numbers, commands);
        }
        else if (commands[0] == "Insert")
        {
            InsertNumbers(numbers, commands);
        }
        commands = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        if (commands[0] == "Odd" ||
            commands[0] == "Even")
        {
            break;
        }
    }
}

if (commands[0] == "Odd")
{
    GetOdds(numbers, commands);
    PrintNumbers(numbers);
}
else
{
    GetEvens(numbers, commands);
    PrintNumbers(numbers);
}