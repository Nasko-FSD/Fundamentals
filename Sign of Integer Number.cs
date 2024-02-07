int input = int.Parse(Console.ReadLine());
string sign = GetNumberSign(input);
Console.WriteLine($"The number {input} is {sign}");

GetNumberSign(input);
static string GetNumberSign(int input)
{
    string result = "";
    if (input > 0)
    {
        result = "positive.";
    }
    else if (input < 0)
    {
        result = "negative.";
    }
    else
    {
        result = "zero.";
    }
    return result;
}