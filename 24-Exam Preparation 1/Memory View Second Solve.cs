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

for (int i = 0; i < tokens.Length - 5; i++)
{
    if (tokens[i] == 32656)
    {
        int length = tokens[i + 4];

        for (int j = i + 6; j < i + 6 + length; j++)
        {
            int currentChar = tokens[j];
            char letter = (char)currentChar;
            Console.Write(letter);
        }
        Console.WriteLine();
    }
}