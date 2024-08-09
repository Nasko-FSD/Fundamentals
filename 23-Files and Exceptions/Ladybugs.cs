class Ladybugs
{
    static void Main()
    {
        int fieldSize = int.Parse(Console.ReadLine());

        if (fieldSize == 0)
        {
            return;
        }

        int[] field = new int[fieldSize];

        int[] initialBugs = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        foreach (var index in initialBugs)
        {
            if (index < 0 ||
                fieldSize <= index)
            {
                continue;
            }
            field[index] = 1;
        }

        string command = Console.ReadLine();

        while (command != "end")
        {
            var tokens = command
                .Split()
                .ToArray();
            int index = int.Parse(tokens[0]);
            string direction = tokens[1];
            int length = int.Parse(tokens[2]);

            if (direction == "left")
            {
                length *= -1;
            }

            if (index < field.Length &&
            index >= 0)
            {
                if (field[index] != 0)
                {
                    if (length != 0)
                    {
                        Fly(field, index, length);
                        field[index] = 0;
                    }
                }

            }

            command = Console.ReadLine();
        }

        Console.WriteLine(string.Join(" ", field));
    }
    public static void Fly(int[] field, int index, int length)
    {
        if (index + length >= field.Length ||
            index + length < 0)
        {
            return;
        }

        int target = field[index + length];

        if (target == 1)
        {
            Fly(field, index + length, length);
        }
        else
        {
            field[index + length] = 1;
        }
    }
}