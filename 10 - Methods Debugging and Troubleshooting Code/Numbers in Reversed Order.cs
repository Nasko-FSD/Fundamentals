string input = Console.ReadLine();
string reversed = GetReverseInput(input);
Console.WriteLine(reversed);

static string GetReverseInput(string input)
{
    string reversed = "";
    for (int i = input.Length - 1; i >= 0; i--)
    {
        reversed += input[i];
    }
    return reversed;
}