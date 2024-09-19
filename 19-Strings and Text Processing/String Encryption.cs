StringEncryption();

static void StringEncryption()
{
    var n = int.Parse(Console.ReadLine());
    string result = "";
    for (int word = 0; word < n; word++)
    {
        char chars = Console.ReadLine()[0];
        byte asciiValue = Convert.ToByte(chars);
        int firstDigit = asciiValue / 100;
        int secondDigit = asciiValue / 10 % 10;
        int thirdDigit = asciiValue % 10;
        char firstChar = Convert.ToChar(thirdDigit + asciiValue);
        if (firstDigit == 0)
        {
            firstDigit = secondDigit;
        }
        char secondChar = Convert.ToChar(asciiValue - firstDigit);
        for (int strings = 1; strings <= 1; strings++)
        {
            result += $"{firstChar}{firstDigit}{thirdDigit}{secondChar}";
        }
    }
    Console.WriteLine(result);
}