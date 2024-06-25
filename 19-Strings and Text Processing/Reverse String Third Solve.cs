using System.Text;

class Program
{
    static void Main()
    {
        string inputText = Console.ReadLine();
        string reversedString = ReverseString(inputText);
        Console.WriteLine(reversedString);
    }

    static string ReverseString(string inputText)
    {
        StringBuilder reversed = new StringBuilder();
        for (int i = inputText.Length - 1; i >= 0; i--)
        {
            reversed.Append(inputText[i]);
        }
        return reversed.ToString();
    }
}