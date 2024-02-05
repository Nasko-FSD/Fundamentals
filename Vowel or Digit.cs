char symbol = char.Parse(Console.ReadLine());
if (symbol == 'a' ||
    symbol == 'o' ||
    symbol == 'u' ||
    symbol == 'e' ||
    symbol == 'i' ||
    symbol == 'y')
{
    Console.WriteLine("vowel");
}
else if (char.IsDigit(symbol))
{
    Console.WriteLine("digit");
}
else
{
    Console.WriteLine("other");
}