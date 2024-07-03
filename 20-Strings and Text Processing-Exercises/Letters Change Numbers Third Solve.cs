string[] input = Console.ReadLine()
.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

decimal sum = 0;

foreach (var substring in input)
{
    char firstLetter = substring[0];

    char lastLetter = substring[substring.Length - 1];

    string numberStr = substring.Substring(1, substring.Length - 2);

    decimal number = decimal.Parse(numberStr);

    if (char.IsUpper(firstLetter))
    {
        sum += number / (firstLetter - 64);
    }
    else if (char.IsLower(firstLetter))
    {
        sum += number * (firstLetter - 96);
    }

    if (char.IsUpper(lastLetter))
    {
        sum -= lastLetter - 64;
    }
    else if (char.IsLower(lastLetter))
    {
        sum += lastLetter - 96;
    }
}

Console.WriteLine($"{sum:f2}");