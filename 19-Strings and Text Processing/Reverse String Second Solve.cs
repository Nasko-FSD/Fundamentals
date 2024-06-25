string inputText = Console.ReadLine();
string reversedString = string.Empty;
for (int i = inputText.Length - 1; i >= 0; i--)
{
    reversedString += inputText[i];
}
Console.WriteLine(reversedString);