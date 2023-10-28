string DataType = Console.ReadLine();
string FirstInput = Console.ReadLine();
string SecondInput = Console.ReadLine();
switch (DataType)
{
    case "int":
        int FirstInt = int.Parse(FirstInput);
        int SecondInt = int.Parse(SecondInput);
        int ResultInt = PrintInt(FirstInt, SecondInt);
        Console.WriteLine(ResultInt); break;
    case "char":
        char FirstChar = char.Parse(FirstInput);
        char SecondChar = char.Parse(SecondInput);
        char ResultChar = PrintChar(FirstChar, SecondChar);
        Console.WriteLine(ResultChar); break;
    case "string":
        string FirstString = FirstInput;
        string SecondString = SecondInput;
        string ResultString = PrintString(FirstInput, SecondInput);
        Console.WriteLine(ResultString); break;
}
static int PrintInt(int FirstInt, int SecondInt)
{
    return Math.Max(FirstInt, SecondInt);
}
static char PrintChar(char FirstChar, char SecondChar)
{
    return (char)Math.Max(FirstChar, SecondChar);
}
static string PrintString(string FirstString, string SecondString)
{
    int ResultString = FirstString.CompareTo(SecondString);
    if (ResultString > 0)
    {
        return (FirstString);
    }
    else
    {
        return (SecondString);
    }
}