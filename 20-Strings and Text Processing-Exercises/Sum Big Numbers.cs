using System.Text;

string stringOne = Console.ReadLine().TrimStart('0');
string stringTwo = Console.ReadLine().TrimStart('0');
int length = Math.Max(stringOne.Length, stringTwo.Length);
StringBuilder result = new StringBuilder(length + 1);
int remainder = 0;
stringOne = stringOne.PadLeft(length, '0');
stringTwo = stringTwo.PadLeft(length, '0');
for (int i = length - 1; i >= 0; i--)
{
    int num1 = int.Parse(stringOne[i].ToString());
    int num2 = int.Parse(stringTwo[i].ToString());
    int sum = num1 + num2 + remainder;
    int lastDigit = sum % 10;
    result.Append(lastDigit);
    remainder = sum / 10;
}
if (remainder > 0)
{
    result.Append(remainder);
}
for (int j = result.Length - 1; j >= 0; j--)
{
    Console.Write(result[j]);
}