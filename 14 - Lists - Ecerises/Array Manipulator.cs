List<int> numbers = Console.ReadLine()
    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();
string[] commands = Console.ReadLine()
    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
string command = commands[0];
while (command != "print")
{
    command = commands[0];
    int index;
    int element;
    if (command == "add")
    {
        index = int.Parse(commands[1]);
        element = int.Parse(commands[2]);
        numbers.Insert(index, element);
    }
    else if (command == "addMany")
    {
        index = int.Parse(commands[1]);
        List<int> numbersToAdd = new List<int>();
        for (int i = 2; i < commands.Length; i++)
        {
            numbersToAdd.Add(int.Parse(commands[i]));
        }
        numbers.InsertRange(index, numbersToAdd);
    }
    else if (command == "contains")
    {
        element = int.Parse(commands[1]);
        index = numbers.IndexOf(element);
        Console.WriteLine(index);
    }
    else if (command == "remove")
    {
        index = int.Parse(commands[1]);
        numbers.RemoveAt(index);
    }
    else if (command == "shift")
    {
        index = int.Parse(commands[1]);
        int rotations = index;
        for (int i = 0; i < rotations % numbers.Count; i++)
        {
            int temp = numbers[0];
            for (int j = 0; j < numbers.Count - 1; j++)
            {
                numbers[j] = numbers[j + 1];
            }
            numbers[numbers.Count - 1] = temp;
        }
    }
    else if (command == "sumPairs")
    {
        for (int i = 0; i < numbers.Count - 1; i++)
        {
            numbers[i] += numbers[i + 1];
            numbers.RemoveAt(i + 1);
        }
    }
    commands = Console.ReadLine()
        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    if (commands[0] == "print")
    {
        break;
    }
}
Console.WriteLine("[{0}]", string.Join(", ", numbers));