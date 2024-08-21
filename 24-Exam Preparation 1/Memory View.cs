string inputLine = Console.ReadLine();
string allInput = "";
while (inputLine != "Visual Studio crash")
{
    allInput += inputLine + " ";
    inputLine = Console.ReadLine();
}

int[] tokens = allInput
    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int[] length = new int[1];
int[] allNumbers = new int[1];
int startIndex = 0;
for (int i = 0; i < tokens.Length; i++)
{
    if (tokens[i] == 32656)
    {
        length = tokens
           .Skip(i + 4)
           .Take(1)
           .ToArray();

        allNumbers = new int[length[0]];
        startIndex = i;
    }

    else
    {
        continue;
    }

    for (int j = 1; j <= allNumbers.Length; j++)
    {
        int currentChar = tokens[startIndex + 6];
        char letter = (char)currentChar;
        Console.Write(letter);
        startIndex++;
    }
    Console.WriteLine();
}