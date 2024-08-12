int fieldSize = int.Parse(Console.ReadLine());

if (fieldSize == 0)
{
    return;
}

int[] fieldValues = new int[fieldSize];
int[] initialBugs = Console.ReadLine()
    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
string[] commands = Console.ReadLine()
    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

foreach (var index in initialBugs)
{
    if (index >= 0 &&
        index < fieldSize)
    {
        fieldValues[index] = 1;
    }
}
while (true)
{
    if (commands[0] == "end")
    {
        break;
    }

    int fieldKey = int.Parse(commands[0]);
    string direction = commands[1];
    int fieldValue = int.Parse(commands[2]);

    if (fieldKey < 0 ||
        fieldKey >= fieldSize ||
        fieldValues[fieldKey] == 0)
    {
        commands = Console.ReadLine()
        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        continue;
    }

    fieldValues[fieldKey] = 0;

    if (direction == "right")
    {
        fieldKey += fieldValue;
    }

    else if (direction == "left")
    {
        fieldKey -= fieldValue;
    }

    while (fieldKey >= 0 &&
           fieldKey < fieldSize &&
           fieldValues[fieldKey] == 1)
    {
        if (direction == "right")
        {
            fieldKey += fieldValue;
        }

        else if (direction == "left")
        {
            fieldKey -= fieldValue;
        }
    }

    if (fieldKey >= 0 &&    
        fieldKey < fieldSize)
    {
        fieldValues[fieldKey] = 1;
    }

    commands = Console.ReadLine()
        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
}
foreach (var index in fieldValues)
{
    Console.Write(index + " ");
}