using System.Text;

string firstString = Console.ReadLine().TrimStart('0');
string secondString = Console.ReadLine();
StringBuilder result = new StringBuilder();
int remainder = 0;
int sum = 0;
int maxLength = Math.Max(firstString.Length, secondString.Length);
int num1;
int num2 = int.Parse(secondString);
if (num2 == 0)
{
    result.Append(0);
}
else
{
    for (int i = 0; i < maxLength; i++)
    {
        num1 = int.Parse(firstString[firstString.Length - 1 - i].ToString());
        sum = num1 * num2 + remainder;
        int lastDigit = sum % 10;
        result.Insert(0, lastDigit);
        remainder = sum / 10;
    }
    if (remainder > 0)
    {
        result.Insert(0, remainder);
    }
}
Console.WriteLine(result);