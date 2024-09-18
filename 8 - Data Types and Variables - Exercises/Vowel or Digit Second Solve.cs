var symbol = Console.ReadLine();
try
{
	int.Parse(symbol);
    Console.WriteLine("digit");
}
catch (Exception)
{
	char letter = char.Parse(symbol);
	if(letter == 'a' ||
	    letter == 'o' ||
		letter == 'e' ||
        letter == 'i' ||
        letter == 'u' ||
        letter == 'y')
	{
        Console.WriteLine("vowel");
    }
    else
    {
        Console.WriteLine("other");
    }
}