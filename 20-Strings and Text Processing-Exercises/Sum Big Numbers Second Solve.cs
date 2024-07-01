using System.Text;

string stringOne = Console.ReadLine().TrimStart('0');
string stringTwo = Console.ReadLine().TrimStart('0');
int maxLength = Math.Max(stringOne.Length, stringTwo.Length);
StringBuilder result = new StringBuilder(maxLength + 1);
int remainder = 0;

for (int i = 0; i < maxLength; i++)
{
    int num1;
    int num2;
    if (i < stringOne.Length)
    {
        num1 = int.Parse(stringOne[stringOne.Length - 1 - i].ToString());
    }
    else
    {
        num1 = 0;
    }

    if (i < stringTwo.Length)
    {
        num2 = int.Parse(stringTwo[stringTwo.Length - 1 - i].ToString());
    }
    else
    {
        num2 = 0;
    }

    int sum = num1 + num2 + remainder;
    int lastDigit = sum % 10;
    result.Insert(0, lastDigit);
    remainder = sum / 10;
}
if (remainder > 0)
{
    result.Insert(0, remainder);
}
Console.WriteLine(result.ToString());