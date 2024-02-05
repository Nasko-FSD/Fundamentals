string number = Console.ReadLine();
bool isLong = long.TryParse(number, out long longResult);
if (isLong == false)
{
    Console.WriteLine($"{number} can't fit in any type");
}
else
{
    Console.WriteLine($"{number} can fit in:");
    bool isSbyte = sbyte.TryParse(number, out sbyte sbyteresult);
    if (isSbyte)
    {
        Console.WriteLine($"* sbyte");
    }
    bool isByte = byte.TryParse(number, out byte byteresult);
    if (isByte)
    {
        Console.WriteLine($"* byte");
    }
    bool isShort = short.TryParse(number, out short shortresult);
    if (isShort)
    {
        Console.WriteLine($"* short");
    }
    bool isUshort = ushort.TryParse(number, out ushort Ushortresult);
    if (isUshort)
    {
        Console.WriteLine($"* ushort");
    }
    bool isInt = int.TryParse(number, out int intresult);
    if (isInt)
    {
        Console.WriteLine($"* int");
    }
    bool isUint = uint.TryParse(number, out uint uintresult);
    if (isUint)
    {
        Console.WriteLine($"* uint");
    }
    Console.WriteLine("* long");
}