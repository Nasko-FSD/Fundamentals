string inputText = Console.ReadLine();
for (int letters = 0; letters < inputText.Length; letters++)
{
    //char letter = inputText[letters];
    //Console.WriteLine($"inputText[{letters}] = '{letter}'");
    Console.WriteLine($"inputText[{letters}] = '{inputText[letters]}'");
}